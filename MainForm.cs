using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EasyImage
{
    public partial class MainForm : Form
    {

        private PictureBoxSizeMode currentImageSizeMode = PictureBoxSizeMode.Zoom;
        private FileInfo currentFileInfo;
        private string[] supportedExtensions = new string[] { ".png", ".jpg", ".jpeg", ".gif", ".bmp", ".ico", ".jfif" };


        public MainForm(string[] args)
        {
            InitializeComponent();

            changeImageSizeModeButton.Text = Enum.GetName(typeof(PictureBoxSizeMode), currentImageSizeMode);
            mainPictureBox.SizeMode = currentImageSizeMode;

            mainPictureBox.LoadProgressChanged += MainPictureBox_LoadProgressChanged;
            mainPictureBox.LoadCompleted += MainPictureBox_LoadCompleted;

            oneImageBackwardsButton.Enabled = false;
            oneImageForwardsButton.Enabled = false;

            mainPictureBox.ContextMenu = new ContextMenu();

            MenuItem copyImageToClipboardMenuItem = mainPictureBox.ContextMenu.MenuItems.Add("Copy Image");
            MenuItem copyImagePathToClipboardMenuItem = mainPictureBox.ContextMenu.MenuItems.Add("Copy Path");

            copyImageToClipboardMenuItem.Click += CopyImageToClipboardMenuItem_Click;
            copyImagePathToClipboardMenuItem.Click += CopyImagePathToClipboardMenuItem_Click;

            imageLoadProgressBar.Visible = false;

            if (args.Length == 1)
            {
                loadFile(args[0]);
            }

            GC.Collect();

        }

        private void MainPictureBox_LoadProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            imageLoadProgressBar.Value = e.ProgressPercentage;
        }

        private void CopyImagePathToClipboardMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFileInfo != null)
            {
                Clipboard.SetText(currentFileInfo.FullName);
            }
        }

        private void CopyImageToClipboardMenuItem_Click(object sender, EventArgs e)
        {
            if (mainPictureBox.Image != null)
            {
                Clipboard.SetImage(mainPictureBox.Image);
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool _move_mouseDown;
        private Point _move_lastLocation;
        private void _move_MouseDown(object sender, MouseEventArgs e)
        {
            _move_mouseDown = true;
            _move_lastLocation = e.Location;
        }
        private void _move_MouseUp(object sender, MouseEventArgs e)
        {
            _move_mouseDown = false;
        }
        private void _move_MouseMove(object sender, MouseEventArgs e)
        {
            if (_move_mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - _move_lastLocation.X) + e.X, (this.Location.Y - _move_lastLocation.Y) + e.Y
                );

                this.Update();
            }
        }

        private void loadFile(string imagePath)
        {
            imageLoadProgressBar.Value = 0;
            imageLoadProgressBar.Visible = true;

            currentFileInfo = null;

            if (mainPictureBox.Image != null)
            {
                mainPictureBox.Image.Dispose();
                mainPictureBox.Image = null;
                mainPictureBox.ImageLocation = null;
            }

            currentFileInfo = new FileInfo(imagePath);

            GC.Collect();

            mainPictureBox.ImageLocation = imagePath;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.ico;*.jfif";

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    GC.Collect();
                    loadFile(openFileDialog.FileName);
                }
            }

        }

        private void MainPictureBox_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

            imageLoadProgressBar.Visible = false;

            FileInfo[] fileInfos = Array.FindAll(currentFileInfo.Directory.GetFiles().ToArray<FileInfo>(), (v) => { return Array.Exists(supportedExtensions, (extension) => { return extension == v.Extension; }); }); ;
            int currentIndex = Array.FindIndex(fileInfos, (v) => { return v.Name == currentFileInfo.Name; });

            imageInfoInput.Text = $"{currentIndex+1}/{fileInfos.Length} | {mainPictureBox.Image.Width}x{mainPictureBox.Image.Height} | {Math.Round((double)(currentFileInfo.Length / 1024))}kb | {currentFileInfo.Name}";

            oneImageBackwardsButton.Enabled = true;
            oneImageForwardsButton.Enabled = true;
        }


        private void changeImageSizeModeButton_Click(object sender, EventArgs e)
        {
            currentImageSizeMode++;
            int maxImgLayoutValue = Enum.GetValues(typeof(PictureBoxSizeMode)).Cast<int>().Max();
            if ((int)currentImageSizeMode > maxImgLayoutValue) currentImageSizeMode = 0;

            mainPictureBox.SizeMode = currentImageSizeMode;
            changeImageSizeModeButton.Text = Enum.GetName(typeof(PictureBoxSizeMode), currentImageSizeMode);
        }

        private void topMostButton_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;

            topMostButton.Font = TopMost ? new Font(topMostButton.Font, FontStyle.Bold) : new Font("Microsoft Sans Serif",8.25f);
        }

        private void titleLabel_DoubleClick(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {

            if (this.Size.Width < 500)
            {
                topMostButton.Visible = false;
            } else
            {
                topMostButton.Visible = true;
            }

            if (this.Size.Width < 410)
            {
                changeImageSizeModeButton.Visible = false;
            } else
            {
                changeImageSizeModeButton.Visible = true;
            }
        }

        private void oneImageBackwardsButton_Click(object sender, EventArgs e)
        {
            oneImageBackwardsButton.Enabled = false;
            oneImageBackwards();
        }

        private void oneImageForwardButton_Click(object sender, EventArgs e)
        {
            oneImageForwardsButton.Enabled = false;
            oneImageForward();
        }

        private void oneImageBackwards()
        {
            FileInfo[] fileInfos = Array.FindAll(currentFileInfo.Directory.GetFiles().ToArray<FileInfo>(), (v) => { return Array.Exists(supportedExtensions, (extension) => { return extension == v.Extension; }); }); ;
            int currentIndex = Array.FindIndex(fileInfos, (v) => { return v.Name == currentFileInfo.Name; });

            if (currentIndex - 1 < 0)
            {
                MessageBox.Show("No more image");
            }
            else
            {
                loadFile(fileInfos[currentIndex - 1].FullName);
            }
        }

        private void oneImageForward()
        {

            FileInfo[] fileInfos = Array.FindAll(currentFileInfo.Directory.GetFiles().ToArray<FileInfo>(), (v)=> { return Array.Exists(supportedExtensions, (extension)=> { return extension == v.Extension; }); });
            int currentIndex = Array.FindIndex(fileInfos, (v) => { return v.Name == currentFileInfo.Name; });

            if (currentIndex + 1 > fileInfos.Length - 1)
            {
                MessageBox.Show("No More Image");
            }
            else
            {
                loadFile(fileInfos[currentIndex + 1].FullName);
            }
        }

        private void maxMinWindowButton_MouseClick(object sender, MouseEventArgs e)
        {

            if (FormBorderStyle == FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.SizableToolWindow;
                WindowState = FormWindowState.Normal;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

    }
}
