namespace Code_PBL3
{
    partial class fShowBill
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTotalEnd = new System.Windows.Forms.Label();
            this.lbDissCount = new System.Windows.Forms.Label();
            this.lbRefund = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbDateCheckOut = new System.Windows.Forms.Label();
            this.lbIDAcc = new System.Windows.Forms.Label();
            this.lbDateCheckIn = new System.Windows.Forms.Label();
            this.txbMoneyCus = new System.Windows.Forms.TextBox();
            this.lbNameTable = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Code_PBL3.Properties.Resources.icon_MT;
            this.pictureBox2.Location = new System.Drawing.Point(378, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(315, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "58 Nguyễn Lương Bằng-TP.Đà Nẵng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(367, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hotline: 19000019";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(323, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 52);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bill Of Sale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(14, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Time Check In:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(15, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Account:";
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(3, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(905, 253);
            this.dgvBill.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBill);
            this.panel1.Location = new System.Drawing.Point(2, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 259);
            this.panel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(36, 764);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Refunds";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(36, 726);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Customer Give";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Chocolate;
            this.label9.Location = new System.Drawing.Point(33, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(196, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 53);
            this.label1.TabIndex = 14;
            this.label1.Text = "TQH FOOD AND DRINK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Chocolate;
            this.label10.Location = new System.Drawing.Point(490, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Time Check Out:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Chocolate;
            this.label11.Location = new System.Drawing.Point(291, 854);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(379, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Cám Ơn Và Hẹn Gặp Lại Quý Khách!!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Chocolate;
            this.label12.Location = new System.Drawing.Point(33, 687);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Payment";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Chocolate;
            this.label13.Location = new System.Drawing.Point(33, 649);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "Discount";
            // 
            // lbTotalEnd
            // 
            this.lbTotalEnd.AutoSize = true;
            this.lbTotalEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalEnd.ForeColor = System.Drawing.Color.Chocolate;
            this.lbTotalEnd.Location = new System.Drawing.Point(624, 685);
            this.lbTotalEnd.Name = "lbTotalEnd";
            this.lbTotalEnd.Size = new System.Drawing.Size(0, 25);
            this.lbTotalEnd.TabIndex = 23;
            // 
            // lbDissCount
            // 
            this.lbDissCount.AutoSize = true;
            this.lbDissCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDissCount.ForeColor = System.Drawing.Color.Chocolate;
            this.lbDissCount.Location = new System.Drawing.Point(624, 647);
            this.lbDissCount.Name = "lbDissCount";
            this.lbDissCount.Size = new System.Drawing.Size(0, 25);
            this.lbDissCount.TabIndex = 22;
            // 
            // lbRefund
            // 
            this.lbRefund.AutoSize = true;
            this.lbRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRefund.ForeColor = System.Drawing.Color.Chocolate;
            this.lbRefund.Location = new System.Drawing.Point(623, 762);
            this.lbRefund.Name = "lbRefund";
            this.lbRefund.Size = new System.Drawing.Size(0, 25);
            this.lbRefund.TabIndex = 21;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Chocolate;
            this.lbTotalPrice.Location = new System.Drawing.Point(624, 606);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(0, 25);
            this.lbTotalPrice.TabIndex = 19;
            // 
            // lbDateCheckOut
            // 
            this.lbDateCheckOut.AutoSize = true;
            this.lbDateCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDateCheckOut.ForeColor = System.Drawing.Color.Chocolate;
            this.lbDateCheckOut.Location = new System.Drawing.Point(660, 278);
            this.lbDateCheckOut.Name = "lbDateCheckOut";
            this.lbDateCheckOut.Size = new System.Drawing.Size(0, 20);
            this.lbDateCheckOut.TabIndex = 26;
            // 
            // lbIDAcc
            // 
            this.lbIDAcc.AutoSize = true;
            this.lbIDAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIDAcc.ForeColor = System.Drawing.Color.Chocolate;
            this.lbIDAcc.Location = new System.Drawing.Point(149, 314);
            this.lbIDAcc.Name = "lbIDAcc";
            this.lbIDAcc.Size = new System.Drawing.Size(0, 20);
            this.lbIDAcc.TabIndex = 25;
            // 
            // lbDateCheckIn
            // 
            this.lbDateCheckIn.AutoSize = true;
            this.lbDateCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDateCheckIn.ForeColor = System.Drawing.Color.Chocolate;
            this.lbDateCheckIn.Location = new System.Drawing.Point(179, 278);
            this.lbDateCheckIn.Name = "lbDateCheckIn";
            this.lbDateCheckIn.Size = new System.Drawing.Size(0, 20);
            this.lbDateCheckIn.TabIndex = 24;
            // 
            // txbMoneyCus
            // 
            this.txbMoneyCus.BackColor = System.Drawing.Color.Bisque;
            this.txbMoneyCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbMoneyCus.ForeColor = System.Drawing.Color.Chocolate;
            this.txbMoneyCus.Location = new System.Drawing.Point(552, 721);
            this.txbMoneyCus.Name = "txbMoneyCus";
            this.txbMoneyCus.Size = new System.Drawing.Size(236, 30);
            this.txbMoneyCus.TabIndex = 27;
            this.txbMoneyCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbMoneyCus.TextChanged += new System.EventHandler(this.txbMoneyCus_TextChanged);
            // 
            // lbNameTable
            // 
            this.lbNameTable.AutoSize = true;
            this.lbNameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameTable.ForeColor = System.Drawing.Color.Chocolate;
            this.lbNameTable.Location = new System.Drawing.Point(654, 314);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(0, 20);
            this.lbNameTable.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Chocolate;
            this.label15.Location = new System.Drawing.Point(498, 314);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Name Table:";
            // 
            // fShowBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(916, 888);
            this.Controls.Add(this.lbNameTable);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txbMoneyCus);
            this.Controls.Add(this.lbDateCheckOut);
            this.Controls.Add(this.lbIDAcc);
            this.Controls.Add(this.lbDateCheckIn);
            this.Controls.Add(this.lbTotalEnd);
            this.Controls.Add(this.lbDissCount);
            this.Controls.Add(this.lbRefund);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "fShowBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowBill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fShowBill_FormClosing);
            this.Load += new System.EventHandler(this.fShowBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTotalEnd;
        private System.Windows.Forms.Label lbDissCount;
        private System.Windows.Forms.Label lbRefund;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbDateCheckOut;
        private System.Windows.Forms.Label lbIDAcc;
        private System.Windows.Forms.Label lbDateCheckIn;
        private System.Windows.Forms.TextBox txbMoneyCus;
        private System.Windows.Forms.Label lbNameTable;
        private System.Windows.Forms.Label label15;
    }
}