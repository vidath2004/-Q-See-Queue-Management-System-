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
    public partial class maindatabase : Form
    {
        public maindatabase()
        {
            InitializeComponent();
            // Initialize columns if not done through designer
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("PatientName", "Patient Name");
                dataGridView1.Columns.Add("Age", "Age");
                dataGridView1.Columns.Add("QueueNumber", "Queue Number");
            }
        }
        public void AddPatientToGrid(Patient patient)
        {
            dataGridView1.Rows.Add(patient.Name, patient.Age, patient.QueueNumber);
        }
        private void maindatabase_Load(object sender, EventArgs e)
        {

        }

        private void btnBackP_Click(object sender, EventArgs e)
        {
            Patient_Check_in patient_Check_In=new Patient_Check_in();
            patient_Check_In.Show();
            this.Close();
        }

        private void btnBackW_Click(object sender, EventArgs e)
        {
            WatingRoom  watingRoom = new WatingRoom();
            watingRoom.Show();
            this.Close();
        }

        private void btnBackD_Click(object sender, EventArgs e)
        {
            Docter_Interface docter_Interface = new Docter_Interface();
            docter_Interface.Show();
            this.Close();
        }
    }
}

