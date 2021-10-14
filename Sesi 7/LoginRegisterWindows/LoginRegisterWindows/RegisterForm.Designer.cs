
namespace LoginRegisterWindows
{
    partial class Form2
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
            this.Register = new System.Windows.Forms.Button();
            this.HaveAnAcc = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(303, 316);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(86, 32);
            this.Register.TabIndex = 16;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // HaveAnAcc
            // 
            this.HaveAnAcc.AutoSize = true;
            this.HaveAnAcc.Location = new System.Drawing.Point(259, 392);
            this.HaveAnAcc.Name = "HaveAnAcc";
            this.HaveAnAcc.Size = new System.Drawing.Size(215, 20);
            this.HaveAnAcc.TabIndex = 15;
            this.HaveAnAcc.Text = "Have an account? Click here ";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(439, 316);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(86, 32);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(284, 198);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(261, 26);
            this.PasswordField.TabIndex = 13;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(137, 201);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 20);
            this.Password.TabIndex = 12;
            this.Password.Text = "Password ";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(137, 157);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(87, 20);
            this.Username.TabIndex = 11;
            this.Username.Text = "Username ";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(476, 386);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(86, 32);
            this.Login.TabIndex = 10;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // UsernameField
            // 
            this.UsernameField.Location = new System.Drawing.Point(284, 154);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(261, 26);
            this.UsernameField.TabIndex = 9;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(137, 111);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 20);
            this.Name.TabIndex = 18;
            this.Name.Text = "Name";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(284, 108);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(261, 26);
            this.NameField.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.HaveAnAcc);
            this.Name.Name = "Form2";
            this.Text = "Register Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label HaveAnAcc;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NameField;
    }
}