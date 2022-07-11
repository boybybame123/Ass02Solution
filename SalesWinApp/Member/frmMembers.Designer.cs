namespace SaleWinApp
{
    partial class frmMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgv_OrderHistory = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_OrderHistory
            // 
            this.dgv_OrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderHistory.Location = new System.Drawing.Point(110, 278);
            this.dgv_OrderHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_OrderHistory.Name = "dgv_OrderHistory";
            this.dgv_OrderHistory.ReadOnly = true;
            this.dgv_OrderHistory.RowHeadersWidth = 51;
            this.dgv_OrderHistory.RowTemplate.Height = 25;
            this.dgv_OrderHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OrderHistory.Size = new System.Drawing.Size(866, 272);
            this.dgv_OrderHistory.TabIndex = 14;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(282, 137);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(149, 35);
            this.btn_Update.TabIndex = 17;
            this.btn_Update.Text = "Update profile";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(617, 137);
            this.btn_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(149, 35);
            this.btn_View.TabIndex = 19;
            this.btn_View.Text = "View profile";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Welcome.Location = new System.Drawing.Point(423, 29);
            this.label_Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(184, 40);
            this.label_Welcome.TabIndex = 21;
            this.label_Welcome.Text = "HELLO USER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 604);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(866, 272);
            this.dataGridView1.TabIndex = 22;
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 1008);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dgv_OrderHistory);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_OrderHistory;
        private System.Windows.Forms.Button btn_Update;
        private Button btn_View;
        private Label label_Welcome;
        private DataGridView dataGridView1;
    }
}