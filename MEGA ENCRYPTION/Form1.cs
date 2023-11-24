using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGA_ENCRYPTION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }




        /////////////////////////////////////Settings/////////////////////////////////////////////
        private bool _mouseDown;
        private Point _startPoint = new Point(0, 0);
        private int _sec;
        private CancellationTokenSource _cancellationTokenSource;
        //////////////////////////////////////////////////////////////////////////////////////////





        /////////////////////////////////////Timer Tick///////////////////////////////////////////
        private void timer1_Tick(object sender, EventArgs e) => StartLoading();
        //////////////////////////////////////////////////////////////////////////////////////////

        private async void StartLoading()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            try
            {
                await Task.Run(() => LoadMainForm(), _cancellationTokenSource.Token);
            }
            catch (OperationCanceledException) { }
        }

        private void LoadMainForm()
        {
            _sec++;
            if (_sec == 4)
            {
                if (PROCESS.리더())
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        new MainForm().Show();
                        Hide();
                    });
                }
                else if (ACTIVATION.アクティベーションのチェック())
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        new MainForm().Show();
                        Hide();
                    });
                }
                else
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        new ActivationForm().Show();
                        Hide();
                    });
                }
            }
        }




        //////////////////////////////////////Form Move///////////////////////////////////////////
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true; _startPoint = new Point(e.X, e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                var point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e) => _mouseDown = false;
        //////////////////////////////////////////////////////////////////////////////////////////
    }
}
