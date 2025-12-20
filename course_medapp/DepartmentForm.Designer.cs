namespace course_medapp.Forms
{
    partial class DepartmentsForm
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
            splitContainer = new System.Windows.Forms.SplitContainer();
            dgvDepartments = new System.Windows.Forms.DataGridView();
            panelRight = new System.Windows.Forms.Panel();
            lstDoctors = new System.Windows.Forms.ListBox();
            lblDoctors = new System.Windows.Forms.Label();
            panelBottom = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            lblTotal = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            panelRight.SuspendLayout();
            panelBottom.SuspendLayout();
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
            panelTop.Size = new System.Drawing.Size(1500, 115);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.Black;
            lblTitle.Location = new System.Drawing.Point(33, 29);
            lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(190, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Отделения";
            // 
            // splitContainer
            // 
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Location = new System.Drawing.Point(0, 115);
            splitContainer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(dgvDepartments);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelRight);
            splitContainer.Size = new System.Drawing.Size(1500, 808);
            splitContainer.SplitterDistance = 916;
            splitContainer.SplitterWidth = 7;
            splitContainer.TabIndex = 1;
            // 
            // dgvDepartments
            // 
            dgvDepartments.AllowUserToAddRows = false;
            dgvDepartments.AllowUserToDeleteRows = false;
            dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartments.BackgroundColor = System.Drawing.Color.White;
            dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDepartments.Location = new System.Drawing.Point(0, 0);
            dgvDepartments.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dgvDepartments.MultiSelect = false;
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersWidth = 62;
            dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.Size = new System.Drawing.Size(916, 808);
            dgvDepartments.TabIndex = 0;
            dgvDepartments.CellContentClick += dgvDepartments_CellContentClick;
            dgvDepartments.SelectionChanged += dgvDepartments_SelectionChanged;
            // 
            // panelRight
            // 
            panelRight.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            panelRight.Controls.Add(lstDoctors);
            panelRight.Controls.Add(lblDoctors);
            panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            panelRight.Location = new System.Drawing.Point(0, 0);
            panelRight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelRight.Name = "panelRight";
            panelRight.Padding = new System.Windows.Forms.Padding(17, 19, 17, 19);
            panelRight.Size = new System.Drawing.Size(577, 808);
            panelRight.TabIndex = 0;
            panelRight.Paint += panelRight_Paint;
            // 
            // lstDoctors
            // 
            lstDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            lstDoctors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstDoctors.FormattingEnabled = true;
            lstDoctors.ItemHeight = 28;
            lstDoctors.Location = new System.Drawing.Point(17, 67);
            lstDoctors.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            lstDoctors.Name = "lstDoctors";
            lstDoctors.Size = new System.Drawing.Size(543, 722);
            lstDoctors.TabIndex = 1;
            // 
            // lblDoctors
            // 
            lblDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            lblDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            lblDoctors.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDoctors.ForeColor = System.Drawing.Color.White;
            lblDoctors.Location = new System.Drawing.Point(17, 19);
            lblDoctors.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDoctors.Name = "lblDoctors";
            lblDoctors.Size = new System.Drawing.Size(543, 48);
            lblDoctors.TabIndex = 0;
            lblDoctors.Text = "Врачи отделения:";
            lblDoctors.Click += lblDoctors_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = System.Drawing.Color.White;
            panelBottom.Controls.Add(btnClose);
            panelBottom.Controls.Add(lblTotal);
            panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottom.Location = new System.Drawing.Point(0, 923);
            panelBottom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new System.Drawing.Size(1500, 115);
            panelBottom.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(255, 87, 34);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(1283, 19);
            btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(167, 77);
            btnClose.TabIndex = 1;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTotal.Location = new System.Drawing.Point(33, 38);
            lblTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(207, 30);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Всего отделений: 0";
            // 
            // DepartmentsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1500, 1038);
            Controls.Add(splitContainer);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "DepartmentsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Отделения";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            panelRight.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblDoctors;
        private System.Windows.Forms.ListBox lstDoctors;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClose;
    }
}