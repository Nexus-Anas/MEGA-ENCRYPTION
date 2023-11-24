using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGA_ENCRYPTION
{
    public partial class ActivationForm : Form
    {
        public ActivationForm()
        {
            InitializeComponent();
        }




        /////////////////////////////////////Settings/////////////////////////////////////////////
        private bool _mouseDown;
        private Point _startPoint = new Point(0, 0);
        //////////////////////////////////////////////////////////////////////////////////////////
        



        /////////////////////////////////////Header Panel/////////////////////////////////////////
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void btnAbout_MouseEnter(object sender, EventArgs e) => btnAbout.Size = new Size(30, 30);
        private void btnAbout_MouseLeave(object sender, EventArgs e) => btnAbout.Size = new Size(25, 25);
        private void btnAbout_Click(object sender, EventArgs e) => new AboutForm().ShowDialog();


        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true; _startPoint = new Point(e.X, e.Y);
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                var point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }
        private void Header_MouseUp(object sender, MouseEventArgs e) => _mouseDown = false;
        //////////////////////////////////////////////////////////////////////////////////////////




        //////////////////////////////////////Functions///////////////////////////////////////////
        private async void btnActivate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKey.Text))
            {
                MessageBox.Show("Please enter activation key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblWait.Visible = true;
            if (ACTIVATION.活性化(txtKey.Text))
            {
                new MainForm().Show();
                Close();
            }
            lblWait.Visible = false;
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        

    }
}
