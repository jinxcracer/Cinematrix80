namespace Cinematrix
{
    partial class Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_ticket = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Tickets:";
            // 
            // txt_amount
            // 
            this.txt_amount.AutoSize = true;
            this.txt_amount.BackColor = System.Drawing.Color.Transparent;
            this.txt_amount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txt_amount.Location = new System.Drawing.Point(71, 146);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(53, 13);
            this.txt_amount.TabIndex = 2;
            this.txt_amount.Text = "Amount:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(196, 51);
            this.txt_title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(116, 22);
            this.txt_title.TabIndex = 3;
            // 
            // txt_ticket
            // 
            this.txt_ticket.Location = new System.Drawing.Point(196, 79);
            this.txt_ticket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ticket.Name = "txt_ticket";
            this.txt_ticket.Size = new System.Drawing.Size(116, 22);
            this.txt_ticket.TabIndex = 4;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(196, 137);
            this.txtamount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(116, 22);
            this.txtamount.TabIndex = 5;
            this.txtamount.TextChanged += new System.EventHandler(this.txtamount_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDate.Location = new System.Drawing.Point(70, 118);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(34, 13);
            this.txtDate.TabIndex = 6;
            this.txtDate.Text = "Date:";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(196, 109);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(116, 22);
            this.Date.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Receipt";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.Color.White;
            this.printbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbtn.Location = new System.Drawing.Point(124, 180);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(75, 23);
            this.printbtn.TabIndex = 0;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = false;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 256);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.txt_ticket);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_amount;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_ticket;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button printbtn;
    }
}