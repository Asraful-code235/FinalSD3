﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Login login = new Login();
             login.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
             Department  Dep = new Department();
            Dep.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Department Dep = new Department();
            Dep.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Account Ac = new Account();
            Ac.Show();
            this.Hide();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

    

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Department Dep = new Department();
            Dep.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {

            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Account Ac = new Account();
            Ac.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Department Dep = new Department();
            Dep.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            Teacher teach = new Teacher();
            teach.Show();
            this.Hide();
        }
    }
}