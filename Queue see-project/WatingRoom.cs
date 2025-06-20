using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueueSeeProject;

namespace Queue_see_project
{
    public partial class WatingRoom : Form
    {
        private DatabaseHelper db;
        private System.Windows.Forms.Timer timerRefresh;
        public WatingRoom()
        {
            InitializeComponent();
            db = new DatabaseHelper("localhost", "dispensary", "root");
            // Initialize the timer
            timerRefresh = new System.Windows.Forms.Timer();
            // Set interval to 5 seconds
            timerRefresh.Interval = 5000;
            // Assign event handler
            timerRefresh.Tick += new EventHandler(TimerRefresh_Tick); 
        }
        private void WatingRoom_Load(object sender, EventArgs e)
        {
            LoadPatientData();
            timerRefresh.Start();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        private void LoadPatientData()
        {
            string query = "SELECT queue_number AS 'Queue Number', status AS 'Status' FROM patients";
            DataTable patients = db.ExecuteQuery(query);
            dataGridViewWaitingRoom.DataSource = patients;

          
        }
        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            LoadPatientData();
        }

        private void dataGridViewWaitingRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
            this.Close();
        }
    }
}
