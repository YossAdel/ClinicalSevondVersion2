namespace ClinicalSevondVersion
{
    partial class PatientDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.view1 = new ClinicalSevondVersion.View();
            this.addAppointment1 = new ClinicalSevondVersion.AddAppointment();
            this.viewAppointment1 = new ClinicalSevondVersion.ViewAppointment();
            this.doctorSetting1 = new ClinicalInformatics_2023.DoctorSetting();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.guna2Button7);
            this.panel1.Controls.Add(this.guna2Button6);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 611);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderThickness = 1;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.Location = new System.Drawing.Point(12, 256);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(195, 43);
            this.guna2Button7.TabIndex = 9;
            this.guna2Button7.Text = "View Appointment";
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderThickness = 1;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.Image = global::ClinicalSevondVersion.Properties.Resources.log_out;
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.Location = new System.Drawing.Point(12, 354);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(195, 43);
            this.guna2Button6.TabIndex = 8;
            this.guna2Button6.Text = "Log-Out";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderThickness = 1;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.Image = global::ClinicalSevondVersion.Properties.Resources.settings;
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.Location = new System.Drawing.Point(12, 305);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(195, 43);
            this.guna2Button5.TabIndex = 7;
            this.guna2Button5.Text = "Settings";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(12, 207);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(195, 43);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "Add Appointment";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::ClinicalSevondVersion.Properties.Resources.drugs;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(12, 158);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(195, 43);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "View Prescription";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicalSevondVersion.Properties.Resources.panel2;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // view1
            // 
            this.view1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view1.BackgroundImage")));
            this.view1.Location = new System.Drawing.Point(223, 0);
            this.view1.Name = "view1";
            this.view1.Size = new System.Drawing.Size(668, 611);
            this.view1.TabIndex = 3;
            // 
            // addAppointment1
            // 
            this.addAppointment1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addAppointment1.BackgroundImage")));
            this.addAppointment1.Location = new System.Drawing.Point(223, 0);
            this.addAppointment1.Name = "addAppointment1";
            this.addAppointment1.Size = new System.Drawing.Size(668, 611);
            this.addAppointment1.TabIndex = 2;
            // 
            // viewAppointment1
            // 
            this.viewAppointment1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewAppointment1.BackgroundImage")));
            this.viewAppointment1.Location = new System.Drawing.Point(223, 0);
            this.viewAppointment1.Name = "viewAppointment1";
            this.viewAppointment1.Size = new System.Drawing.Size(668, 611);
            this.viewAppointment1.TabIndex = 4;
            // 
            // doctorSetting1
            // 
            this.doctorSetting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(227)))));
            this.doctorSetting1.Location = new System.Drawing.Point(221, 3);
            this.doctorSetting1.Name = "doctorSetting1";
            this.doctorSetting1.Size = new System.Drawing.Size(670, 611);
            this.doctorSetting1.TabIndex = 5;
            // 
            // PatientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicalSevondVersion.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.doctorSetting1);
            this.Controls.Add(this.viewAppointment1);
            this.Controls.Add(this.view1);
            this.Controls.Add(this.addAppointment1);
            this.Controls.Add(this.panel1);
            this.Name = "PatientDashboard";
            this.Text = "PatientDashboard";
            this.Load += new System.EventHandler(this.PatientDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private AddAppointment addAppointment1;
        private View view1;
        private ViewAppointment viewAppointment1;
        private ClinicalInformatics_2023.DoctorSetting doctorSetting1;
    }
}