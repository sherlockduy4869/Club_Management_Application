namespace Project_OOP_Final
{
    partial class ShowInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowInfo));
            this.dtgvShowMember = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRole = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLeader = new System.Windows.Forms.Button();
            this.btnMentor = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowMember)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvShowMember
            // 
            this.dtgvShowMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShowMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvShowMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowMember.Location = new System.Drawing.Point(11, 292);
            this.dtgvShowMember.Name = "dtgvShowMember";
            this.dtgvShowMember.RowHeadersWidth = 82;
            this.dtgvShowMember.RowTemplate.Height = 41;
            this.dtgvShowMember.Size = new System.Drawing.Size(1414, 518);
            this.dtgvShowMember.TabIndex = 14;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnRemove.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(781, 838);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.btnRemove.Size = new System.Drawing.Size(232, 191);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAddnew.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddnew.ForeColor = System.Drawing.Color.White;
            this.btnAddnew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddnew.Image")));
            this.btnAddnew.Location = new System.Drawing.Point(417, 838);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.btnAddnew.Size = new System.Drawing.Size(231, 191);
            this.btnAddnew.TabIndex = 15;
            this.btnAddnew.Text = "Add new";
            this.btnAddnew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbRole);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLeader);
            this.panel1.Controls.Add(this.btnMentor);
            this.panel1.Controls.Add(this.btnMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 286);
            this.panel1.TabIndex = 24;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.lbRole.Location = new System.Drawing.Point(433, 60);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(568, 58);
            this.lbRole.TabIndex = 29;
            this.lbRole.Text = "MEMBER INFORMATION";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1338, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 84);
            this.btnExit.TabIndex = 52;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSearch.Location = new System.Drawing.Point(934, 239);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(443, 44);
            this.txbSearch.TabIndex = 28;
            this.txbSearch.Text = "Search...";
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1373, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnLeader
            // 
            this.btnLeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnLeader.FlatAppearance.BorderSize = 0;
            this.btnLeader.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnLeader.Location = new System.Drawing.Point(173, 208);
            this.btnLeader.Name = "btnLeader";
            this.btnLeader.Size = new System.Drawing.Size(173, 75);
            this.btnLeader.TabIndex = 26;
            this.btnLeader.Text = "Leader";
            this.btnLeader.UseVisualStyleBackColor = false;
            this.btnLeader.Click += new System.EventHandler(this.btnLeader_Click);
            // 
            // btnMentor
            // 
            this.btnMentor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnMentor.FlatAppearance.BorderSize = 0;
            this.btnMentor.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMentor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnMentor.Location = new System.Drawing.Point(343, 208);
            this.btnMentor.Name = "btnMentor";
            this.btnMentor.Size = new System.Drawing.Size(173, 75);
            this.btnMentor.TabIndex = 27;
            this.btnMentor.Text = "Mentor";
            this.btnMentor.UseVisualStyleBackColor = false;
            this.btnMentor.Click += new System.EventHandler(this.btnMentor_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnMember.Location = new System.Drawing.Point(5, 208);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(173, 75);
            this.btnMember.TabIndex = 25;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // ShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 1029);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvShowMember);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddnew);
            this.Name = "ShowInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Information of Member";
            this.Load += new System.EventHandler(this.ShowInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private DataGridView dtgvShowMember;
        private Button btnRemove;
        private Button btnAddnew;
        private Panel panel1;
        private TextBox txbSearch;
        private PictureBox pictureBox1;
        private Button btnLeader;
        private Button btnMentor;
        private Button btnMember;
        private Label lbRole;
        private Button btnExit;
    }
}