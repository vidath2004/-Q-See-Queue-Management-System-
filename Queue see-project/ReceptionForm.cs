using System;
using System.Windows.Forms;

namespace QueueSeeProject
{
    public class ReceptionForm : Form
    {
        private DatabaseHelper db;
        private TextBox txtName;
        private ComboBox cmbAge;
        private ComboBox cmbQueueNumber;
        private Button btnSubmit;
        private Button btnShow;

        public ReceptionForm()
        {
            db = new DatabaseHelper("localhost", "dispensary", "root");
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            txtName = new TextBox { Location = new System.Drawing.Point(150, 50), Width = 200 };
            cmbAge = new ComboBox { Location = new System.Drawing.Point(150, 100), Width = 200 };
            cmbQueueNumber = new ComboBox { Location = new System.Drawing.Point(150, 150), Width = 200 };
            btnSubmit = new Button { Text = "Submit", Location = new System.Drawing.Point(150, 200) };
            btnShow = new Button { Text = "Show", Location = new System.Drawing.Point(250, 200) };

            btnSubmit.Click += BtnSubmit_Click;
            btnShow.Click += BtnShow_Click;

            Controls.Add(new Label { Text = "Patient Name:", Location = new System.Drawing.Point(50, 50) });
            Controls.Add(txtName);
            Controls.Add(new Label { Text = "Age:", Location = new System.Drawing.Point(50, 100) });
            Controls.Add(cmbAge);
            Controls.Add(new Label { Text = "Queue Number:", Location = new System.Drawing.Point(50, 150) });
            Controls.Add(cmbQueueNumber);
            Controls.Add(btnSubmit);
            Controls.Add(btnShow);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(cmbAge.Text);
            int queueNumber = int.Parse(cmbQueueNumber.Text);

            string query = $"INSERT INTO patients (name, age, queue_number) VALUES ('{name}', {age}, {queueNumber})";
            try
            {
                db.ExecuteNonQuery(query);
                MessageBox.Show("Patient added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            // Implementation to show patient data
        }
    }
}
