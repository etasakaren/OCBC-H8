
namespace LoginRegisterWindows
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.CreateAnAcc = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Authentication = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameField
            // 
            this.UsernameField.Location = new System.Drawing.Point(284, 187);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(261, 26);
            this.UsernameField.TabIndex = 0;
            this.UsernameField.TextChanged += new System.EventHandler(this.UsernameField_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(303, 283);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(86, 32);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(137, 190);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(87, 20);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username ";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(137, 234);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password ";
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(284, 231);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(261, 26);
            this.PasswordField.TabIndex = 4;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(439, 283);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(86, 32);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CreateAnAcc
            // 
            this.CreateAnAcc.AutoSize = true;
            this.CreateAnAcc.Location = new System.Drawing.Point(259, 359);
            this.CreateAnAcc.Name = "CreateAnAcc";
            this.CreateAnAcc.Size = new System.Drawing.Size(226, 20);
            this.CreateAnAcc.TabIndex = 6;
            this.CreateAnAcc.Text = "Create an account? Click here ";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(481, 353);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(86, 32);
            this.Register.TabIndex = 7;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Authentication);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 165);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Authentication
            // 
            this.Authentication.AutoSize = true;
            this.Authentication.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authentication.Location = new System.Drawing.Point(279, 50);
            this.Authentication.Name = "Authentication";
            this.Authentication.Size = new System.Drawing.Size(408, 75);
            this.Authentication.TabIndex = 1;
            this.Authentication.Text = "Authentication";
            this.Authentication.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.CreateAnAcc);
            this.Name = "Form1";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label CreateAnAcc;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Authentication;
    }
}

