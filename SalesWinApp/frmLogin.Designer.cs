namespace SaleWinApp
{
    partial class lb_Password
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_LoginTitle = new System.Windows.Forms.Label();
            this.label_LoginPassword = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_LoginTitle
            // 
            this.label_LoginTitle.AutoSize = true;
            this.label_LoginTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_LoginTitle.Location = new System.Drawing.Point(177, 25);
            this.label_LoginTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LoginTitle.Name = "label_LoginTitle";
            this.label_LoginTitle.Size = new System.Drawing.Size(322, 46);
            this.label_LoginTitle.TabIndex = 0;
            this.label_LoginTitle.Text = "Welcome To Fstore";
            // 
            // label_LoginPassword
            // 
            this.label_LoginPassword.AutoSize = true;
            this.label_LoginPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_LoginPassword.Location = new System.Drawing.Point(151, 224);
            this.label_LoginPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LoginPassword.Name = "label_LoginPassword";
            this.label_LoginPassword.Size = new System.Drawing.Size(80, 20);
            this.label_LoginPassword.TabIndex = 1;
            this.label_LoginPassword.Text = "Password:";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Email.Location = new System.Drawing.Point(151, 140);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(51, 20);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(275, 136);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(199, 27);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(275, 213);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(199, 27);
            this.txt_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(365, 295);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(89, 30);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Register.Location = new System.Drawing.Point(204, 295);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(89, 30);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            // 
            // lb_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 397);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.label_LoginPassword);
            this.Controls.Add(this.label_LoginTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "lb_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LoginTitle;
        private System.Windows.Forms.Label label_LoginPassword;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private Button btn_Register;
    }
}
