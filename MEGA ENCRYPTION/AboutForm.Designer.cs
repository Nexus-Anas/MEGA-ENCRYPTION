namespace MEGA_ENCRYPTION
{
    partial class AboutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panelClose = new System.Windows.Forms.Panel();
            this.panelGithub = new System.Windows.Forms.Panel();
            this.panelTweet = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MEGA_ENCRYPTION.Properties.Resources.FEEDBACK;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panelClose
            // 
            this.panelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelClose.Location = new System.Drawing.Point(261, 8);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(49, 15);
            this.panelClose.TabIndex = 4;
            this.toolTip1.SetToolTip(this.panelClose, "Close");
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            // 
            // panelGithub
            // 
            this.panelGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelGithub.Location = new System.Drawing.Point(93, 270);
            this.panelGithub.Name = "panelGithub";
            this.panelGithub.Size = new System.Drawing.Size(124, 21);
            this.panelGithub.TabIndex = 5;
            this.toolTip1.SetToolTip(this.panelGithub, "Message Creator");
            this.panelGithub.Click += new System.EventHandler(this.panelGithub_Click);
            // 
            // panelTweet
            // 
            this.panelTweet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTweet.Location = new System.Drawing.Point(93, 349);
            this.panelTweet.Name = "panelTweet";
            this.panelTweet.Size = new System.Drawing.Size(124, 21);
            this.panelTweet.TabIndex = 6;
            this.toolTip1.SetToolTip(this.panelTweet, "Visit URL");
            this.panelTweet.Click += new System.EventHandler(this.panelTweet_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 493);
            this.Controls.Add(this.panelTweet);
            this.Controls.Add(this.panelGithub);
            this.Controls.Add(this.panelClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panelTweet;
        private System.Windows.Forms.Panel panelGithub;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}