namespace MEGA_ENCRYPTION
{
    partial class ActivationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivationForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAbout = new System.Windows.Forms.PictureBox();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnActivate = new Guna.UI2.WinForms.Guna2Button();
            this.lblWait = new Guna.UI.WinForms.GunaLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Header.Controls.Add(this.btnMinimize);
            this.Header.Controls.Add(this.btnExit);
            this.Header.Controls.Add(this.btnAbout);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(310, 37);
            this.Header.TabIndex = 8;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.LightGray;
            this.btnMinimize.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnMinimize.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(253, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(16, 16);
            this.btnMinimize.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Animated = true;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LightGray;
            this.btnExit.HoverState.BorderColor = System.Drawing.Color.Tomato;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(280, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(16, 16);
            this.btnExit.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnExit, "Exit");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Image = global::MEGA_ENCRYPTION.Properties.Resources.brainIcon;
            this.btnAbout.Location = new System.Drawing.Point(10, 6);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(25, 25);
            this.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAbout.TabIndex = 24;
            this.btnAbout.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAbout, "About");
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(12, 77);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 20;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(286, 66);
            this.gunaElipsePanel2.TabIndex = 9;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(36, 23);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(219, 22);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Product not Activated";
            // 
            // txtKey
            // 
            this.txtKey.Animated = true;
            this.txtKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.txtKey.BorderRadius = 10;
            this.txtKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey.DefaultText = "";
            this.txtKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.DisabledState.Parent = this.txtKey;
            this.txtKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtKey.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtKey.FocusedState.Parent = this.txtKey;
            this.txtKey.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.ForeColor = System.Drawing.Color.White;
            this.txtKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.HoverState.Parent = this.txtKey;
            this.txtKey.Location = new System.Drawing.Point(12, 177);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtKey.PlaceholderText = "Enter activation key";
            this.txtKey.SelectedText = "";
            this.txtKey.ShadowDecoration.Parent = this.txtKey;
            this.txtKey.Size = new System.Drawing.Size(286, 30);
            this.txtKey.TabIndex = 17;
            this.txtKey.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gunaElipsePanel1.Controls.Add(this.btnActivate);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(12, 366);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(286, 114);
            this.gunaElipsePanel1.TabIndex = 18;
            // 
            // btnActivate
            // 
            this.btnActivate.Animated = true;
            this.btnActivate.BackColor = System.Drawing.Color.Transparent;
            this.btnActivate.BorderRadius = 5;
            this.btnActivate.CheckedState.Parent = this.btnActivate;
            this.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivate.CustomImages.Parent = this.btnActivate;
            this.btnActivate.FillColor = System.Drawing.Color.Cyan;
            this.btnActivate.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.Color.Black;
            this.btnActivate.HoverState.Parent = this.btnActivate;
            this.btnActivate.Location = new System.Drawing.Point(64, 38);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.ShadowDecoration.Parent = this.btnActivate;
            this.btnActivate.Size = new System.Drawing.Size(159, 45);
            this.btnActivate.TabIndex = 7;
            this.btnActivate.Text = "Activate";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.ForeColor = System.Drawing.Color.White;
            this.lblWait.Location = new System.Drawing.Point(94, 314);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(124, 22);
            this.lblWait.TabIndex = 6;
            this.lblWait.Text = "please wait..";
            this.lblWait.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MEGA_ENCRYPTION.Properties.Resources.ANAS_AR_PURPLE;
            this.pictureBox2.Location = new System.Drawing.Point(120, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // ActivationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(310, 493);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActivationForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivationForm";
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI2.WinForms.Guna2Button btnActivate;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Panel Header;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.Windows.Forms.PictureBox btnAbout;
        private Guna.UI.WinForms.GunaLabel lblWait;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}