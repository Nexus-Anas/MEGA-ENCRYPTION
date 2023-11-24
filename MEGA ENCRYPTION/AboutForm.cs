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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            PanelPointToScreen(panelClose);
            PanelPointToScreen(panelGithub);
            PanelPointToScreen(panelTweet);
        }
        void PanelPointToScreen(Panel p)
        {
            var point = this.PointToScreen(p.Location);
            point = pictureBox1.PointToClient(point);
            p.Parent = pictureBox1;
            p.Location = point;
            p.BackColor = Color.FromArgb(0, 0, 0, 0);
        }


        

        private void panelClose_Click(object sender, EventArgs e) => Close();
        private void panelGithub_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("mailto:anas.vigilante@gmail.com");
        private void panelTweet_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://github.com/The-Vigilante");




        /////////////////////////////////////Form Move////////////////////////////////////////////
        private bool _mouseDown;
        private Point _startPoint = new Point(0, 0);
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true; _startPoint = new Point(e.X, e.Y);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                var point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) => _mouseDown = false;
        //////////////////////////////////////////////////////////////////////////////////////////
    }
}
