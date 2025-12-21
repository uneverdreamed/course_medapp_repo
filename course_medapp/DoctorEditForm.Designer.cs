namespace course_medapp.Forms
{
    partial class DoctorEditForm
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

        private void InitializeComponent()
        {
            panelTop = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            lblLastName = new System.Windows.Forms.Label();
            txtLastName = new System.Windows.Forms.TextBox();
            lblMiddleName = new System.Windows.Forms.Label();
            txtMiddleName = new System.Windows.Forms.TextBox();
            lblPhone = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            lblBirthDate = new System.Windows.Forms.Label();
            dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            lblSpecialization = new System.Windows.Forms.Label();
            txtSpecialization = new System.Windows.Forms.TextBox();
            lblLicense = new System.Windows.Forms.Label();
            txtLicense = new System.Windows.Forms.TextBox();
            lblExperience = new System.Windows.Forms.Label();
            cmbExperience = new System.Windows.Forms.ComboBox();
            lblDepartment = new System.Windows.Forms.Label();
            cmbDepartment = new System.Windows.Forms.ComboBox();
            panelButtons = new System.Windows.Forms.Panel();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            panelTop.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(135, 206, 235);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1641, 115);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.Black;
            lblTitle.Location = new System.Drawing.Point(42, 29);
            lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(323, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Добавление врача:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFirstName.Location = new System.Drawing.Point(83, 173);
            lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(66, 32);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Имя:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFirstName.Location = new System.Drawing.Point(417, 163);
            txtFirstName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(883, 32);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLastName.Location = new System.Drawing.Point(83, 279);
            lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(118, 32);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Фамилия:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtLastName.Location = new System.Drawing.Point(417, 269);
            txtLastName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(883, 32);
            txtLastName.TabIndex = 4;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMiddleName.Location = new System.Drawing.Point(83, 385);
            lblMiddleName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new System.Drawing.Size(122, 32);
            lblMiddleName.TabIndex = 5;
            lblMiddleName.Text = "Отчество:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMiddleName.Location = new System.Drawing.Point(417, 375);
            txtMiddleName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new System.Drawing.Size(883, 32);
            txtMiddleName.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPhone.Location = new System.Drawing.Point(83, 490);
            lblPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(115, 32);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Телефон:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhone.Location = new System.Drawing.Point(417, 481);
            txtPhone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(883, 32);
            txtPhone.TabIndex = 8;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBirthDate.Location = new System.Drawing.Point(83, 596);
            lblBirthDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new System.Drawing.Size(189, 32);
            lblBirthDate.TabIndex = 9;
            lblBirthDate.Text = "Дата рождения:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(224, 224, 224);
            dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpBirthDate.Location = new System.Drawing.Point(417, 587);
            dtpBirthDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new System.Drawing.Size(881, 39);
            dtpBirthDate.TabIndex = 10;
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSpecialization.Location = new System.Drawing.Point(83, 702);
            lblSpecialization.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new System.Drawing.Size(191, 32);
            lblSpecialization.TabIndex = 11;
            lblSpecialization.Text = "Специализация:";
            // 
            // txtSpecialization
            // 
            txtSpecialization.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            txtSpecialization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSpecialization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSpecialization.Location = new System.Drawing.Point(417, 692);
            txtSpecialization.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new System.Drawing.Size(883, 32);
            txtSpecialization.TabIndex = 12;
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLicense.Location = new System.Drawing.Point(83, 808);
            lblLicense.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new System.Drawing.Size(151, 32);
            lblLicense.TabIndex = 13;
            lblLicense.Text = "N лицензии:";
            // 
            // txtLicense
            // 
            txtLicense.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            txtLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtLicense.Location = new System.Drawing.Point(417, 798);
            txtLicense.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new System.Drawing.Size(883, 32);
            txtLicense.TabIndex = 14;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblExperience.Location = new System.Drawing.Point(83, 913);
            lblExperience.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new System.Drawing.Size(131, 32);
            lblExperience.TabIndex = 15;
            lblExperience.Text = "Стаж (лет):";
            // 
            // cmbExperience
            // 
            cmbExperience.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            cmbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbExperience.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbExperience.FormattingEnabled = true;
            cmbExperience.Location = new System.Drawing.Point(417, 904);
            cmbExperience.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cmbExperience.Name = "cmbExperience";
            cmbExperience.Size = new System.Drawing.Size(881, 40);
            cmbExperience.TabIndex = 16;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDepartment.Location = new System.Drawing.Point(83, 1019);
            lblDepartment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new System.Drawing.Size(140, 32);
            lblDepartment.TabIndex = 17;
            lblDepartment.Text = "Отделение:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new System.Drawing.Point(417, 1010);
            cmbDepartment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new System.Drawing.Size(881, 40);
            cmbDepartment.TabIndex = 18;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelButtons.Location = new System.Drawing.Point(0, 1051);
            panelButtons.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new System.Drawing.Size(1641, 135);
            panelButtons.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(967, 29);
            btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(267, 77);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(255, 87, 34);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(1325, 29);
            btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(267, 77);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // DoctorEditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1667, 1050);
            Controls.Add(panelButtons);
            Controls.Add(cmbDepartment);
            Controls.Add(lblDepartment);
            Controls.Add(cmbExperience);
            Controls.Add(lblExperience);
            Controls.Add(txtLicense);
            Controls.Add(lblLicense);
            Controls.Add(txtSpecialization);
            Controls.Add(lblSpecialization);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(panelTop);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DoctorEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Врач";
            Load += DoctorEditForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.ComboBox cmbExperience;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}