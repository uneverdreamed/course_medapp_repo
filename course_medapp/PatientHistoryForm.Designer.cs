namespace course_medapp.Forms
{
    public partial class PatientHistoryForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPatientInfo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.lblNoHistory = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblHistoryCount = new System.Windows.Forms.Label();
            this.tabPageMedCard = new System.Windows.Forms.TabPage();
            this.dgvMedicalRecords = new System.Windows.Forms.DataGridView();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtChronicDiseases = new System.Windows.Forms.TextBox();
            this.lblChronicDiseases = new System.Windows.Forms.Label();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.tabPageMedCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalRecords)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 60);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "История посещений";
            // 
            // lblPatientInfo
            // 
            this.lblPatientInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblPatientInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatientInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPatientInfo.Location = new System.Drawing.Point(0, 60);
            this.lblPatientInfo.Name = "lblPatientInfo";
            this.lblPatientInfo.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.lblPatientInfo.Size = new System.Drawing.Size(900, 40);
            this.lblPatientInfo.TabIndex = 1;
            this.lblPatientInfo.Text = "Пациент: ";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHistory);
            this.tabControl.Controls.Add(this.tabPageMedCard);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 100);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(900, 380);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.lblNoHistory);
            this.tabPageHistory.Controls.Add(this.dgvHistory);
            this.tabPageHistory.Controls.Add(this.lblHistoryCount);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 26);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(892, 350);
            this.tabPageHistory.TabIndex = 0;
            this.tabPageHistory.Text = "История визитов";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // lblNoHistory
            // 
            this.lblNoHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoHistory.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblNoHistory.Location = new System.Drawing.Point(3, 28);
            this.lblNoHistory.Name = "lblNoHistory";
            this.lblNoHistory.Size = new System.Drawing.Size(886, 319);
            this.lblNoHistory.TabIndex = 2;
            this.lblNoHistory.Text = "У пациента пока нет истории посещений";
            this.lblNoHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoHistory.Visible = false;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(3, 28);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(886, 319);
            this.dgvHistory.TabIndex = 1;
            // 
            // lblHistoryCount
            // 
            this.lblHistoryCount.BackColor = System.Drawing.Color.White;
            this.lblHistoryCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistoryCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHistoryCount.Location = new System.Drawing.Point(3, 3);
            this.lblHistoryCount.Name = "lblHistoryCount";
            this.lblHistoryCount.Padding = new System.Windows.Forms.Padding(5);
            this.lblHistoryCount.Size = new System.Drawing.Size(886, 25);
            this.lblHistoryCount.TabIndex = 0;
            this.lblHistoryCount.Text = "Всего посещений: 0";
            // 
            // tabPageMedCard
            // 
            this.tabPageMedCard.Controls.Add(this.dgvMedicalRecords);
            this.tabPageMedCard.Controls.Add(this.groupBoxInfo);
            this.tabPageMedCard.Location = new System.Drawing.Point(4, 26);
            this.tabPageMedCard.Name = "tabPageMedCard";
            this.tabPageMedCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedCard.Size = new System.Drawing.Size(892, 350);
            this.tabPageMedCard.TabIndex = 1;
            this.tabPageMedCard.Text = "Медицинская карта";
            this.tabPageMedCard.UseVisualStyleBackColor = true;
            // 
            // dgvMedicalRecords
            // 
            this.dgvMedicalRecords.AllowUserToAddRows = false;
            this.dgvMedicalRecords.AllowUserToDeleteRows = false;
            this.dgvMedicalRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicalRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicalRecords.Location = new System.Drawing.Point(3, 143);
            this.dgvMedicalRecords.Name = "dgvMedicalRecords";
            this.dgvMedicalRecords.ReadOnly = true;
            this.dgvMedicalRecords.Size = new System.Drawing.Size(886, 204);
            this.dgvMedicalRecords.TabIndex = 1;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.txtChronicDiseases);
            this.groupBoxInfo.Controls.Add(this.lblChronicDiseases);
            this.groupBoxInfo.Controls.Add(this.txtAllergies);
            this.groupBoxInfo.Controls.Add(this.lblAllergies);
            this.groupBoxInfo.Controls.Add(this.txtBloodType);
            this.groupBoxInfo.Controls.Add(this.lblBloodType);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(886, 140);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Общая информация";
            // 
            // txtChronicDiseases
            // 
            this.txtChronicDiseases.Location = new System.Drawing.Point(180, 95);
            this.txtChronicDiseases.Name = "txtChronicDiseases";
            this.txtChronicDiseases.ReadOnly = true;
            this.txtChronicDiseases.Size = new System.Drawing.Size(680, 25);
            this.txtChronicDiseases.TabIndex = 5;
            // 
            // lblChronicDiseases
            // 
            this.lblChronicDiseases.AutoSize = true;
            this.lblChronicDiseases.Location = new System.Drawing.Point(20, 98);
            this.lblChronicDiseases.Name = "lblChronicDiseases";
            this.lblChronicDiseases.Size = new System.Drawing.Size(178, 19);
            this.lblChronicDiseases.TabIndex = 4;
            this.lblChronicDiseases.Text = "Хронические заболевания:";
            // 
            // txtAllergies
            // 
            this.txtAllergies.Location = new System.Drawing.Point(180, 62);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.ReadOnly = true;
            this.txtAllergies.Size = new System.Drawing.Size(680, 25);
            this.txtAllergies.TabIndex = 3;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(20, 65);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(75, 19);
            this.lblAllergies.TabIndex = 2;
            this.lblAllergies.Text = "Аллергии:";
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(180, 29);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.ReadOnly = true;
            this.txtBloodType.Size = new System.Drawing.Size(150, 25);
            this.txtBloodType.TabIndex = 1;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(20, 32);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(104, 19);
            this.lblBloodType.TabIndex = 0;
            this.lblBloodType.Text = "Группа крови:";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 480);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(900, 60);
            this.panelBottom.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(770, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PatientHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblPatientInfo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Name = "PatientHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История пациента";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.tabPageMedCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalRecords)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblHistoryCount;
        private System.Windows.Forms.Label lblNoHistory;
        private System.Windows.Forms.TabPage tabPageMedCard;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Label lblChronicDiseases;
        private System.Windows.Forms.TextBox txtChronicDiseases;
        private System.Windows.Forms.DataGridView dgvMedicalRecords;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
    }
}