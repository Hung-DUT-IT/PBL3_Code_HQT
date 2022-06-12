namespace Code_PBL3.View
{
    partial class fDetachedBill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOriginTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbBillOrigin = new System.Windows.Forms.TextBox();
            this.txbAreaOrigin = new System.Windows.Forms.TextBox();
            this.txbTableOrigin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetached = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbBillDetached = new System.Windows.Forms.TextBox();
            this.txbAreaDetached = new System.Windows.Forms.TextBox();
            this.txbTableDetached = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DetachedTo = new System.Windows.Forms.Button();
            this.DetachedBack = new System.Windows.Forms.Button();
            this.DetachedBackAll = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nmCounts = new System.Windows.Forms.NumericUpDown();
            this.btOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOriginTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetached)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCounts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOriginTable);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(57, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 805);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bàn gốc";
            // 
            // dgvOriginTable
            // 
            this.dgvOriginTable.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvOriginTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOriginTable.Location = new System.Drawing.Point(6, 213);
            this.dgvOriginTable.Name = "dgvOriginTable";
            this.dgvOriginTable.RowHeadersWidth = 51;
            this.dgvOriginTable.RowTemplate.Height = 24;
            this.dgvOriginTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOriginTable.Size = new System.Drawing.Size(727, 586);
            this.dgvOriginTable.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbBillOrigin);
            this.panel1.Controls.Add(this.txbAreaOrigin);
            this.panel1.Controls.Add(this.txbTableOrigin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 174);
            this.panel1.TabIndex = 0;
            // 
            // txbBillOrigin
            // 
            this.txbBillOrigin.Location = new System.Drawing.Point(157, 130);
            this.txbBillOrigin.Name = "txbBillOrigin";
            this.txbBillOrigin.Size = new System.Drawing.Size(202, 22);
            this.txbBillOrigin.TabIndex = 7;
            // 
            // txbAreaOrigin
            // 
            this.txbAreaOrigin.Location = new System.Drawing.Point(157, 75);
            this.txbAreaOrigin.Name = "txbAreaOrigin";
            this.txbAreaOrigin.Size = new System.Drawing.Size(202, 22);
            this.txbAreaOrigin.TabIndex = 6;
            // 
            // txbTableOrigin
            // 
            this.txbTableOrigin.Location = new System.Drawing.Point(157, 18);
            this.txbTableOrigin.Name = "txbTableOrigin";
            this.txbTableOrigin.Size = new System.Drawing.Size(202, 22);
            this.txbTableOrigin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khu ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bàn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetached);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(1097, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 799);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bàn tách";
            // 
            // dgvDetached
            // 
            this.dgvDetached.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvDetached.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetached.Location = new System.Drawing.Point(6, 213);
            this.dgvDetached.Name = "dgvDetached";
            this.dgvDetached.RowHeadersWidth = 51;
            this.dgvDetached.RowTemplate.Height = 24;
            this.dgvDetached.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetached.Size = new System.Drawing.Size(727, 580);
            this.dgvDetached.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbBillDetached);
            this.panel2.Controls.Add(this.txbAreaDetached);
            this.panel2.Controls.Add(this.txbTableDetached);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(29, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 174);
            this.panel2.TabIndex = 0;
            // 
            // txbBillDetached
            // 
            this.txbBillDetached.Location = new System.Drawing.Point(157, 130);
            this.txbBillDetached.Name = "txbBillDetached";
            this.txbBillDetached.Size = new System.Drawing.Size(202, 22);
            this.txbBillDetached.TabIndex = 7;
            // 
            // txbAreaDetached
            // 
            this.txbAreaDetached.Location = new System.Drawing.Point(157, 75);
            this.txbAreaDetached.Name = "txbAreaDetached";
            this.txbAreaDetached.Size = new System.Drawing.Size(202, 22);
            this.txbAreaDetached.TabIndex = 6;
            // 
            // txbTableDetached
            // 
            this.txbTableDetached.Location = new System.Drawing.Point(157, 18);
            this.txbTableDetached.Name = "txbTableDetached";
            this.txbTableDetached.Size = new System.Drawing.Size(202, 22);
            this.txbTableDetached.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(20, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(20, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên khu ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(20, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên bàn";
            // 
            // DetachedTo
            // 
            this.DetachedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DetachedTo.Location = new System.Drawing.Point(887, 389);
            this.DetachedTo.Name = "DetachedTo";
            this.DetachedTo.Size = new System.Drawing.Size(135, 69);
            this.DetachedTo.TabIndex = 3;
            this.DetachedTo.Text = ">";
            this.DetachedTo.UseVisualStyleBackColor = true;
            this.DetachedTo.Click += new System.EventHandler(this.DetachedTo_Click);
            // 
            // DetachedBack
            // 
            this.DetachedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DetachedBack.Location = new System.Drawing.Point(887, 503);
            this.DetachedBack.Name = "DetachedBack";
            this.DetachedBack.Size = new System.Drawing.Size(135, 69);
            this.DetachedBack.TabIndex = 4;
            this.DetachedBack.Text = "<";
            this.DetachedBack.UseVisualStyleBackColor = true;
            this.DetachedBack.Click += new System.EventHandler(this.DetachedBack_Click);
            // 
            // DetachedBackAll
            // 
            this.DetachedBackAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DetachedBackAll.Location = new System.Drawing.Point(887, 623);
            this.DetachedBackAll.Name = "DetachedBackAll";
            this.DetachedBackAll.Size = new System.Drawing.Size(135, 69);
            this.DetachedBackAll.TabIndex = 5;
            this.DetachedBackAll.Text = "<<";
            this.DetachedBackAll.UseVisualStyleBackColor = true;
            this.DetachedBackAll.Click += new System.EventHandler(this.DetachedBackAll_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(802, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số lượng";
            // 
            // nmCounts
            // 
            this.nmCounts.Location = new System.Drawing.Point(930, 295);
            this.nmCounts.Name = "nmCounts";
            this.nmCounts.Size = new System.Drawing.Size(136, 22);
            this.nmCounts.TabIndex = 9;
            this.nmCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmCounts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(871, 835);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(183, 44);
            this.btOK.TabIndex = 10;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // fDetachedBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1896, 906);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.nmCounts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DetachedBackAll);
            this.Controls.Add(this.DetachedBack);
            this.Controls.Add(this.DetachedTo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDetachedBill";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detached Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fDetachedBill_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOriginTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetached)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOriginTable;
        private System.Windows.Forms.TextBox txbBillOrigin;
        private System.Windows.Forms.TextBox txbAreaOrigin;
        private System.Windows.Forms.TextBox txbTableOrigin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetached;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbBillDetached;
        private System.Windows.Forms.TextBox txbAreaDetached;
        private System.Windows.Forms.TextBox txbTableDetached;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DetachedTo;
        private System.Windows.Forms.Button DetachedBack;
        private System.Windows.Forms.Button DetachedBackAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmCounts;
        private System.Windows.Forms.Button btOK;
    }
}