using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_see_project
{
    public partial class logininterface : Form
    {
        public logininterface()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (username == "admin" && password == "1234")
            {
                mainmenu form2 = new mainmenu();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);
            this.Close();

        }

        private void logininterface_Load(object sender, EventArgs e)
        {

        }
    }
}
