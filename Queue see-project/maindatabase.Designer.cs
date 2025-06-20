namespace Queue_see_project
{
    partial class maindatabase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBackP = new System.Windows.Forms.Button();
            this.btnBackW = new System.Windows.Forms.Button();
            this.btnBackD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pname,
            this.Age,
            this.Qnumber,
            this.Process});
            this.dataGridView1.Location = new System.Drawing.Point(2, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // Pname
            // 
            this.Pname.HeaderText = "Patient Name";
            this.Pname.Name = "Pname";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Qnumber
            // 
            this.Qnumber.HeaderText = "Queue Number";
            this.Qnumber.Name = "Qnumber";
            // 
            // Process
            // 
            this.Process.HeaderText = "Process";
            this.Process.Name = "Process";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "21";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vidath";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(368, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Wating";
            // 
            // btnBackP
            // 
            this.btnBackP.BackColor = System.Drawing.Color.Gold;
            this.btnBackP.Location = new System.Drawing.Point(32, 227);
            this.btnBackP.Name = "btnBackP";
            this.btnBackP.Size = new System.Drawing.Size(252, 36);
            this.btnBackP.TabIndex = 2;
            this.btnBackP.Text = "Back to the Paient Check in";
            this.btnBackP.UseVisualStyleBackColor = false;
            this.btnBackP.Click += new System.EventHandler(this.btnBackP_Click);
            // 
            // btnBackW
            // 
            this.btnBackW.BackColor = System.Drawing.Color.Gold;
            this.btnBackW.Location = new System.Drawing.Point(32, 288);
            this.btnBackW.Name = "btnBackW";
            this.btnBackW.Size = new System.Drawing.Size(252, 36);
            this.btnBackW.TabIndex = 3;
            this.btnBackW.Text = "Back to the Wating Room";
            this.btnBackW.UseVisualStyleBackColor = false;
            this.btnBackW.Click += new System.EventHandler(this.btnBackW_Click);
            // 
            // btnBackD
            // 
            this.btnBackD.BackColor = System.Drawing.Color.Gold;
            this.btnBackD.Location = new System.Drawing.Point(32, 352);
            this.btnBackD.Name = "btnBackD";
            this.btnBackD.Size = new System.Drawing.Size(252, 36);
            this.btnBackD.TabIndex = 4;
            this.btnBackD.Text = "Back to the Doctor Interface";
            this.btnBackD.UseVisualStyleBackColor = false;
            this.btnBackD.Click += new System.EventHandler(this.btnBackD_Click);
            // 
            // maindatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Queue_see_project.Properties.Resources._4;
            this.ClientSize = new System.Drawing.Size(683, 400);
            this.Controls.Add(this.btnBackD);
            this.Controls.Add(this.btnBackW);
            this.Controls.Add(this.btnBackP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "maindatabase";
            this.Text = "maindatabase";
            this.Load += new System.EventHandler(this.maindatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBackP;
        private System.Windows.Forms.Button btnBackW;
        private System.Windows.Forms.Button btnBackD;
    }
}