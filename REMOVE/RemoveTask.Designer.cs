namespace Project_OOP_Final.REMOVE
{
    partial class RemoveTask
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTaskId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTaskId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(24, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 83);
            this.panel2.TabIndex = 3;
            // 
            // txbTaskId
            // 
            this.txbTaskId.Location = new System.Drawing.Point(227, 28);
            this.txbTaskId.Name = "txbTaskId";
            this.txbTaskId.Size = new System.Drawing.Size(571, 39);
            this.txbTaskId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Task Id";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Location = new System.Drawing.Point(503, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 86);
            this.panel3.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(25, 21);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 46);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RemoveTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 299);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "RemoveTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Task";
            this.Load += new System.EventHandler(this.RemoveTask_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private TextBox txbTaskId;
        private Label label2;
        private Panel panel3;
        private Button btnRemove;
        private Button btnExit;
    }
}