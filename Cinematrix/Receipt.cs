using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cinematrix
{
    public partial class Receipt : Form
    {
        public Receipt(string title, int tickets, int amount, DateTime bookingDate)
        {
            InitializeComponent();
            txt_title.Text = title;
            txt_ticket.Text = tickets.ToString();
            txtamount.Text = amount.ToString();
           
            Date.Text = bookingDate.ToShortDateString();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Movie Title", new Font("Arial", 20 , FontStyle.Bold),Brushes.Black, new Point(10,10));
            e.Graphics.DrawString("Number of Tickets", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Date", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Time", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Amount", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog1 = new PrintDialog();
            printdialog1.Document = printDocument1;

            DialogResult result = printdialog1.ShowDialog();
        }
    }
}
