﻿using System;
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
    public partial class MessageFileInUse : Form
    {
        public MessageFileInUse() => InitializeComponent();

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
