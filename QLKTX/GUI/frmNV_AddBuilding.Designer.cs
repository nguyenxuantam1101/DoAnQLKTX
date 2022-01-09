
namespace QLKTX.GUI
{
    partial class frmNV_AddBuilding
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuildingName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBuildingID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBuilding = new System.Windows.Forms.DataGridView();
            this.MaToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuildingName.BorderColor = System.Drawing.Color.Gray;
            this.txtBuildingName.BorderRadius = 5;
            this.txtBuildingName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuildingName.DefaultText = "";
            this.txtBuildingName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuildingName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuildingName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuildingName.DisabledState.Parent = this.txtBuildingName;
            this.txtBuildingName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuildingName.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtBuildingName.FocusedState.Parent = this.txtBuildingName;
            this.txtBuildingName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingName.ForeColor = System.Drawing.Color.Black;
            this.txtBuildingName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuildingName.HoverState.Parent = this.txtBuildingName;
            this.txtBuildingName.Location = new System.Drawing.Point(195, 152);
            this.txtBuildingName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.PasswordChar = '\0';
            this.txtBuildingName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBuildingName.PlaceholderText = "nhập tên tòa";
            this.txtBuildingName.SelectedText = "";
            this.txtBuildingName.ShadowDecoration.Parent = this.txtBuildingName;
            this.txtBuildingName.Size = new System.Drawing.Size(231, 39);
            this.txtBuildingName.TabIndex = 39;
            this.txtBuildingName.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtBuildingID
            // 
            this.txtBuildingID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuildingID.BorderColor = System.Drawing.Color.Gray;
            this.txtBuildingID.BorderRadius = 5;
            this.txtBuildingID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuildingID.DefaultText = "";
            this.txtBuildingID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuildingID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuildingID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuildingID.DisabledState.Parent = this.txtBuildingID;
            this.txtBuildingID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuildingID.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtBuildingID.FocusedState.Parent = this.txtBuildingID;
            this.txtBuildingID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingID.ForeColor = System.Drawing.Color.Black;
            this.txtBuildingID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuildingID.HoverState.Parent = this.txtBuildingID;
            this.txtBuildingID.Location = new System.Drawing.Point(195, 82);
            this.txtBuildingID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBuildingID.Name = "txtBuildingID";
            this.txtBuildingID.PasswordChar = '\0';
            this.txtBuildingID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBuildingID.PlaceholderText = "nhập mã tòa";
            this.txtBuildingID.SelectedText = "";
            this.txtBuildingID.ShadowDecoration.Parent = this.txtBuildingID;
            this.txtBuildingID.Size = new System.Drawing.Size(231, 38);
            this.txtBuildingID.TabIndex = 39;
            this.txtBuildingID.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnDelete.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(307, 265);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(103, 39);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã tòa";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(50, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên tòa";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox1.Controls.Add(this.btnUpdate);
            this.guna2GroupBox1.Controls.Add(this.txtBuildingName);
            this.guna2GroupBox1.Controls.Add(this.txtBuildingID);
            this.guna2GroupBox1.Controls.Add(this.btnDelete);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 1);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(503, 534);
            this.guna2GroupBox1.TabIndex = 41;
            this.guna2GroupBox1.Text = "Thông Tin Tòa";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.DisabledState.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnUpdate.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(73, 265);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(162, 39);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Thêm/Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 1;
            // 
            // dgvBuilding
            // 
            this.dgvBuilding.AllowUserToAddRows = false;
            this.dgvBuilding.AllowUserToDeleteRows = false;
            this.dgvBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuilding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuilding.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvBuilding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuilding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuilding.ColumnHeadersHeight = 40;
            this.dgvBuilding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaToa,
            this.TenToa});
            this.dgvBuilding.Location = new System.Drawing.Point(506, 1);
            this.dgvBuilding.Name = "dgvBuilding";
            this.dgvBuilding.ReadOnly = true;
            this.dgvBuilding.RowHeadersVisible = false;
            this.dgvBuilding.RowHeadersWidth = 51;
            this.dgvBuilding.RowTemplate.Height = 24;
            this.dgvBuilding.Size = new System.Drawing.Size(579, 534);
            this.dgvBuilding.TabIndex = 42;
            this.dgvBuilding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuilding_CellClick);
            // 
            // MaToa
            // 
            this.MaToa.HeaderText = "Mã tòa";
            this.MaToa.MinimumWidth = 6;
            this.MaToa.Name = "MaToa";
            this.MaToa.ReadOnly = true;
            // 
            // TenToa
            // 
            this.TenToa.HeaderText = "Tên tòa";
            this.TenToa.MinimumWidth = 6;
            this.TenToa.Name = "TenToa";
            this.TenToa.ReadOnly = true;
            // 
            // frmNV_AddBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 537);
            this.Controls.Add(this.dgvBuilding);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNV_AddBuilding";
            this.Text = "Thông Tin Tòa Nhà";
            this.Load += new System.EventHandler(this.frmNV_AddBuilding_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtBuildingName;
        private Guna.UI2.WinForms.Guna2TextBox txtBuildingID;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenToa;
    }
}