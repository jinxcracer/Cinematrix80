﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinematrix
{
    public partial class Loading_Screen : Form
    {
        public Loading_Screen()
        {
            InitializeComponent();
        }

        private void Loading_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Welcome");

                
                this.Hide();

               
                LOGIN loginForm = new LOGIN();
                loginForm.ShowDialog();

                
                this.Close();
            }
         }

            private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
