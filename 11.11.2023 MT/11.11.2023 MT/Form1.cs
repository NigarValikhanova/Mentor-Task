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
using Microsoft.Win32;

namespace _11._11._2023_MT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RJOSFU4\\SQLEXPRESS;Initial Catalog=MYData;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string Name = txtbxName.Text;
            string Surname = txtbxSurname.Text;
            string Query = "insert into Person([Name], Surname) values ('"+Name+"', '"+Surname+"')";
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data inserted");
        }
    }
}
