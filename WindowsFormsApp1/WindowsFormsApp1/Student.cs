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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASRAFUL;Initial Catalog=Sd2;Integrated Security=True");
        SqlCommand cmd;
        private void fillDepartment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select DepName from DepartmentTb1", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DepName", typeof(string));
            dt.Load(rdr);
            DepCb.ValueMember = "DepName";
            DepCb.DataSource = dt;
            con.Close();

        }
        private void populate()
        {
            con.Open();
            string query = "select * from  StudentTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StdDataGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (stdid.Text == "" || stdName.Text == "" || GenderCb.Text == "" || stdDateTime.Text == "" || stdPhone.Text == "" || DepCb.Text == "" || stdFees.Text == "" )
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();

                    string query = "insert into StudentTb1 values('" + stdid.Text + "','" + stdName.Text + "','" + GenderCb.SelectedItem.ToString() + "','" + stdDateTime.Text + "','" + stdPhone.Text + "','" + DepCb.SelectedValue.ToString() + "','" + stdFees.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added");
                    con.Close();
                    populate();
                }

            }
            catch
            {
                MessageBox.Show("somethig went missing");
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {
            fillDepartment();
            populate();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface interfac = new Interface();
            interfac.Show();
            this.Hide();
        }
    }
}
