namespace GUI
{
    partial class ImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NextImageBtn = new System.Windows.Forms.Button();
            this.PreviousImageBtn = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(1011, 15);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(40, 28);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitButton);
            // 
            // NextImageBtn
            // 
            this.NextImageBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.NextImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextImageBtn.ForeColor = System.Drawing.Color.White;
            this.NextImageBtn.Location = new System.Drawing.Point(1011, 224);
            this.NextImageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NextImageBtn.Name = "NextImageBtn";
            this.NextImageBtn.Size = new System.Drawing.Size(40, 80);
            this.NextImageBtn.TabIndex = 1;
            this.NextImageBtn.Text = ">";
            this.NextImageBtn.UseVisualStyleBackColor = false;
            this.NextImageBtn.Click += new System.EventHandler(this.NextImage);
            // 
            // PreviousImageBtn
            // 
            this.PreviousImageBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.PreviousImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousImageBtn.ForeColor = System.Drawing.Color.White;
            this.PreviousImageBtn.Location = new System.Drawing.Point(16, 224);
            this.PreviousImageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PreviousImageBtn.Name = "PreviousImageBtn";
            this.PreviousImageBtn.Size = new System.Drawing.Size(40, 80);
            this.PreviousImageBtn.TabIndex = 2;
            this.PreviousImageBtn.Text = "<";
            this.PreviousImageBtn.UseVisualStyleBackColor = false;
            this.PreviousImageBtn.Click += new System.EventHandler(this.PreviousImage);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.ForeColor = System.Drawing.Color.Black;
            this.BrowseBtn.Location = new System.Drawing.Point(952, 508);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(100, 28);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.Browse);
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackColor = System.Drawing.Color.SandyBrown;
            this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagePanel.Location = new System.Drawing.Point(84, 15);
            this.ImagePanel.Margin = new System.Windows.Forms.Padding(4);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(899, 486);
            this.ImagePanel.TabIndex = 4;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.PreviousImageBtn);
            this.Controls.Add(this.NextImageBtn);
            this.Controls.Add(this.ExitBtn);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button NextImageBtn;
        private System.Windows.Forms.Button PreviousImageBtn;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Panel ImagePanel;
    }
}

