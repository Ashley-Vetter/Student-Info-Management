namespace Student_Information_Management.Presentation_Layer
{
    partial class LoginForm
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
            txtEnterUsername = new TextBox();
            txtEnterPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtEnterUsername
            // 
            txtEnterUsername.Location = new Point(119, 30);
            txtEnterUsername.Margin = new Padding(2, 1, 2, 1);
            txtEnterUsername.Name = "txtEnterUsername";
            txtEnterUsername.Size = new Size(125, 23);
            txtEnterUsername.TabIndex = 0;
            // 
            // txtEnterPassword
            // 
            txtEnterPassword.Location = new Point(119, 75);
            txtEnterPassword.Margin = new Padding(2, 1, 2, 1);
            txtEnterPassword.Name = "txtEnterPassword";
            txtEnterPassword.Size = new Size(125, 23);
            txtEnterPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(43, 33);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 78);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(43, 112);
            btnLogin.Margin = new Padding(2, 1, 2, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 41);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(155, 112);
            btnRegister.Margin = new Padding(2, 1, 2, 1);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(89, 41);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(274, 177);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtEnterPassword);
            Controls.Add(txtEnterUsername);
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoginForm";
            Text = "Login Form";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEnterUsername;
        private TextBox txtEnterPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnRegister;
    }
}