namespace MEGA_ENCRYPTION
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAbout = new System.Windows.Forms.PictureBox();
            this.txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.PanelDrop = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblClick = new Guna.UI.WinForms.GunaLabel();
            this.txtPsw = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDec = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnc = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).BeginInit();
            this.PanelDrop.SuspendLayout();
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
            this.Header.TabIndex = 7;
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
            this.toolTip1.SetToolTip(this.btnExit, "CLose");
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
            // txtPath
            // 
            this.txtPath.Animated = true;
            this.txtPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtPath.BorderRadius = 10;
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.DefaultText = "";
            this.txtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.DisabledState.Parent = this.txtPath;
            this.txtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPath.FocusedState.Parent = this.txtPath;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.Color.White;
            this.txtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.HoverState.Parent = this.txtPath;
            this.txtPath.Location = new System.Drawing.Point(12, 78);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPath.PlaceholderText = "no file selected";
            this.txtPath.ReadOnly = true;
            this.txtPath.SelectedText = "";
            this.txtPath.ShadowDecoration.Parent = this.txtPath;
            this.txtPath.Size = new System.Drawing.Size(285, 30);
            this.txtPath.TabIndex = 16;
            this.txtPath.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(12, 52);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(73, 19);
            this.gunaLabel3.TabIndex = 15;
            this.gunaLabel3.Text = "File Path";
            // 
            // PanelDrop
            // 
            this.PanelDrop.AllowDrop = true;
            this.PanelDrop.BackColor = System.Drawing.Color.Transparent;
            this.PanelDrop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.PanelDrop.Controls.Add(this.lblClick);
            this.PanelDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelDrop.Location = new System.Drawing.Point(13, 154);
            this.PanelDrop.Name = "PanelDrop";
            this.PanelDrop.Size = new System.Drawing.Size(284, 170);
            this.PanelDrop.TabIndex = 17;
            this.PanelDrop.Click += new System.EventHandler(this.PanelDrop_Click);
            this.PanelDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelDrop_DragDrop);
            this.PanelDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelDrop_DragEnter);
            // 
            // lblClick
            // 
            this.lblClick.AllowDrop = true;
            this.lblClick.AutoSize = true;
            this.lblClick.BackColor = System.Drawing.Color.Transparent;
            this.lblClick.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.ForeColor = System.Drawing.Color.White;
            this.lblClick.Location = new System.Drawing.Point(76, 61);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(131, 44);
            this.lblClick.TabIndex = 11;
            this.lblClick.Text = "Click here or\r\nDrag your file";
            this.lblClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClick.Click += new System.EventHandler(this.lblClick_Click);
            this.lblClick.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblClick_DragDrop);
            this.lblClick.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblClick_DragEnter);
            // 
            // txtPsw
            // 
            this.txtPsw.Animated = true;
            this.txtPsw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.txtPsw.BorderRadius = 10;
            this.txtPsw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPsw.DefaultText = "";
            this.txtPsw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPsw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPsw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPsw.DisabledState.Parent = this.txtPsw;
            this.txtPsw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPsw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtPsw.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtPsw.FocusedState.Parent = this.txtPsw;
            this.txtPsw.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPsw.ForeColor = System.Drawing.Color.White;
            this.txtPsw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPsw.HoverState.Parent = this.txtPsw;
            this.txtPsw.Location = new System.Drawing.Point(12, 354);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '•';
            this.txtPsw.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPsw.PlaceholderText = "type your password";
            this.txtPsw.SelectedText = "";
            this.txtPsw.ShadowDecoration.Parent = this.txtPsw;
            this.txtPsw.Size = new System.Drawing.Size(285, 30);
            this.txtPsw.TabIndex = 18;
            this.txtPsw.TextOffset = new System.Drawing.Point(2, 0);
            this.txtPsw.UseSystemPasswordChar = true;
            // 
            // btnDec
            // 
            this.btnDec.Animated = true;
            this.btnDec.BackColor = System.Drawing.Color.Transparent;
            this.btnDec.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnDec.BorderRadius = 12;
            this.btnDec.BorderThickness = 2;
            this.btnDec.CheckedState.Parent = this.btnDec;
            this.btnDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDec.CustomImages.Parent = this.btnDec;
            this.btnDec.FillColor = System.Drawing.Color.Transparent;
            this.btnDec.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.ForeColor = System.Drawing.Color.White;
            this.btnDec.HoverState.Parent = this.btnDec;
            this.btnDec.Location = new System.Drawing.Point(164, 424);
            this.btnDec.Name = "btnDec";
            this.btnDec.ShadowDecoration.BorderRadius = 12;
            this.btnDec.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnDec.ShadowDecoration.Depth = 50;
            this.btnDec.ShadowDecoration.Enabled = true;
            this.btnDec.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDec.ShadowDecoration.Parent = this.btnDec;
            this.btnDec.Size = new System.Drawing.Size(132, 45);
            this.btnDec.TabIndex = 20;
            this.btnDec.Text = "DECRYPT";
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnEnc
            // 
            this.btnEnc.Animated = true;
            this.btnEnc.BackColor = System.Drawing.Color.Transparent;
            this.btnEnc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnEnc.BorderRadius = 12;
            this.btnEnc.BorderThickness = 2;
            this.btnEnc.CheckedState.Parent = this.btnEnc;
            this.btnEnc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnc.CustomImages.Parent = this.btnEnc;
            this.btnEnc.FillColor = System.Drawing.Color.Transparent;
            this.btnEnc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnc.ForeColor = System.Drawing.Color.White;
            this.btnEnc.HoverState.Parent = this.btnEnc;
            this.btnEnc.Location = new System.Drawing.Point(12, 424);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.ShadowDecoration.BorderRadius = 12;
            this.btnEnc.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnEnc.ShadowDecoration.Depth = 50;
            this.btnEnc.ShadowDecoration.Enabled = true;
            this.btnEnc.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEnc.ShadowDecoration.Parent = this.btnEnc;
            this.btnEnc.Size = new System.Drawing.Size(132, 45);
            this.btnEnc.TabIndex = 19;
            this.btnEnc.Text = "ENCRYPT";
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(310, 493);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.PanelDrop);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).EndInit();
            this.PanelDrop.ResumeLayout(false);
            this.PanelDrop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox btnAbout;
        private Guna.UI2.WinForms.Guna2Button btnDec;
        private Guna.UI2.WinForms.Guna2Button btnEnc;
        private Guna.UI2.WinForms.Guna2TextBox txtPsw;
        private Guna.UI.WinForms.GunaElipsePanel PanelDrop;
        private Guna.UI.WinForms.GunaLabel lblClick;
        private Guna.UI2.WinForms.Guna2TextBox txtPath;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}