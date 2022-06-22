namespace Code_PBL3
{
    partial class fStatic
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotalSales = new System.Windows.Forms.TextBox();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPageNumber = new System.Windows.Forms.TextBox();
            this.btnEndPage = new System.Windows.Forms.Button();
            this.btnPrePage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTotalSales);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Controls.Add(this.DateTo);
            this.panel1.Controls.Add(this.DateFrom);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 836);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBill);
            this.panel2.Location = new System.Drawing.Point(3, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1918, 637);
            this.panel2.TabIndex = 1;
            // 
            // dgvBill
            // 
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(0, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(1915, 634);
            this.dgvBill.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1180, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Sales";
            // 
            // txbTotalSales
            // 
            this.txbTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTotalSales.Location = new System.Drawing.Point(1332, 68);
            this.txbTotalSales.Name = "txbTotalSales";
            this.txbTotalSales.ReadOnly = true;
            this.txbTotalSales.Size = new System.Drawing.Size(270, 30);
            this.txbTotalSales.TabIndex = 8;
            this.txbTotalSales.Text = "1";
            this.txbTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.LightSalmon;
            this.btnStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatistic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatistic.Location = new System.Drawing.Point(845, 20);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(260, 74);
            this.btnStatistic.TabIndex = 2;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // DateTo
            // 
            this.DateTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DateTo.Location = new System.Drawing.Point(421, 34);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(314, 22);
            this.DateTo.TabIndex = 1;
            // 
            // DateFrom
            // 
            this.DateFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DateFrom.Location = new System.Drawing.Point(21, 34);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(314, 22);
            this.DateFrom.TabIndex = 0;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFirstPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFirstPage.Location = new System.Drawing.Point(152, 5);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(221, 75);
            this.btnFirstPage.TabIndex = 3;
            this.btnFirstPage.Text = "First Page";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txbPageNumber);
            this.panel3.Controls.Add(this.btnFirstPage);
            this.panel3.Controls.Add(this.btnEndPage);
            this.panel3.Controls.Add(this.btnPrePage);
            this.panel3.Controls.Add(this.btnNextPage);
            this.panel3.Location = new System.Drawing.Point(3, 744);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1918, 89);
            this.panel3.TabIndex = 2;
            // 
            // txbPageNumber
            // 
            this.txbPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPageNumber.Location = new System.Drawing.Point(795, 26);
            this.txbPageNumber.Name = "txbPageNumber";
            this.txbPageNumber.ReadOnly = true;
            this.txbPageNumber.Size = new System.Drawing.Size(270, 30);
            this.txbPageNumber.TabIndex = 7;
            this.txbPageNumber.Text = "1";
            this.txbPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEndPage
            // 
            this.btnEndPage.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEndPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEndPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEndPage.Location = new System.Drawing.Point(1489, 5);
            this.btnEndPage.Name = "btnEndPage";
            this.btnEndPage.Size = new System.Drawing.Size(221, 75);
            this.btnEndPage.TabIndex = 6;
            this.btnEndPage.Text = "Last Page";
            this.btnEndPage.UseVisualStyleBackColor = false;
            this.btnEndPage.Click += new System.EventHandler(this.btnEndPage_Click);
            // 
            // btnPrePage
            // 
            this.btnPrePage.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPrePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrePage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrePage.Location = new System.Drawing.Point(489, 5);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(221, 75);
            this.btnPrePage.TabIndex = 5;
            this.btnPrePage.Text = "Previous Page";
            this.btnPrePage.UseVisualStyleBackColor = false;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNextPage.Location = new System.Drawing.Point(1158, 5);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(221, 75);
            this.btnNextPage.TabIndex = 4;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(1682, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 74);
            this.button2.TabIndex = 11;
            this.button2.Text = "Chart";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearch.Location = new System.Drawing.Point(1332, 20);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.ReadOnly = true;
            this.txbSearch.Size = new System.Drawing.Size(270, 30);
            this.txbSearch.TabIndex = 12;
            this.txbSearch.Text = "1";
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1180, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search";
            // 
            // fStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1924, 836);
            this.Controls.Add(this.panel1);
            this.Name = "fStatic";
            this.Text = "fStatic";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.TextBox txbPageNumber;
        private System.Windows.Forms.Button btnEndPage;
        private System.Windows.Forms.Button btnPrePage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotalSales;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}