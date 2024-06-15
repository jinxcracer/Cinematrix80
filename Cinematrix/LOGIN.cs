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

namespace Cinematrix
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VDBAAMB\SQLEXPRESS;Initial Catalog=CinematrixServer;Integrated Security=True;");

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String user_password = txtPassword.Text;

         
            string connectionString = @"Data Source=DESKTOP-VDBAAMB\SQLEXPRESS;Initial Catalog=Cinematrix;Integrated Security=True;"; 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tblLogin WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", user_password);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL error occurred: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}



