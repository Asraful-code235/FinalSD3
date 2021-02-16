using System;
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
    }
}
