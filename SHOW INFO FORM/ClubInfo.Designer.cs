namespace Project_OOP_Final
{
    partial class ClubInfo
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
            this.tcClubInfo = new System.Windows.Forms.TabControl();
            this.tpActivity = new System.Windows.Forms.TabPage();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.dtgvActivity = new System.Windows.Forms.DataGridView();
            this.pnLeader = new System.Windows.Forms.Panel();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tpFinance = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txbItemName = new System.Windows.Forms.TextBox();
            this.flpActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvDetailFinance = new System.Windows.Forms.ListView();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.TotalPrice = new System.Windows.Forms.ColumnHeader();
            this.tcClubInfo.SuspendLayout();
            this.tpActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvActivity)).BeginInit();
            this.pnLeader.SuspendLayout();
            this.tpFinance.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcClubInfo
            // 
            this.tcClubInfo.Controls.Add(this.tpActivity);
            this.tcClubInfo.Controls.Add(this.tpFinance);
            this.tcClubInfo.Location = new System.Drawing.Point(22, 134);
            this.tcClubInfo.Name = "tcClubInfo";
            this.tcClubInfo.SelectedIndex = 0;
            this.tcClubInfo.Size = new System.Drawing.Size(1421, 769);
            this.tcClubInfo.TabIndex = 0;
            // 
            // tpActivity
            // 
            this.tpActivity.Controls.Add(this.txbSearch);
            this.tpActivity.Controls.Add(this.dtgvActivity);
            this.tpActivity.Controls.Add(this.pnLeader);
            this.tpActivity.Location = new System.Drawing.Point(8, 46);
            this.tpActivity.Name = "tpActivity";
            this.tpActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tpActivity.Size = new System.Drawing.Size(1405, 715);
            this.tpActivity.TabIndex = 0;
            this.tpActivity.Text = "Activity";
            this.tpActivity.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(384, 22);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(669, 39);
            this.txbSearch.TabIndex = 5;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // dtgvActivity
            // 
            this.dtgvActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvActivity.Location = new System.Drawing.Point(3, 67);
            this.dtgvActivity.Name = "dtgvActivity";
            this.dtgvActivity.RowHeadersWidth = 82;
            this.dtgvActivity.RowTemplate.Height = 41;
            this.dtgvActivity.Size = new System.Drawing.Size(1396, 532);
            this.dtgvActivity.TabIndex = 1;
            // 
            // pnLeader
            // 
            this.pnLeader.Controls.Add(this.btnAdjust);
            this.pnLeader.Controls.Add(this.btnAdd);
            this.pnLeader.Location = new System.Drawing.Point(536, 618);
            this.pnLeader.Name = "pnLeader";
            this.pnLeader.Size = new System.Drawing.Size(404, 80);
            this.pnLeader.TabIndex = 1;
            // 
            // btnAdjust
            // 
            this.btnAdjust.Location = new System.Drawing.Point(224, 16);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(150, 46);
            this.btnAdjust.TabIndex = 2;
            this.btnAdjust.Text = "Adjust";
            this.btnAdjust.UseVisualStyleBackColor = true;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tpFinance
            // 
            this.tpFinance.Controls.Add(this.panel1);
            this.tpFinance.Location = new System.Drawing.Point(8, 46);
            this.tpFinance.Name = "tpFinance";
            this.tpFinance.Padding = new System.Windows.Forms.Padding(3);
            this.tpFinance.Size = new System.Drawing.Size(1405, 715);
            this.tpFinance.TabIndex = 1;
            this.tpFinance.Text = "Finance";
            this.tpFinance.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flpActivity);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 621);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txbTotalPrice);
            this.panel4.Location = new System.Drawing.Point(394, 556);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1002, 65);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(599, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Price";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txbTotalPrice.Location = new System.Drawing.Point(794, 11);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(188, 43);
            this.txbTotalPrice.TabIndex = 0;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nmCount);
            this.panel2.Controls.Add(this.btnAddItem);
            this.panel2.Controls.Add(this.txbItemName);
            this.panel2.Location = new System.Drawing.Point(391, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 96);
            this.panel2.TabIndex = 1;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(186, 51);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(502, 39);
            this.txbPrice.TabIndex = 2;
            this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Name";
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(894, 30);
            this.nmCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(80, 39);
            this.nmCount.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(699, 6);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(177, 84);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txbItemName
            // 
            this.txbItemName.Location = new System.Drawing.Point(186, 6);
            this.txbItemName.Name = "txbItemName";
            this.txbItemName.Size = new System.Drawing.Size(502, 39);
            this.txbItemName.TabIndex = 1;
            // 
            // flpActivity
            // 
            this.flpActivity.AutoScroll = true;
            this.flpActivity.Location = new System.Drawing.Point(3, 3);
            this.flpActivity.Name = "flpActivity";
            this.flpActivity.Size = new System.Drawing.Size(382, 618);
            this.flpActivity.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvDetailFinance);
            this.panel3.Location = new System.Drawing.Point(391, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 448);
            this.panel3.TabIndex = 2;
            // 
            // lsvDetailFinance
            // 
            this.lsvDetailFinance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Price,
            this.Quantity,
            this.TotalPrice});
            this.lsvDetailFinance.GridLines = true;
            this.lsvDetailFinance.Location = new System.Drawing.Point(3, 3);
            this.lsvDetailFinance.Name = "lsvDetailFinance";
            this.lsvDetailFinance.Size = new System.Drawing.Size(1002, 442);
            this.lsvDetailFinance.TabIndex = 0;
            this.lsvDetailFinance.UseCompatibleStateImageBehavior = false;
            this.lsvDetailFinance.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 230;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 230;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 230;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Total Price";
            this.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalPrice.Width = 230;
            // 
            // ClubInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 1029);
            this.Controls.Add(this.tcClubInfo);
            this.Name = "ClubInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Info";
            this.Load += new System.EventHandler(this.ClubInfo_Load);
            this.tcClubInfo.ResumeLayout(false);
            this.tpActivity.ResumeLayout(false);
            this.tpActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvActivity)).EndInit();
            this.pnLeader.ResumeLayout(false);
            this.tpFinance.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcClubInfo;
        private TabPage tpActivity;
        private Panel pnLeader;
        private Button btnAdjust;
        private Button btnAdd;
        private DataGridView dtgvActivity;
        private TabPage tpFinance;
        private Panel panel1;
        private Panel panel3;
        private ListView lsvDetailFinance;
        private ColumnHeader ItemName;
        private ColumnHeader Price;
        private ColumnHeader Quantity;
        private ColumnHeader TotalPrice;
        private Panel panel2;
        private NumericUpDown nmCount;
        private Button btnAddItem;
        private TextBox txbItemName;
        private Panel panel4;
        private Label label1;
        private TextBox txbTotalPrice;
        private FlowLayoutPanel flpActivity;
        private Label label3;
        private Label label2;
        private TextBox txbPrice;
        private TextBox txbSearch;
    }
}