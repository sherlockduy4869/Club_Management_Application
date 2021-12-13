namespace Project_OOP_Final
{
    partial class ClubTask
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvClubTask = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRedo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClubTask)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1501, 736);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(765, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Club Task";
            // 
            // dtgvClubTask
            // 
            this.dtgvClubTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvClubTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClubTask.Location = new System.Drawing.Point(12, 112);
            this.dtgvClubTask.Name = "dtgvClubTask";
            this.dtgvClubTask.RowHeadersWidth = 82;
            this.dtgvClubTask.RowTemplate.Height = 41;
            this.dtgvClubTask.Size = new System.Drawing.Size(1640, 480);
            this.dtgvClubTask.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 46);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(208, 16);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 46);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Task";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRedo);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Location = new System.Drawing.Point(587, 598);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 78);
            this.panel1.TabIndex = 11;
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(397, 16);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(150, 46);
            this.btnRedo.TabIndex = 10;
            this.btnRedo.Text = "Re-Do";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // ClubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 794);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvClubTask);
            this.Name = "ClubTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubTask";
            this.Load += new System.EventHandler(this.ClubTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClubTask)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private Label label1;
        private DataGridView dtgvClubTask;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnAdjust;
        private Panel panel1;
        private Button btnRedo;
    }
}