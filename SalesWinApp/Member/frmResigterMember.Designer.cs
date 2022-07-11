namespace SaleWinApp
{
    partial class frmResigterMember
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
            this.txt_MemberEmail = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lb_MemberEmail = new System.Windows.Forms.Label();
            this.lb_MemberCountry = new System.Windows.Forms.Label();
            this.lb_MemberCompany = new System.Windows.Forms.Label();
            this.lb_MemberCity = new System.Windows.Forms.Label();
            this.lb_MemberPassword = new System.Windows.Forms.Label();
            this.txt_MemberCompanyName = new System.Windows.Forms.TextBox();
            this.txt_MemberCity = new System.Windows.Forms.TextBox();
            this.txt_MemberCountry = new System.Windows.Forms.TextBox();
            this.txt_MemberPassword = new System.Windows.Forms.TextBox();
            this.lb_MemberID = new System.Windows.Forms.Label();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_MemberEmail
            // 
            this.txt_MemberEmail.Location = new System.Drawing.Point(299, 104);
            this.txt_MemberEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MemberEmail.Name = "txt_MemberEmail";
            this.txt_MemberEmail.Size = new System.Drawing.Size(230, 27);
            this.txt_MemberEmail.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.Location = new System.Drawing.Point(192, 309);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 27);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Member_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(373, 309);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 27);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Member_Save_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(215, 7);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(217, 30);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "ADD NEW MEMBER";
            // 
            // lb_MemberEmail
            // 
            this.lb_MemberEmail.AutoSize = true;
            this.lb_MemberEmail.Location = new System.Drawing.Point(168, 107);
            this.lb_MemberEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MemberEmail.Name = "lb_MemberEmail";
            this.lb_MemberEmail.Size = new System.Drawing.Size(109, 20);
            this.lb_MemberEmail.TabIndex = 8;
            this.lb_MemberEmail.Text = "Member Email:";
            // 
            // lb_MemberCountry
            // 
            this.lb_MemberCountry.AutoSize = true;
            this.lb_MemberCountry.Location = new System.Drawing.Point(168, 228);
            this.lb_MemberCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MemberCountry.Name = "lb_MemberCountry";
            this.lb_MemberCountry.Size = new System.Drawing.Size(63, 20);
            this.lb_MemberCountry.TabIndex = 9;
            this.lb_MemberCountry.Text = "Country:";
            // 
            // lb_MemberCompany
            // 
            this.lb_MemberCompany.AutoSize = true;
            this.lb_MemberCompany.Location = new System.Drawing.Point(166, 152);
            this.lb_MemberCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MemberCompany.Name = "lb_MemberCompany";
            this.lb_MemberCompany.Size = new System.Drawing.Size(119, 20);
            this.lb_MemberCompany.TabIndex = 10;
            this.lb_MemberCompany.Text = "Company Name:";
            // 
            // lb_MemberCity
            // 
            this.lb_MemberCity.AutoSize = true;
            this.lb_MemberCity.Location = new System.Drawing.Point(168, 191);
            this.lb_MemberCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MemberCity.Name = "lb_MemberCity";
            this.lb_MemberCity.Size = new System.Drawing.Size(37, 20);
            this.lb_MemberCity.TabIndex = 11;
            this.lb_MemberCity.Text = "City:";
            // 
            // lb_MemberPassword
            // 
            this.lb_MemberPassword.AutoSize = true;
            this.lb_MemberPassword.Location = new System.Drawing.Point(168, 269);
            this.lb_MemberPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MemberPassword.Name = "lb_MemberPassword";
            this.lb_MemberPassword.Size = new System.Drawing.Size(73, 20);
            this.lb_MemberPassword.TabIndex = 12;
            this.lb_MemberPassword.Text = "Password:";
            // 
            // txt_MemberCompanyName
            // 
            this.txt_MemberCompanyName.Location = new System.Drawing.Point(299, 147);
            this.txt_MemberCompanyName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MemberCompanyName.Name = "txt_MemberCompanyName";
            this.txt_MemberCompanyName.Size = new System.Drawing.Size(230, 27);
            this.txt_MemberCompanyName.TabIndex = 13;
            // 
            // txt_MemberCity
            // 
            this.txt_MemberCity.Location = new System.Drawing.Point(299, 185);
            this.txt_MemberCity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MemberCity.Name = "txt_MemberCity";
            this.txt_MemberCity.Size = new System.Drawing.Size(230, 27);
            this.txt_MemberCity.TabIndex = 14;
            // 
            // txt_MemberCountry
            // 
            this.txt_MemberCountry.Location = new System.Drawing.Point(299, 223);
            this.txt_MemberCountry.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MemberCountry.Name = "txt_MemberCountry";
            this.txt_MemberCountry.Size = new System.Drawing.Size(230, 27);
            this.txt_MemberCountry.TabIndex = 15;
            // 
            // txt_MemberPassword
            // 
            this.txt_MemberPassword.Location = new System.Drawing.Point(299, 264);
            this.txt_MemberPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MemberPassword.Name = "txt_MemberPassword";
            this.txt_MemberPassword.Size = new System.Drawing.Size(230, 27);
            this.txt_MemberPassword.TabIndex = 16;
            // 
            // lb_MemberID
            // 
            this.lb_MemberID.AutoSize = true;
            this.lb_MemberID.Location = new System.Drawing.Point(168, 69);
            this.lb_MemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MemberID.Name = "lb_MemberID";
            this.lb_MemberID.Size = new System.Drawing.Size(85, 20);
            this.lb_MemberID.TabIndex = 18;
            this.lb_MemberID.Text = "Member Id:";
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(299, 62);
            this.txt_MemberID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(230, 27);
            this.txt_MemberID.TabIndex = 19;
            // 
            // frmResigterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.lb_MemberID);
            this.Controls.Add(this.txt_MemberPassword);
            this.Controls.Add(this.txt_MemberCountry);
            this.Controls.Add(this.txt_MemberCity);
            this.Controls.Add(this.txt_MemberCompanyName);
            this.Controls.Add(this.lb_MemberPassword);
            this.Controls.Add(this.lb_MemberCity);
            this.Controls.Add(this.lb_MemberCompany);
            this.Controls.Add(this.lb_MemberCountry);
            this.Controls.Add(this.lb_MemberEmail);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_MemberEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmResigterMember";
            this.Text = "Add new Member";
            this.Load += new System.EventHandler(this.frmResigterMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MemberEmail;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lb_MemberEmail;
        private System.Windows.Forms.Label lb_MemberCountry;
        private System.Windows.Forms.Label lb_MemberCompany;
        private System.Windows.Forms.Label lb_MemberCity;
        private System.Windows.Forms.Label lb_MemberPassword;
        private System.Windows.Forms.TextBox txt_MemberCompanyName;
        private System.Windows.Forms.TextBox txt_MemberCity;
        private System.Windows.Forms.TextBox txt_MemberCountry;
        private System.Windows.Forms.TextBox txt_MemberPassword;
        private System.Windows.Forms.Label lb_MemberID;
        private TextBox txt_MemberID;
    }
}