namespace EasyImage
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topControlPanel = new System.Windows.Forms.Panel();
            this.topMostButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.changeImageSizeModeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.topImageInfoPanel = new System.Windows.Forms.Panel();
            this.imageInfoInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oneImageForwardsButton = new System.Windows.Forms.Button();
            this.oneImageBackwardsButton = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.topControlPanel.SuspendLayout();
            this.topImageInfoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topControlPanel
            // 
            this.topControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.topControlPanel.Controls.Add(this.topMostButton);
            this.topControlPanel.Controls.Add(this.openFileButton);
            this.topControlPanel.Controls.Add(this.changeImageSizeModeButton);
            this.topControlPanel.Controls.Add(this.titleLabel);
            this.topControlPanel.Controls.Add(this.exitButton);
            this.topControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topControlPanel.Location = new System.Drawing.Point(0, 0);
            this.topControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topControlPanel.Name = "topControlPanel";
            this.topControlPanel.Size = new System.Drawing.Size(683, 37);
            this.topControlPanel.TabIndex = 0;
            this.topControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this._move_MouseDown);
            this.topControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this._move_MouseMove);
            this.topControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this._move_MouseUp);
            // 
            // topMostButton
            // 
            this.topMostButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.topMostButton.FlatAppearance.BorderSize = 0;
            this.topMostButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.topMostButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.topMostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topMostButton.Location = new System.Drawing.Point(431, 0);
            this.topMostButton.Margin = new System.Windows.Forms.Padding(4);
            this.topMostButton.Name = "topMostButton";
            this.topMostButton.Size = new System.Drawing.Size(85, 37);
            this.topMostButton.TabIndex = 4;
            this.topMostButton.Text = "TopMost";
            this.topMostButton.UseVisualStyleBackColor = true;
            this.topMostButton.Click += new System.EventHandler(this.topMostButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.openFileButton.FlatAppearance.BorderSize = 0;
            this.openFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.openFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.openFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileButton.Location = new System.Drawing.Point(113, 0);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(64, 37);
            this.openFileButton.TabIndex = 3;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // changeImageSizeModeButton
            // 
            this.changeImageSizeModeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.changeImageSizeModeButton.FlatAppearance.BorderSize = 0;
            this.changeImageSizeModeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.changeImageSizeModeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.changeImageSizeModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeImageSizeModeButton.Location = new System.Drawing.Point(516, 0);
            this.changeImageSizeModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeImageSizeModeButton.Name = "changeImageSizeModeButton";
            this.changeImageSizeModeButton.Size = new System.Drawing.Size(107, 37);
            this.changeImageSizeModeButton.TabIndex = 2;
            this.changeImageSizeModeButton.Text = "Mode";
            this.changeImageSizeModeButton.UseVisualStyleBackColor = true;
            this.changeImageSizeModeButton.Click += new System.EventHandler(this.changeImageSizeModeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(113, 37);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Easy Image";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.DoubleClick += new System.EventHandler(this.titleLabel_DoubleClick);
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this._move_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this._move_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this._move_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(623, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 37);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(2214, 1284);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(10, 10);
            this.elementHost1.TabIndex = 2;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // topImageInfoPanel
            // 
            this.topImageInfoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topImageInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.topImageInfoPanel.Controls.Add(this.imageInfoInput);
            this.topImageInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topImageInfoPanel.Location = new System.Drawing.Point(0, 37);
            this.topImageInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topImageInfoPanel.Name = "topImageInfoPanel";
            this.topImageInfoPanel.Padding = new System.Windows.Forms.Padding(3);
            this.topImageInfoPanel.Size = new System.Drawing.Size(683, 23);
            this.topImageInfoPanel.TabIndex = 0;
            // 
            // imageInfoInput
            // 
            this.imageInfoInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.imageInfoInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageInfoInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageInfoInput.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.imageInfoInput.ForeColor = System.Drawing.Color.White;
            this.imageInfoInput.Location = new System.Drawing.Point(3, 3);
            this.imageInfoInput.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.imageInfoInput.Name = "imageInfoInput";
            this.imageInfoInput.ReadOnly = true;
            this.imageInfoInput.Size = new System.Drawing.Size(677, 15);
            this.imageInfoInput.TabIndex = 0;
            this.imageInfoInput.Text = "Please select an image.";
            this.imageInfoInput.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.oneImageForwardsButton);
            this.panel1.Controls.Add(this.oneImageBackwardsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 36);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this._move_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this._move_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this._move_MouseUp);
            // 
            // oneImageForwardsButton
            // 
            this.oneImageForwardsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.oneImageForwardsButton.FlatAppearance.BorderSize = 0;
            this.oneImageForwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneImageForwardsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oneImageForwardsButton.ForeColor = System.Drawing.Color.White;
            this.oneImageForwardsButton.Location = new System.Drawing.Point(647, 0);
            this.oneImageForwardsButton.Name = "oneImageForwardsButton";
            this.oneImageForwardsButton.Size = new System.Drawing.Size(36, 36);
            this.oneImageForwardsButton.TabIndex = 1;
            this.oneImageForwardsButton.Text = ">";
            this.oneImageForwardsButton.UseVisualStyleBackColor = true;
            this.oneImageForwardsButton.Click += new System.EventHandler(this.oneImageForwardButton_Click);
            // 
            // oneImageBackwardsButton
            // 
            this.oneImageBackwardsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.oneImageBackwardsButton.FlatAppearance.BorderSize = 0;
            this.oneImageBackwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneImageBackwardsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oneImageBackwardsButton.ForeColor = System.Drawing.Color.White;
            this.oneImageBackwardsButton.Location = new System.Drawing.Point(0, 0);
            this.oneImageBackwardsButton.Name = "oneImageBackwardsButton";
            this.oneImageBackwardsButton.Size = new System.Drawing.Size(36, 36);
            this.oneImageBackwardsButton.TabIndex = 0;
            this.oneImageBackwardsButton.Text = "<";
            this.oneImageBackwardsButton.UseVisualStyleBackColor = true;
            this.oneImageBackwardsButton.Click += new System.EventHandler(this.oneImageBackwardsButton_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.mainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 60);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(683, 591);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainPictureBox.TabIndex = 4;
            this.mainPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(683, 687);
            this.ControlBox = false;
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topImageInfoPanel);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.topControlPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.topControlPanel.ResumeLayout(false);
            this.topImageInfoPanel.ResumeLayout(false);
            this.topImageInfoPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topControlPanel;
        private System.Windows.Forms.Button changeImageSizeModeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button topMostButton;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Panel topImageInfoPanel;
        private System.Windows.Forms.TextBox imageInfoInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Button oneImageForwardsButton;
        private System.Windows.Forms.Button oneImageBackwardsButton;
    }
}

