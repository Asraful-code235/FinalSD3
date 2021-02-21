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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASRAFUL;Initial Catalog=Sd2;Integrated Security=True");
        SqlCommand cmd;
       
        private void populate()
        {
            con.Open();
            string query = "select * from  DepartmentTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DepDataGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameT.Text == "" || DepDesc.Text == "" || DepDuration.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();

                    string query = "insert into DepartmentTb1 values('" + DepNameT.Text + "','" + DepDesc.Text + "','" + DepDuration.Text + "')";
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

        private void Department_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (DepNameT.Text == "")
                {
                    MessageBox.Show("Enter The dapartment name!");
                }
                else
                {
                    con.Open();
                    string query = "delete from DepartmentTb1 where DepName ='" + DepNameT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    con.Close();
                    populate();

                }
            }
            catch
            {
                MessageBox.Show(" Department not detected");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (DepNameT.Text == "" || DepDesc.Text == "" || DepDuration.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    con.Open();
                    string query = "update DepartmentTb1 set DepDesc ='" + DepDesc.Text + "',DepDuration ='" + DepDuration.Text + "' where DepName='" + DepNameT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department updated successfully");
                    con.Close();
                    populate();

                }
            }
            catch
            {
                MessageBox.Show("Ops ..Department not detected!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface Interface = new Interface();
            Interface.Show();
            this.Hide();
        }
    }
}
