namespace course_medapp.Forms
{
    partial class PatientsForm
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
            panelTop = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            panelSearch = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            dgvPatients = new System.Windows.Forms.DataGridView();
            panelButtons = new System.Windows.Forms.Panel();
            lblTotal = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnViewHistory = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            panelTop.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
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
            panelTop.Size = new System.Drawing.Size(1924, 115);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            lblTitle.Location = new System.Drawing.Point(50, 29);
            lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(454, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Управление пациентами";
            // 
            // panelSearch
            // 
            panelSearch.BackColor = System.Drawing.Color.White;
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            panelSearch.Location = new System.Drawing.Point(0, 115);
            panelSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new System.Drawing.Size(1924, 154);
            panelSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.ForeColor = System.Drawing.Color.Gray;
            txtSearch.Location = new System.Drawing.Point(50, 54);
            txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(883, 38);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Поиск";
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.KeyPress += txtSearch_KeyPress;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.Black;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(950, 38);
            btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(367, 77);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.BackgroundColor = System.Drawing.Color.White;
            dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPatients.Location = new System.Drawing.Point(0, 269);
            dgvPatients.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dgvPatients.MultiSelect = false;
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.RowHeadersWidth = 62;
            dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new System.Drawing.Size(1924, 646);
            dgvPatients.TabIndex = 2;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            panelButtons.Controls.Add(lblTotal);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Controls.Add(btnViewHistory);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnEdit);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelButtons.Location = new System.Drawing.Point(0, 915);
            panelButtons.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new System.Drawing.Size(1924, 135);
            panelButtons.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTotal.ForeColor = System.Drawing.Color.White;
            lblTotal.Location = new System.Drawing.Point(1407, 48);
            lblTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(207, 30);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Всего пациентов: 0";
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(255, 87, 34);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(1660, 25);
            btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(250, 77);
            btnClose.TabIndex = 4;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnViewHistory.FlatAppearance.BorderSize = 0;
            btnViewHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnViewHistory.ForeColor = System.Drawing.Color.Black;
            btnViewHistory.Location = new System.Drawing.Point(1100, 29);
            btnViewHistory.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new System.Drawing.Size(267, 77);
            btnViewHistory.TabIndex = 3;
            btnViewHistory.Text = "История";
            btnViewHistory.UseVisualStyleBackColor = false;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.ForeColor = System.Drawing.Color.Black;
            btnDelete.Location = new System.Drawing.Point(750, 29);
            btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(267, 77);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEdit.ForeColor = System.Drawing.Color.Black;
            btnEdit.Location = new System.Drawing.Point(400, 29);
            btnEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(267, 77);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAdd.ForeColor = System.Drawing.Color.Black;
            btnAdd.Location = new System.Drawing.Point(50, 29);
            btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(267, 77);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // PatientsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 1050);
            Controls.Add(dgvPatients);
            Controls.Add(panelButtons);
            Controls.Add(panelSearch);
            Controls.Add(panelTop);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "PatientsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Пациенты";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotal;
    }
}