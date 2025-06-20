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
    public partial class Docter_Interface : Form
    {
        private DatabaseHelper db;
        public Docter_Interface()
        {
            InitializeComponent();
            db = new DatabaseHelper("localhost", "dispensary", "root");


        }

        private void Docter_Interface_Load(object sender, EventArgs e)
        {
            LoadPatientData();
        }
        private void LoadPatientData()
        {
            string query = "SELECT id, name,age, queue_number, status FROM patients WHERE status = 'Waiting'";
            DataTable patients = db.ExecuteQuery(query);
            dataGridViewPatients.DataSource = patients;
            dataGridViewPatients.Columns["Id"].Visible = false; // Hide the ID column
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int patientId = Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells["id"].Value);
                string query = $"UPDATE patients SET status = 'Done' WHERE id = {patientId}";
                try
                {
                    db.ExecuteNonQuery(query);
                    MessageBox.Show("Patient status updated to 'Done'.");
                    LoadPatientData(); // Refresh the data grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to mark as Done.");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
            this.Close();
        }

        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
