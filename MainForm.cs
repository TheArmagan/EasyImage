using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EasyImage
{
    public partial class MainForm : Form
    {

        private PictureBoxSizeMode currentImageSizeMode = PictureBoxSizeMode.Zoom;
        private FileInfo currentFileInfo;

        public MainForm(string[] args)
        {
            InitializeComponent();

            changeImageSizeModeButton.Text = Enum.GetName(typeof(PictureBoxSizeMode), currentImageSizeMode);
            mainPictureBox.SizeMode = currentImageSizeMode;

            mainPictureBox.LoadCompleted += MainPictureBox_LoadCompleted;

            if (args.Length == 1)
            {
                loadFile(args[0]);
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
            if (mainPictureBox.Image != null)
            {
                mainPictureBox.Image.Dispose();
                mainPictureBox.Image = null;
            }

            mainPictureBox.ImageLocation = imagePath;

            currentFileInfo = new FileInfo(imagePath);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.ico;*.jfif";

                if (openFileDialog.ShowDialog() == DialogResult.OK) {

                    loadFile(openFileDialog.FileName);
                }
            }

        }

        private void MainPictureBox_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            
            imageInfoInput.Text = $"{mainPictureBox.Image.Width}x{mainPictureBox.Image.Height} | {Math.Round((double)(currentFileInfo.Length / 1024))}kb | {currentFileInfo.Name}";

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

            if (this.Size.Width < 450)
            {
                topMostButton.Visible = false;
            } else
            {
                topMostButton.Visible = true;
            }

            if (this.Size.Width < 330)
            {
                changeImageSizeModeButton.Visible = false;
            } else
            {
                changeImageSizeModeButton.Visible = true;
            }
        }

    }
}
