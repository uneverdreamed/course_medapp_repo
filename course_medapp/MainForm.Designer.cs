namespace course_medapp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            panelMenu = new System.Windows.Forms.Panel();
            btnPatients = new System.Windows.Forms.Button();
            btnDoctors = new System.Windows.Forms.Button();
            btnAppointments = new System.Windows.Forms.Button();
            btnSchedule = new System.Windows.Forms.Button();
            btnDepartments = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            panelMain = new System.Windows.Forms.Panel();
            panelStats = new System.Windows.Forms.Panel();
            panelStatAppointments = new System.Windows.Forms.Panel();
            lblAppointmentsValue = new System.Windows.Forms.Label();
            lblAppointmentsTitle = new System.Windows.Forms.Label();
            panelStatDoctors = new System.Windows.Forms.Panel();
            lblDoctorsValue = new System.Windows.Forms.Label();
            lblDoctorsTitle = new System.Windows.Forms.Label();
            panelStatPatients = new System.Windows.Forms.Panel();
            lblPatientsValue = new System.Windows.Forms.Label();
            lblPatientsTitle = new System.Windows.Forms.Label();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            panelMain.SuspendLayout();
            panelStats.SuspendLayout();
            panelStatAppointments.SuspendLayout();
            panelStatDoctors.SuspendLayout();
            panelStatPatients.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(135, 206, 235);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(1924, 115);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            lblTitle.Location = new System.Drawing.Point(50, 23);
            lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(460, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Медицинская система";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            panelMenu.Controls.Add(btnPatients);
            panelMenu.Controls.Add(btnDoctors);
            panelMenu.Controls.Add(btnAppointments);
            panelMenu.Controls.Add(btnSchedule);
            panelMenu.Controls.Add(btnDepartments);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 115);
            panelMenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(394, 935);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnPatients
            // 
            btnPatients.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            btnPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPatients.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPatients.ForeColor = System.Drawing.Color.White;
            btnPatients.Location = new System.Drawing.Point(0, 38);
            btnPatients.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnPatients.Name = "btnPatients";
            btnPatients.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            btnPatients.Size = new System.Drawing.Size(583, 135);
            btnPatients.TabIndex = 0;
            btnPatients.Text = "Пациенты";
            btnPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            btnDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDoctors.FlatAppearance.BorderSize = 0;
            btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDoctors.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDoctors.ForeColor = System.Drawing.Color.White;
            btnDoctors.Location = new System.Drawing.Point(0, 161);
            btnDoctors.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            btnDoctors.Size = new System.Drawing.Size(583, 135);
            btnDoctors.TabIndex = 1;
            btnDoctors.Text = "Врачи";
            btnDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAppointments.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAppointments.ForeColor = System.Drawing.Color.White;
            btnAppointments.Location = new System.Drawing.Point(0, 308);
            btnAppointments.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            btnAppointments.Size = new System.Drawing.Size(583, 135);
            btnAppointments.TabIndex = 2;
            btnAppointments.Text = "Записи";
            btnAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSchedule.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSchedule.ForeColor = System.Drawing.Color.White;
            btnSchedule.Location = new System.Drawing.Point(0, 442);
            btnSchedule.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            btnSchedule.Size = new System.Drawing.Size(583, 135);
            btnSchedule.TabIndex = 3;
            btnSchedule.Text = "Расписание";
            btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            btnDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDepartments.FlatAppearance.BorderSize = 0;
            btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDepartments.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDepartments.ForeColor = System.Drawing.Color.White;
            btnDepartments.Location = new System.Drawing.Point(0, 577);
            btnDepartments.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            btnDepartments.Size = new System.Drawing.Size(583, 135);
            btnDepartments.TabIndex = 4;
            btnDepartments.Text = "Отделения";
            btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDepartments.UseVisualStyleBackColor = false;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnExit.BackColor = System.Drawing.Color.FromArgb(255, 87, 34);
            btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Location = new System.Drawing.Point(40, 560);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(270, 60);
            btnExit.TabIndex = 5;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.White;
            panelMain.Controls.Add(panelStats);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(394, 115);
            panelMain.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1530, 935);
            panelMain.TabIndex = 2;
            // 
            // panelStats
            // 
            panelStats.Controls.Add(panelStatAppointments);
            panelStats.Controls.Add(panelStatDoctors);
            panelStats.Controls.Add(panelStatPatients);
            panelStats.Location = new System.Drawing.Point(83, 192);
            panelStats.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelStats.Name = "panelStats";
            panelStats.Size = new System.Drawing.Size(1250, 865);
            panelStats.TabIndex = 0;
            // 
            // panelStatAppointments
            // 
            panelStatAppointments.BackColor = System.Drawing.Color.FromArgb(135, 206, 235);
            panelStatAppointments.Controls.Add(lblAppointmentsValue);
            panelStatAppointments.Controls.Add(lblAppointmentsTitle);
            panelStatAppointments.Location = new System.Drawing.Point(862, 296);
            panelStatAppointments.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelStatAppointments.Name = "panelStatAppointments";
            panelStatAppointments.Size = new System.Drawing.Size(290, 212);
            panelStatAppointments.TabIndex = 2;
            // 
            // lblAppointmentsValue
            // 
            lblAppointmentsValue.AutoSize = true;
            lblAppointmentsValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAppointmentsValue.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            lblAppointmentsValue.Location = new System.Drawing.Point(112, 87);
            lblAppointmentsValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblAppointmentsValue.Name = "lblAppointmentsValue";
            lblAppointmentsValue.Size = new System.Drawing.Size(74, 86);
            lblAppointmentsValue.TabIndex = 1;
            lblAppointmentsValue.Text = "4";
            lblAppointmentsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppointmentsTitle
            // 
            lblAppointmentsTitle.AutoSize = true;
            lblAppointmentsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAppointmentsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            lblAppointmentsTitle.Location = new System.Drawing.Point(69, 26);
            lblAppointmentsTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblAppointmentsTitle.Name = "lblAppointmentsTitle";
            lblAppointmentsTitle.Size = new System.Drawing.Size(156, 45);
            lblAppointmentsTitle.TabIndex = 0;
            lblAppointmentsTitle.Text = "Записей:";
            lblAppointmentsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelStatDoctors
            // 
            panelStatDoctors.BackColor = System.Drawing.Color.FromArgb(135, 206, 235);
            panelStatDoctors.Controls.Add(lblDoctorsValue);
            panelStatDoctors.Controls.Add(lblDoctorsTitle);
            panelStatDoctors.Location = new System.Drawing.Point(458, 296);
            panelStatDoctors.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelStatDoctors.Name = "panelStatDoctors";
            panelStatDoctors.Size = new System.Drawing.Size(290, 212);
            panelStatDoctors.TabIndex = 1;
            // 
            // lblDoctorsValue
            // 
            lblDoctorsValue.AutoSize = true;
            lblDoctorsValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDoctorsValue.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            lblDoctorsValue.Location = new System.Drawing.Point(107, 87);
            lblDoctorsValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDoctorsValue.Name = "lblDoctorsValue";
            lblDoctorsValue.Size = new System.Drawing.Size(74, 86);
            lblDoctorsValue.TabIndex = 1;
            lblDoctorsValue.Text = "3";
            lblDoctorsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoctorsTitle
            // 
            lblDoctorsTitle.AutoSize = true;
            lblDoctorsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDoctorsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            lblDoctorsTitle.Location = new System.Drawing.Point(73, 26);
            lblDoctorsTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDoctorsTitle.Name = "lblDoctorsTitle";
            lblDoctorsTitle.Size = new System.Drawing.Size(143, 45);
            lblDoctorsTitle.TabIndex = 0;
            lblDoctorsTitle.Text = "Врачей:";
            lblDoctorsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblDoctorsTitle.Click += lblDoctorsTitle_Click;
            // 
            // panelStatPatients
            // 
            panelStatPatients.BackColor = System.Drawing.Color.FromArgb(135, 206, 235);
            panelStatPatients.Controls.Add(lblPatientsValue);
            panelStatPatients.Controls.Add(lblPatientsTitle);
            panelStatPatients.Location = new System.Drawing.Point(56, 296);
            panelStatPatients.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelStatPatients.Name = "panelStatPatients";
            panelStatPatients.Size = new System.Drawing.Size(290, 212);
            panelStatPatients.TabIndex = 0;
            // 
            // lblPatientsValue
            // 
            lblPatientsValue.AutoSize = true;
            lblPatientsValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPatientsValue.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            lblPatientsValue.Location = new System.Drawing.Point(104, 87);
            lblPatientsValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPatientsValue.Name = "lblPatientsValue";
            lblPatientsValue.Size = new System.Drawing.Size(74, 86);
            lblPatientsValue.TabIndex = 1;
            lblPatientsValue.Text = "2";
            lblPatientsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPatientsTitle
            // 
            lblPatientsTitle.AutoSize = true;
            lblPatientsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPatientsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            lblPatientsTitle.Location = new System.Drawing.Point(40, 26);
            lblPatientsTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPatientsTitle.Name = "lblPatientsTitle";
            lblPatientsTitle.Size = new System.Drawing.Size(202, 45);
            lblPatientsTitle.TabIndex = 0;
            lblPatientsTitle.Text = "Пациентов:";
            lblPatientsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblPatientsTitle.Click += lblPatientsTitle_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 1050);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Медицинская система - Главная";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelStats.ResumeLayout(false);
            panelStatAppointments.ResumeLayout(false);
            panelStatAppointments.PerformLayout();
            panelStatDoctors.ResumeLayout(false);
            panelStatDoctors.PerformLayout();
            panelStatPatients.ResumeLayout(false);
            panelStatPatients.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnDepartments;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelStatPatients;
        private System.Windows.Forms.Label lblPatientsValue;
        private System.Windows.Forms.Label lblPatientsTitle;
        private System.Windows.Forms.Panel panelStatDoctors;
        private System.Windows.Forms.Label lblDoctorsValue;
        private System.Windows.Forms.Label lblDoctorsTitle;
        private System.Windows.Forms.Panel panelStatAppointments;
        private System.Windows.Forms.Label lblAppointmentsValue;
        private System.Windows.Forms.Label lblAppointmentsTitle;
    }
}