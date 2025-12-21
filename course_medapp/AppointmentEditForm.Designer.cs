namespace course_medapp.Forms
{
    public partial class AppointmentEditForm
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
            lblDoctor = new System.Windows.Forms.Label();
            cmbDoctor = new System.Windows.Forms.ComboBox();
            lblPatient = new System.Windows.Forms.Label();
            cmbPatient = new System.Windows.Forms.ComboBox();
            lblDate = new System.Windows.Forms.Label();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            lblTime = new System.Windows.Forms.Label();
            dtpTime = new System.Windows.Forms.DateTimePicker();
            lblDuration = new System.Windows.Forms.Label();
            numDuration = new System.Windows.Forms.NumericUpDown();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
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
            panelTop.Size = new System.Drawing.Size(917, 115);
            panelTop.TabIndex = 0;
            panelTop.Paint += panelTop_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.Black;
            lblTitle.Location = new System.Drawing.Point(33, 29);
            lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(390, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Новая запись на приём";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDoctor.Location = new System.Drawing.Point(50, 154);
            lblDoctor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new System.Drawing.Size(60, 28);
            lblDoctor.TabIndex = 1;
            lblDoctor.Text = "Врач:";
            // 
            // cmbDoctor
            // 
            cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new System.Drawing.Point(250, 148);
            cmbDoctor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new System.Drawing.Size(614, 36);
            cmbDoctor.TabIndex = 2;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPatient.Location = new System.Drawing.Point(50, 231);
            lblPatient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new System.Drawing.Size(94, 28);
            lblPatient.TabIndex = 3;
            lblPatient.Text = "Пациент:";
            // 
            // cmbPatient
            // 
            cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new System.Drawing.Point(250, 225);
            cmbPatient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new System.Drawing.Size(614, 36);
            cmbPatient.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDate.Location = new System.Drawing.Point(50, 308);
            lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(58, 28);
            lblDate.TabIndex = 5;
            lblDate.Text = "Дата:";
            // 
            // dtpDate
            // 
            dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDate.Location = new System.Drawing.Point(250, 302);
            dtpDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new System.Drawing.Size(247, 34);
            dtpDate.TabIndex = 6;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTime.Location = new System.Drawing.Point(533, 308);
            lblTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(73, 28);
            lblTime.TabIndex = 7;
            lblTime.Text = "Время:";
            // 
            // dtpTime
            // 
            dtpTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpTime.Location = new System.Drawing.Point(650, 302);
            dtpTime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dtpTime.Name = "dtpTime";
            dtpTime.ShowUpDown = true;
            dtpTime.Size = new System.Drawing.Size(214, 34);
            dtpTime.TabIndex = 8;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDuration.Location = new System.Drawing.Point(50, 385);
            lblDuration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new System.Drawing.Size(198, 28);
            lblDuration.TabIndex = 9;
            lblDuration.Text = "Длительность (мин):";
            // 
            // numDuration
            // 
            numDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numDuration.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            numDuration.Location = new System.Drawing.Point(317, 379);
            numDuration.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            numDuration.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new System.Drawing.Size(183, 34);
            numDuration.TabIndex = 10;
            numDuration.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNotes.Location = new System.Drawing.Point(50, 462);
            lblNotes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(133, 28);
            lblNotes.TabIndex = 11;
            lblNotes.Text = "Примечания:";
            // 
            // txtNotes
            // 
            txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNotes.Location = new System.Drawing.Point(250, 456);
            txtNotes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new System.Drawing.Size(614, 150);
            txtNotes.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.Black;
            btnSave.Location = new System.Drawing.Point(417, 654);
            btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(217, 77);
            btnSave.TabIndex = 13;
            btnSave.Text = "💾 Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(255, 87, 34);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(650, 654);
            btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(217, 77);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AppointmentEditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(917, 769);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(numDuration);
            Controls.Add(lblDuration);
            Controls.Add(dtpTime);
            Controls.Add(lblTime);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(cmbPatient);
            Controls.Add(lblPatient);
            Controls.Add(cmbDoctor);
            Controls.Add(lblDoctor);
            Controls.Add(panelTop);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppointmentEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Новая запись";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}