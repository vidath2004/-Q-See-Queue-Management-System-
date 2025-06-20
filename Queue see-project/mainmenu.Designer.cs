namespace Queue_see_project
{
    partial class mainmenu
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
            this.btnpatientcheck = new System.Windows.Forms.Button();
            this.btnwaitingroom = new System.Windows.Forms.Button();
            this.btndocter = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpatientcheck
            // 
            this.btnpatientcheck.Location = new System.Drawing.Point(28, 42);
            this.btnpatientcheck.Name = "btnpatientcheck";
            this.btnpatientcheck.Size = new System.Drawing.Size(291, 45);
            this.btnpatientcheck.TabIndex = 0;
            this.btnpatientcheck.Text = "Patient Check-in Interface";
            this.btnpatientcheck.UseVisualStyleBackColor = true;
            this.btnpatientcheck.Click += new System.EventHandler(this.btnpatientcheck_Click);
            // 
            // btnwaitingroom
            // 
            this.btnwaitingroom.Location = new System.Drawing.Point(28, 127);
            this.btnwaitingroom.Name = "btnwaitingroom";
            this.btnwaitingroom.Size = new System.Drawing.Size(291, 52);
            this.btnwaitingroom.TabIndex = 1;
            this.btnwaitingroom.Text = "Waiting Room";
            this.btnwaitingroom.UseVisualStyleBackColor = true;
            this.btnwaitingroom.Click += new System.EventHandler(this.btnwaitingroom_Click);
            // 
            // btndocter
            // 
            this.btndocter.Location = new System.Drawing.Point(28, 209);
            this.btndocter.Name = "btndocter";
            this.btndocter.Size = new System.Drawing.Size(291, 58);
            this.btndocter.TabIndex = 2;
            this.btndocter.Text = "Docter Interface";
            this.btndocter.UseVisualStyleBackColor = true;
            this.btndocter.Click += new System.EventHandler(this.btndocter_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(108, 320);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(131, 45);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Queue_see_project.Properties.Resources.pharmacist_3646195_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btndocter);
            this.Controls.Add(this.btnwaitingroom);
            this.Controls.Add(this.btnpatientcheck);
            this.Name = "mainmenu";
            this.Text = "Main Interface";
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpatientcheck;
        private System.Windows.Forms.Button btnwaitingroom;
        private System.Windows.Forms.Button btndocter;
        private System.Windows.Forms.Button btnlogout;
    }
}