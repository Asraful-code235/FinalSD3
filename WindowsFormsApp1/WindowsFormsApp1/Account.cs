﻿using System;
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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASRAFUL;Initial Catalog=Sd2;Integrated Security=True");
        SqlCommand cmd;
        private void populate()
        {
            con.Open();
            string query = "select * from  FeesTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface interfa = new Interface();
             interfa.Show();
               this.Hide();
        }

        private void PaymentDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
