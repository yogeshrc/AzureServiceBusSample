﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPublisher
{
    public partial class MessagePublisher : Form
    {
        public MessagePublisher()
        {
            InitializeComponent();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            MessageBox.Show(dateTime.ToString());
        }
    }
}
