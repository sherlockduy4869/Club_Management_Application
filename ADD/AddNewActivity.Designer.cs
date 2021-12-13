namespace Project_OOP_Final
{
    partial class AddNewActivity
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
            this.txbId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Name = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDateStart = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDateEnd = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(190, 23);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(499, 39);
            this.txbId.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 90);
            this.panel1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name.Location = new System.Drawing.Point(27, 23);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(105, 45);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(190, 29);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(499, 39);
            this.txbName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Controls.Add(this.Name);
            this.panel2.Location = new System.Drawing.Point(36, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 90);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Start";
            // 
            // txbDateStart
            // 
            this.txbDateStart.Location = new System.Drawing.Point(190, 30);
            this.txbDateStart.Name = "txbDateStart";
            this.txbDateStart.Size = new System.Drawing.Size(499, 39);
            this.txbDateStart.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbDateStart);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(36, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 90);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date End";
            // 
            // txbDateEnd
            // 
            this.txbDateEnd.Location = new System.Drawing.Point(190, 29);
            this.txbDateEnd.Name = "txbDateEnd";
            this.txbDateEnd.Size = new System.Drawing.Size(499, 39);
            this.txbDateEnd.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbDateEnd);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(36, 348);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 90);
            this.panel4.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(191, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Location = new System.Drawing.Point(445, 454);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 91);
            this.panel5.TabIndex = 4;
            // 
            // AddNewActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 560);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Activity";
            this.Load += new System.EventHandler(this.AddNewActivity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txbId;
        private Panel panel1;
        private Label Name;
        private TextBox txbName;
        private Panel panel2;
        private Label label3;
        private TextBox txbDateStart;
        private Panel panel3;
        private Label label4;
        private TextBox txbDateEnd;
        private Panel panel4;
        private Button btnAdd;
        private Button btnExit;
        private Panel panel5;
    }
}