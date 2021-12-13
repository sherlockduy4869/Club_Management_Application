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
            this.label1 = new System.Windows.Forms.Label();
            this.pnForLeader = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtgvShowInfoMentor = new System.Windows.Forms.TabControl();
            this.tpMember = new System.Windows.Forms.TabPage();
            this.dtgvShowMember = new System.Windows.Forms.DataGridView();
            this.tpLeader = new System.Windows.Forms.TabPage();
            this.dtgvShowLeader = new System.Windows.Forms.DataGridView();
            this.tpMentor = new System.Windows.Forms.TabPage();
            this.dtgvShowMentor = new System.Windows.Forms.DataGridView();
            this.pnForLeader.SuspendLayout();
            this.dtgvShowInfoMentor.SuspendLayout();
            this.tpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowMember)).BeginInit();
            this.tpLeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowLeader)).BeginInit();
            this.tpMentor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowMentor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(547, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORMATION";
            // 
            // pnForLeader
            // 
            this.pnForLeader.Controls.Add(this.btnRemove);
            this.pnForLeader.Controls.Add(this.btnAddnew);
            this.pnForLeader.Location = new System.Drawing.Point(456, 672);
            this.pnForLeader.Name = "pnForLeader";
            this.pnForLeader.Size = new System.Drawing.Size(440, 109);
            this.pnForLeader.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(256, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 80);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(30, 12);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(150, 80);
            this.btnAddnew.TabIndex = 0;
            this.btnAddnew.Text = "Add new";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1127, 798);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtgvShowInfoMentor
            // 
            this.dtgvShowInfoMentor.Controls.Add(this.tpMember);
            this.dtgvShowInfoMentor.Controls.Add(this.tpLeader);
            this.dtgvShowInfoMentor.Controls.Add(this.tpMentor);
            this.dtgvShowInfoMentor.Location = new System.Drawing.Point(3, 131);
            this.dtgvShowInfoMentor.Name = "dtgvShowInfoMentor";
            this.dtgvShowInfoMentor.SelectedIndex = 0;
            this.dtgvShowInfoMentor.Size = new System.Drawing.Size(1330, 535);
            this.dtgvShowInfoMentor.TabIndex = 3;
            // 
            // tpMember
            // 
            this.tpMember.Controls.Add(this.dtgvShowMember);
            this.tpMember.Location = new System.Drawing.Point(8, 46);
            this.tpMember.Name = "tpMember";
            this.tpMember.Padding = new System.Windows.Forms.Padding(3);
            this.tpMember.Size = new System.Drawing.Size(1314, 481);
            this.tpMember.TabIndex = 0;
            this.tpMember.Text = "Member";
            this.tpMember.UseVisualStyleBackColor = true;
            // 
            // dtgvShowMember
            // 
            this.dtgvShowMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShowMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowMember.Location = new System.Drawing.Point(3, 0);
            this.dtgvShowMember.Name = "dtgvShowMember";
            this.dtgvShowMember.RowHeadersWidth = 82;
            this.dtgvShowMember.RowTemplate.Height = 41;
            this.dtgvShowMember.Size = new System.Drawing.Size(1308, 478);
            this.dtgvShowMember.TabIndex = 0;
            // 
            // tpLeader
            // 
            this.tpLeader.Controls.Add(this.dtgvShowLeader);
            this.tpLeader.Location = new System.Drawing.Point(8, 46);
            this.tpLeader.Name = "tpLeader";
            this.tpLeader.Padding = new System.Windows.Forms.Padding(3);
            this.tpLeader.Size = new System.Drawing.Size(1314, 481);
            this.tpLeader.TabIndex = 1;
            this.tpLeader.Text = "Leader";
            this.tpLeader.UseVisualStyleBackColor = true;
            // 
            // dtgvShowLeader
            // 
            this.dtgvShowLeader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShowLeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowLeader.Location = new System.Drawing.Point(3, 3);
            this.dtgvShowLeader.Name = "dtgvShowLeader";
            this.dtgvShowLeader.RowHeadersWidth = 82;
            this.dtgvShowLeader.RowTemplate.Height = 41;
            this.dtgvShowLeader.Size = new System.Drawing.Size(1311, 478);
            this.dtgvShowLeader.TabIndex = 0;
            // 
            // tpMentor
            // 
            this.tpMentor.Controls.Add(this.dtgvShowMentor);
            this.tpMentor.Location = new System.Drawing.Point(8, 46);
            this.tpMentor.Name = "tpMentor";
            this.tpMentor.Padding = new System.Windows.Forms.Padding(3);
            this.tpMentor.Size = new System.Drawing.Size(1314, 481);
            this.tpMentor.TabIndex = 2;
            this.tpMentor.Text = "Mentor";
            this.tpMentor.UseVisualStyleBackColor = true;
            // 
            // dtgvShowMentor
            // 
            this.dtgvShowMentor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShowMentor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowMentor.Location = new System.Drawing.Point(1, 3);
            this.dtgvShowMentor.Name = "dtgvShowMentor";
            this.dtgvShowMentor.RowHeadersWidth = 82;
            this.dtgvShowMentor.RowTemplate.Height = 41;
            this.dtgvShowMentor.Size = new System.Drawing.Size(1313, 475);
            this.dtgvShowMentor.TabIndex = 0;
            // 
            // ShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 869);
            this.Controls.Add(this.dtgvShowInfoMentor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnForLeader);
            this.Controls.Add(this.label1);
            this.Name = "ShowInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowInfo";
            this.Load += new System.EventHandler(this.ShowInfo_Load);
            this.pnForLeader.ResumeLayout(false);
            this.dtgvShowInfoMentor.ResumeLayout(false);
            this.tpMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowMember)).EndInit();
            this.tpLeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowLeader)).EndInit();
            this.tpMentor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowMentor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Panel pnForLeader;
        private Button btnRemove;
        private Button btnAddnew;
        private Button btnExit;
        private TabControl dtgvShowInfoMentor;
        private TabPage tpMember;
        private TabPage tpLeader;
        private TabPage tpMentor;
        private DataGridView dtgvShowMember;
        private DataGridView dtgvShowLeader;
        private DataGridView dtgvShowMentor;
    }
}