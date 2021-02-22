using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASRAFUL;Initial Catalog=Sd2;Integrated Security=True");
        

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            User users = new User();
            users.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Interface home = new Interface();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTable where UserName='" + textBox1.Text + "' and UserPassword='" + textBox3.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                home.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("wrong username and password");
            }
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int counter = 0;
        int len = 0;
        string txt;

        private void Login_Load_1(object sender, EventArgs e)
        {
            txt = htmllabel1.Text;
            len = txt.Length;
            htmllabel1.Text = "";
            timer2.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Interface home = new Interface();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTable where UserName='" + textBox1.Text + "' and UserPassword='" + textBox3.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                home.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("wrong username and password");
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            User users = new User();
            users.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            Interface home = new Interface();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTable where UserName='" + textBox1.Text + "' and UserPassword='" + textBox3.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                home.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("wrong username and password");
            }
            con.Close();
        }
     
        int count = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {


            slide1.BackgroundImage = null;
            if (count < 2)
            {
                slide1.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }
       
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter >len)
            {
                timer2.Stop();
                
            }
            else
            {
                htmllabel1.Text = txt.Substring(0, counter);
            }
           

        }
    }
}
