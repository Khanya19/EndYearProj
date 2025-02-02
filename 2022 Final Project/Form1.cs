﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            AgentLoginfrm agentLoginfrm = new AgentLoginfrm();
            agentLoginfrm.Show();
            this.Hide();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            TenantFrm tf = new TenantFrm();
            tf.Show();
            this.Hide();
        }
    }
}
