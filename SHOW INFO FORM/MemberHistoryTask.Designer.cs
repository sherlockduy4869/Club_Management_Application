namespace Project_OOP_Final.SHOW_INFO_FORM
{
    partial class MemberHistoryTask
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
            this.dtgvDoneTask = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoneTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDoneTask
            // 
            this.dtgvDoneTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDoneTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoneTask.Location = new System.Drawing.Point(12, 145);
            this.dtgvDoneTask.Name = "dtgvDoneTask";
            this.dtgvDoneTask.RowHeadersWidth = 82;
            this.dtgvDoneTask.RowTemplate.Height = 41;
            this.dtgvDoneTask.Size = new System.Drawing.Size(1231, 525);
            this.dtgvDoneTask.TabIndex = 0;
            this.dtgvDoneTask.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvDoneTask_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(530, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "History Task";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1093, 732);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MemberHistoryTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 802);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDoneTask);
            this.Name = "MemberHistoryTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member History Task";
            this.Load += new System.EventHandler(this.MemberHistoryTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoneTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvDoneTask;
        private Label label1;
        private Button btnExit;
    }
}