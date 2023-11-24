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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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




        //////////////////////////////////////Drop Panel//////////////////////////////////////////
        private void PanelDrop_Click(object sender, EventArgs e) => FileSelection();
        private void PanelDrop_DragEnter(object sender, DragEventArgs e) => FileEnter(e);
        private void PanelDrop_DragDrop(object sender, DragEventArgs e) => FileDrop(e);

        private void lblClick_Click(object sender, EventArgs e) => FileSelection();
        private void lblClick_DragEnter(object sender, DragEventArgs e) => FileEnter(e);
        private void lblClick_DragDrop(object sender, DragEventArgs e) => FileDrop(e);
        //////////////////////////////////////////////////////////////////////////////////////////
        



        //////////////////////////////////////Functions///////////////////////////////////////////
        void FileSelection()
        {
            var open = new OpenFileDialog()
            {
                Title = "Select file",
                Multiselect = false
            };
            if (open.ShowDialog() == DialogResult.OK)
                txtPath.Text = open.FileName;
        }




        void FileEnter(DragEventArgs e) => e.Effect = DragDropEffects.All;
        void FileDrop(DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            txtPath.Text = files[0];
        }




        void CleanText()
        {
            txtPath.ResetText();
            txtPsw.ResetText();
        }




        private async void btnEnc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath.Text) || string.IsNullOrEmpty(txtPsw.Text))
            {
                MessageBox.Show("Empty fields !\nPlease check again..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            密码.加密(txtPath.Text, txtPsw.Text);
            CleanText();
        }

        private async void btnDec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath.Text) || string.IsNullOrEmpty(txtPsw.Text))
            {
                MessageBox.Show("Empty fields !\nPlease check again..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            密码.解密(txtPath.Text, txtPsw.Text);
            CleanText();
        }



        //////////////////////////////////////////////////////////////////////////////////////////






    }
}
