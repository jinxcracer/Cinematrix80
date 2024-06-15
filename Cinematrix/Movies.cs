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
    public partial class frmMovies : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmMovieCategory frmcategory;
        public frmMovies(frmMovieCategory flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmcategory = flist;
            cn.Open();
        }

        private void Movies_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtMovies.Clear();
            txtMovies.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save this movie?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    cm = new SqlCommand("SELECT COUNT(*) FROM tblMovie WHERE Movie = @movie", cn);
                    cm.Parameters.AddWithValue("@movie", txtMovies.Text);
                    int count = (int)cm.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This movie is already Added");
                    }
                    else
                    {
                        cm = new SqlCommand("INSERT INTO tblMovie(Movie) VALUES(@movie)", cn);
                        cm.Parameters.AddWithValue("@movie", txtMovies.Text);
                        cm.ExecuteNonQuery();

                        MessageBox.Show("Record has been successfully saved.");
                        Clear();
                        frmcategory.LoadRecords();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this movie?", "Update Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    cm = new SqlCommand("UPDATE tblMovie SET Movie = @movie WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@movie", txtMovies.Text);
                    cm.Parameters.AddWithValue("@id", lblID.Text);
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Movie has been successfully updated.");
                    Clear();
                    frmcategory.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}
