namespace Queue_see_project
{
    partial class WatingRoom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewWaitingRoom = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaitingRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridViewWaitingRoom);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waiting Room";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewWaitingRoom
            // 
            this.dataGridViewWaitingRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWaitingRoom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewWaitingRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWaitingRoom.Location = new System.Drawing.Point(83, 34);
            this.dataGridViewWaitingRoom.Name = "dataGridViewWaitingRoom";
            this.dataGridViewWaitingRoom.Size = new System.Drawing.Size(467, 267);
            this.dataGridViewWaitingRoom.TabIndex = 1;
            this.dataGridViewWaitingRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWaitingRoom_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(679, 162);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(84, 34);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // WatingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Queue_see_project.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(786, 363);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.groupBox1);
            this.Name = "WatingRoom";
            this.Text = "WatingRoom";
            this.Load += new System.EventHandler(this.WatingRoom_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaitingRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewWaitingRoom;
        private System.Windows.Forms.Button btnback;
    }
}