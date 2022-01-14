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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClubInfo));
            this.tcClubInfo = new System.Windows.Forms.TabControl();
            this.tpActivity = new System.Windows.Forms.TabPage();
            this.btnAdjust = new Project_OOP_Final.Button_Designø.RJButton();
            this.btnAdd = new Project_OOP_Final.Button_Designø.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.dtgvActivity = new System.Windows.Forms.DataGridView();
            this.tpFinance = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddIteam = new Project_OOP_Final.Button_Designø.RJButton();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.txbItemName = new System.Windows.Forms.TextBox();
            this.flpActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvDetailFinance = new System.Windows.Forms.ListView();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.TotalPrice = new System.Windows.Forms.ColumnHeader();
            this.btnExit = new System.Windows.Forms.Button();
            this.tcClubInfo.SuspendLayout();
            this.tpActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvActivity)).BeginInit();
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
            this.tcClubInfo.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tcClubInfo.Location = new System.Drawing.Point(22, 99);
            this.tcClubInfo.Name = "tcClubInfo";
            this.tcClubInfo.SelectedIndex = 0;
            this.tcClubInfo.Size = new System.Drawing.Size(1421, 931);
            this.tcClubInfo.TabIndex = 0;
            // 
            // tpActivity
            // 
            this.tpActivity.Controls.Add(this.btnAdjust);
            this.tpActivity.Controls.Add(this.btnAdd);
            this.tpActivity.Controls.Add(this.pictureBox1);
            this.tpActivity.Controls.Add(this.txbSearch);
            this.tpActivity.Controls.Add(this.dtgvActivity);
            this.tpActivity.Location = new System.Drawing.Point(8, 45);
            this.tpActivity.Name = "tpActivity";
            this.tpActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tpActivity.Size = new System.Drawing.Size(1405, 878);
            this.tpActivity.TabIndex = 0;
            this.tpActivity.Text = "Activity";
            this.tpActivity.UseVisualStyleBackColor = true;
            // 
            // btnAdjust
            // 
            this.btnAdjust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAdjust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAdjust.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdjust.BorderRadius = 40;
            this.btnAdjust.BorderSize = 0;
            this.btnAdjust.FlatAppearance.BorderSize = 0;
            this.btnAdjust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjust.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdjust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAdjust.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjust.Image")));
            this.btnAdjust.Location = new System.Drawing.Point(767, 680);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnAdjust.Size = new System.Drawing.Size(231, 191);
            this.btnAdjust.TabIndex = 53;
            this.btnAdjust.Text = "Adjust";
            this.btnAdjust.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdjust.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAdjust.UseVisualStyleBackColor = false;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 40;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(432, 680);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnAdd.Size = new System.Drawing.Size(231, 191);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(961, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSearch.Location = new System.Drawing.Point(412, 17);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(543, 44);
            this.txbSearch.TabIndex = 5;
            this.txbSearch.Text = "Search...";
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
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
            this.dtgvActivity.Size = new System.Drawing.Size(1396, 590);
            this.dtgvActivity.TabIndex = 1;
            // 
            // tpFinance
            // 
            this.tpFinance.Controls.Add(this.panel1);
            this.tpFinance.Location = new System.Drawing.Point(8, 45);
            this.tpFinance.Name = "tpFinance";
            this.tpFinance.Padding = new System.Windows.Forms.Padding(3);
            this.tpFinance.Size = new System.Drawing.Size(1405, 878);
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
            this.panel1.Size = new System.Drawing.Size(1402, 872);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txbTotalPrice);
            this.panel4.Location = new System.Drawing.Point(1000, 761);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 65);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Price";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTotalPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txbTotalPrice.Location = new System.Drawing.Point(198, 15);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(188, 37);
            this.txbTotalPrice.TabIndex = 0;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddIteam);
            this.panel2.Controls.Add(this.txbPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nmCount);
            this.panel2.Controls.Add(this.txbItemName);
            this.panel2.Location = new System.Drawing.Point(391, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 96);
            this.panel2.TabIndex = 1;
            // 
            // btnAddIteam
            // 
            this.btnAddIteam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAddIteam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAddIteam.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddIteam.BorderRadius = 40;
            this.btnAddIteam.BorderSize = 0;
            this.btnAddIteam.FlatAppearance.BorderSize = 0;
            this.btnAddIteam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIteam.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddIteam.ForeColor = System.Drawing.Color.White;
            this.btnAddIteam.Location = new System.Drawing.Point(703, 5);
            this.btnAddIteam.Name = "btnAddIteam";
            this.btnAddIteam.Size = new System.Drawing.Size(177, 84);
            this.btnAddIteam.TabIndex = 53;
            this.btnAddIteam.Text = "ADD";
            this.btnAddIteam.TextColor = System.Drawing.Color.White;
            this.btnAddIteam.UseVisualStyleBackColor = false;
            this.btnAddIteam.Click += new System.EventHandler(this.btnAddIteam_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPrice.Location = new System.Drawing.Point(186, 51);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(502, 38);
            this.txbPrice.TabIndex = 2;
            this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(23, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Name";
            // 
            // nmCount
            // 
            this.nmCount.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.nmCount.Location = new System.Drawing.Point(894, 30);
            this.nmCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(80, 41);
            this.nmCount.TabIndex = 3;
            // 
            // txbItemName
            // 
            this.txbItemName.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbItemName.Location = new System.Drawing.Point(186, 6);
            this.txbItemName.Name = "txbItemName";
            this.txbItemName.Size = new System.Drawing.Size(502, 38);
            this.txbItemName.TabIndex = 1;
            // 
            // flpActivity
            // 
            this.flpActivity.AutoScroll = true;
            this.flpActivity.Location = new System.Drawing.Point(6, 3);
            this.flpActivity.Name = "flpActivity";
            this.flpActivity.Size = new System.Drawing.Size(382, 823);
            this.flpActivity.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvDetailFinance);
            this.panel3.Location = new System.Drawing.Point(391, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 653);
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
            this.lsvDetailFinance.Location = new System.Drawing.Point(0, 3);
            this.lsvDetailFinance.Name = "lsvDetailFinance";
            this.lsvDetailFinance.Size = new System.Drawing.Size(1008, 647);
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
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1353, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 84);
            this.btnExit.TabIndex = 52;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ClubInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1445, 1029);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tcClubInfo);
            this.Name = "ClubInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Info";
            this.Load += new System.EventHandler(this.ClubInfo_Load);
            this.tcClubInfo.ResumeLayout(false);
            this.tpActivity.ResumeLayout(false);
            this.tpActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvActivity)).EndInit();
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
        private TextBox txbItemName;
        private Panel panel4;
        private Label label1;
        private TextBox txbTotalPrice;
        private FlowLayoutPanel flpActivity;
        private Label label3;
        private Label label2;
        private TextBox txbPrice;
        private TextBox txbSearch;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button_Designø.RJButton btnAdjust;
        private Button_Designø.RJButton btnAdd;
        private Button_Designø.RJButton btnAddIteam;
    }
}