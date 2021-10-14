using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterWindows
{
    public partial class Form1 : Form
    {
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();

            db.Connect("userdata");
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2();

            register.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("select * from `user_info` where username = '" + UsernameField.Text + "' and password = '" + PasswordField.Text + "'");

            if (db.Count() == 1)
            {
                MessageBox.Show("Successfully login as " + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Invalid username and password. ");
            }
        }

        private void UsernameField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
