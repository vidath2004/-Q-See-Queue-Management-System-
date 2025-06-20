using QueueSeeProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Queue_see_project
{
    public partial class Patient_Check_in : Form
    {
        private DatabaseHelper db;
        public Patient_Check_in()
        {
            InitializeComponent();
            db = new DatabaseHelper("localhost", "dispensary", "root");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
           
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtPname.Text;
            if (Page.SelectedItem != null && Quenumber.SelectedItem != null &&
                int.TryParse(Page.SelectedItem.ToString(), out int age) && int.TryParse(Quenumber.SelectedItem.ToString(), out int queueNumber))
            {
                // Check if the queue number already exists
                if (db.QueueNumberExists(queueNumber))
                {
                    MessageBox.Show($"The queue number {queueNumber} is already in use. Please select a different queue number.", "Duplicate Queue Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
            else
            {
                MessageBox.Show("Please enter valid age and queue number.");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // The URL to phpMyAdmin
            string phpMyAdminUrl = "http://localhost/phpmyadmin";

            try
            {
                // Open the default web browser with the phpMyAdmin URL
                Process.Start(new ProcessStartInfo("cmd", $"/c start {phpMyAdminUrl}") { CreateNoWindow = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open phpMyAdmin: " + ex.Message);
            }
        }

        private void Patient_Check_in_Load(object sender, EventArgs e)
        {

        }
    }
    }

