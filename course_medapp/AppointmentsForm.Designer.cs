namespace course_medapp.Forms
{
    partial class AppointmentsForm
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
            panelFilter = new System.Windows.Forms.Panel();
            cmbFilter = new System.Windows.Forms.ComboBox();
            lblFilter = new System.Windows.Forms.Label();
            dgvAppointments = new System.Windows.Forms.DataGridView();
            panelButtons = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            btnComplete = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            lblTotal = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
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
            panelTop.Size = new System.Drawing.Size(1667, 115);
            panelTop.TabIndex = 0;
            panelTop.Paint += panelTop_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.Black;
            lblTitle.Location = new System.Drawing.Point(33, 29);
            lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(319, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Записи на приём";
            lblTitle.Click += lblTitle_Click;
            // 
            // panelFilter
            // 
            panelFilter.BackColor = System.Drawing.Color.White;
            panelFilter.Controls.Add(cmbFilter);
            panelFilter.Controls.Add(lblFilter);
            panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            panelFilter.Location = new System.Drawing.Point(0, 115);
            panelFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new System.Drawing.Size(1667, 115);
            panelFilter.TabIndex = 1;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Все записи", "Запланированные", "Завершённые", "Отменённые", "Сегодня" });
            cmbFilter.Location = new System.Drawing.Point(167, 33);
            cmbFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new System.Drawing.Size(414, 38);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFilter.Location = new System.Drawing.Point(33, 38);
            lblFilter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new System.Drawing.Size(92, 30);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Фильтр:";
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAppointments.Location = new System.Drawing.Point(0, 230);
            dgvAppointments.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 62;
            dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new System.Drawing.Size(1667, 685);
            dgvAppointments.TabIndex = 2;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Controls.Add(btnComplete);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(lblTotal);
            panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelButtons.Location = new System.Drawing.Point(0, 915);
            panelButtons.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new System.Drawing.Size(1667, 135);
            panelButtons.TabIndex = 3;
            panelButtons.Paint += panelButtons_Paint;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(255, 87, 34);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(1450, 29);
            btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(183, 77);
            btnClose.TabIndex = 4;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnComplete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnComplete.ForeColor = System.Drawing.Color.Black;
            btnComplete.Location = new System.Drawing.Point(483, 29);
            btnComplete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new System.Drawing.Size(217, 77);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "✔️ Завершить";
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.Black;
            btnCancel.Location = new System.Drawing.Point(233, 29);
            btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(217, 77);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "❌ Отменить";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAdd.ForeColor = System.Drawing.Color.Black;
            btnAdd.Location = new System.Drawing.Point(33, 29);
            btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(167, 77);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "➕ Создать";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotal.ForeColor = System.Drawing.Color.White;
            lblTotal.Location = new System.Drawing.Point(800, 48);
            lblTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(180, 30);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Всего записей: 0";
            lblTotal.Click += lblTotal_Click;
            // 
            // AppointmentsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1667, 1050);
            Controls.Add(dgvAppointments);
            Controls.Add(panelButtons);
            Controls.Add(panelFilter);
            Controls.Add(panelTop);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "AppointmentsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Записи на приём";
            Load += AppointmentsForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            ResumeLayout(false);
        }

        private void AppointmentsForm_Load(object sender, System.EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotal;
    }
}