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
            this.dtgvMemberTask.Location = new System.Drawing.Point(12, 204);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(523, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member Task";
            // 
            // btnSubmitTask
            // 
            this.btnSubmitTask.Location = new System.Drawing.Point(437, 726);
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.Size = new System.Drawing.Size(150, 59);
            this.btnSubmitTask.TabIndex = 2;
            this.btnSubmitTask.Text = "Submit Task";
            this.btnSubmitTask.UseVisualStyleBackColor = true;
            this.btnSubmitTask.Click += new System.EventHandler(this.btnSubmitTask_Click);
            // 
            // btnHistoryTask
            // 
            this.btnHistoryTask.Location = new System.Drawing.Point(734, 726);
            this.btnHistoryTask.Name = "btnHistoryTask";
            this.btnHistoryTask.Size = new System.Drawing.Size(150, 59);
            this.btnHistoryTask.TabIndex = 4;
            this.btnHistoryTask.Text = "History Task";
            this.btnHistoryTask.UseVisualStyleBackColor = true;
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