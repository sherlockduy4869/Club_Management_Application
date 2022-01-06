namespace Project_OOP_Final
{
    partial class MemberClubTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberClubTask));
            this.dtgvMemberTask = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitTask = new System.Windows.Forms.Button();
            this.btnHistoryTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMemberTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMemberTask
            // 
            this.dtgvMemberTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMemberTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMemberTask.Location = new System.Drawing.Point(12, 220);
            this.dtgvMemberTask.Name = "dtgvMemberTask";
            this.dtgvMemberTask.RowHeadersWidth = 82;
            this.dtgvMemberTask.RowTemplate.Height = 41;
            this.dtgvMemberTask.Size = new System.Drawing.Size(1426, 480);
            this.dtgvMemberTask.TabIndex = 0;
            this.dtgvMemberTask.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvMemberTask_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(573, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member Task";
            // 
            // btnSubmitTask
            // 
            this.btnSubmitTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSubmitTask.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitTask.ForeColor = System.Drawing.Color.White;
            this.btnSubmitTask.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmitTask.Image")));
            this.btnSubmitTask.Location = new System.Drawing.Point(434, 840);
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnSubmitTask.Size = new System.Drawing.Size(231, 191);
            this.btnSubmitTask.TabIndex = 2;
            this.btnSubmitTask.Text = "Submit Task";
            this.btnSubmitTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubmitTask.UseVisualStyleBackColor = false;
            this.btnSubmitTask.Click += new System.EventHandler(this.btnSubmitTask_Click);
            // 
            // btnHistoryTask
            // 
            this.btnHistoryTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHistoryTask.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistoryTask.ForeColor = System.Drawing.Color.White;
            this.btnHistoryTask.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoryTask.Image")));
            this.btnHistoryTask.Location = new System.Drawing.Point(764, 840);
            this.btnHistoryTask.Name = "btnHistoryTask";
            this.btnHistoryTask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnHistoryTask.Size = new System.Drawing.Size(231, 191);
            this.btnHistoryTask.TabIndex = 4;
            this.btnHistoryTask.Text = "History Task";
            this.btnHistoryTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistoryTask.UseVisualStyleBackColor = false;
            this.btnHistoryTask.Click += new System.EventHandler(this.btnHistoryTask_Click);
            // 
            // MemberClubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 1029);
            this.Controls.Add(this.btnHistoryTask);
            this.Controls.Add(this.btnSubmitTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvMemberTask);
            this.Name = "MemberClubTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberTask";
            this.Load += new System.EventHandler(this.MemberTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMemberTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvMemberTask;
        private Label label1;
        private Button btnSubmitTask;
        private Button btnHistoryTask;
    }
}