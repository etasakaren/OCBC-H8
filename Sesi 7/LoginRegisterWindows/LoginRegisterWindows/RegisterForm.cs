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
    public partial class Form2 : Form
    {
        Config db = new Config();
        public Form2()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void Register_Click(object sender, EventArgs e)
        {
            db.Execute("insert into `user_info` (`id`, `names`, `username`, `password`) values ( null, '" + NameField.Text + "', '" + UsernameField.Text + "', '" + PasswordField.Text + "')");

            if (db.Count() >= 0)
            {
                MessageBox.Show("Successfully registered as " + db.Results(0, "names"));
            }

            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
