﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAngile
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain frmMain = new FormMain();
            this.Hide();
            frmMain.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            this.Hide();
            quenMatKhau.ShowDialog();
            this.Show();
            

        }
    }
}
