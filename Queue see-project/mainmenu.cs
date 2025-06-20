using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_see_project
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void btnpatientcheck_Click(object sender, EventArgs e)
        {
            Patient_Check_in patient_Check_In = new Patient_Check_in();
            patient_Check_In.Show();
            this.Close();
        }

        private void btnwaitingroom_Click(object sender, EventArgs e)
        {
           WatingRoom watingRoom = new WatingRoom();
            watingRoom.Show();
            this.Close();
        }

        private void btndocter_Click(object sender, EventArgs e)
        {
            Docter_Interface docter_Interface = new Docter_Interface();
            docter_Interface.Show();
            this.Close();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            logininterface logininterface = new logininterface();
            logininterface.Show();
            this.Close();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
