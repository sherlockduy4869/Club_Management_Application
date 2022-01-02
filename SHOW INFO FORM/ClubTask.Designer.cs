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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvClubTask = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRedo = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClubTask)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(691, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Club Task";
            // 
            // dtgvClubTask
            // 
            this.dtgvClubTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvClubTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvClubTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClubTask.Location = new System.Drawing.Point(12, 244);
            this.dtgvClubTask.Name = "dtgvClubTask";
            this.dtgvClubTask.RowHeadersWidth = 82;
            this.dtgvClubTask.RowTemplate.Height = 41;
            this.dtgvClubTask.Size = new System.Drawing.Size(1421, 480);
            this.dtgvClubTask.TabIndex = 4;
            this.dtgvClubTask.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvClubTask_CellFormatting);
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
            this.panel1.Location = new System.Drawing.Point(508, 745);
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
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(294, 187);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(898, 39);
            this.txbSearch.TabIndex = 12;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // ClubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 1029);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.panel1);
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
        private Label label1;
        private DataGridView dtgvClubTask;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnAdjust;
        private Panel panel1;
        private Button btnRedo;
        private TextBox txbSearch;
    }
}