
namespace QLKTX.GUI
{
    partial class frmNV_ListAccount
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbViewListAcc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbQuyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchAcc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvQLAccount = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "Xem DS Theo";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnUpdate.Location = new System.Drawing.Point(58, 458);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(167, 39);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox1.Controls.Add(this.cmbViewListAcc);
            this.guna2GroupBox1.Controls.Add(this.cmbQuyen);
            this.guna2GroupBox1.Controls.Add(this.txtSearchAcc);
            this.guna2GroupBox1.Controls.Add(this.txtAccount);
            this.guna2GroupBox1.Controls.Add(this.txtFullName);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.btnDelete);
            this.guna2GroupBox1.Controls.Add(this.btnUpdate);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(554, 642);
            this.guna2GroupBox1.TabIndex = 15;
            this.guna2GroupBox1.Text = "Thông Tin Tài Khoản";
            // 
            // cmbViewListAcc
            // 
            this.cmbViewListAcc.BackColor = System.Drawing.Color.Transparent;
            this.cmbViewListAcc.BorderColor = System.Drawing.Color.Gray;
            this.cmbViewListAcc.BorderRadius = 5;
            this.cmbViewListAcc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbViewListAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViewListAcc.FocusedColor = System.Drawing.Color.Empty;
            this.cmbViewListAcc.FocusedState.Parent = this.cmbViewListAcc;
            this.cmbViewListAcc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViewListAcc.ForeColor = System.Drawing.Color.Black;
            this.cmbViewListAcc.FormattingEnabled = true;
            this.cmbViewListAcc.HoverState.Parent = this.cmbViewListAcc;
            this.cmbViewListAcc.ItemHeight = 30;
            this.cmbViewListAcc.Items.AddRange(new object[] {
            "Nhân Viên",
            "Sinh Viên"});
            this.cmbViewListAcc.ItemsAppearance.Parent = this.cmbViewListAcc;
            this.cmbViewListAcc.Location = new System.Drawing.Point(251, 80);
            this.cmbViewListAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbViewListAcc.Name = "cmbViewListAcc";
            this.cmbViewListAcc.ShadowDecoration.Parent = this.cmbViewListAcc;
            this.cmbViewListAcc.Size = new System.Drawing.Size(228, 36);
            this.cmbViewListAcc.StartIndex = 0;
            this.cmbViewListAcc.TabIndex = 45;
            this.cmbViewListAcc.TextOffset = new System.Drawing.Point(8, 0);
            this.cmbViewListAcc.SelectedIndexChanged += new System.EventHandler(this.cmbViewListAcc_SelectedIndexChanged);
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.BackColor = System.Drawing.Color.Transparent;
            this.cmbQuyen.BorderColor = System.Drawing.Color.Gray;
            this.cmbQuyen.BorderRadius = 5;
            this.cmbQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuyen.FocusedColor = System.Drawing.Color.Empty;
            this.cmbQuyen.FocusedState.Parent = this.cmbQuyen;
            this.cmbQuyen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuyen.ForeColor = System.Drawing.Color.Black;
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.HoverState.Parent = this.cmbQuyen;
            this.cmbQuyen.ItemHeight = 30;
            this.cmbQuyen.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGE",
            "USER"});
            this.cmbQuyen.ItemsAppearance.Parent = this.cmbQuyen;
            this.cmbQuyen.Location = new System.Drawing.Point(248, 276);
            this.cmbQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.ShadowDecoration.Parent = this.cmbQuyen;
            this.cmbQuyen.Size = new System.Drawing.Size(231, 36);
            this.cmbQuyen.TabIndex = 42;
            this.cmbQuyen.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtSearchAcc
            // 
            this.txtSearchAcc.BorderColor = System.Drawing.Color.Gray;
            this.txtSearchAcc.BorderRadius = 5;
            this.txtSearchAcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAcc.DefaultText = "";
            this.txtSearchAcc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAcc.DisabledState.Parent = this.txtSearchAcc;
            this.txtSearchAcc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAcc.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtSearchAcc.FocusedState.Parent = this.txtSearchAcc;
            this.txtSearchAcc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAcc.ForeColor = System.Drawing.Color.Black;
            this.txtSearchAcc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAcc.HoverState.Parent = this.txtSearchAcc;
            this.txtSearchAcc.Location = new System.Drawing.Point(248, 343);
            this.txtSearchAcc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearchAcc.Name = "txtSearchAcc";
            this.txtSearchAcc.PasswordChar = '\0';
            this.txtSearchAcc.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchAcc.PlaceholderText = "Tìm kiếm tài khoản";
            this.txtSearchAcc.SelectedText = "";
            this.txtSearchAcc.ShadowDecoration.Parent = this.txtSearchAcc;
            this.txtSearchAcc.Size = new System.Drawing.Size(231, 38);
            this.txtSearchAcc.TabIndex = 41;
            this.txtSearchAcc.TextOffset = new System.Drawing.Point(8, 0);
            this.txtSearchAcc.TextChanged += new System.EventHandler(this.txtSearchAcc_TextChanged);
            // 
            // txtAccount
            // 
            this.txtAccount.BorderColor = System.Drawing.Color.Gray;
            this.txtAccount.BorderRadius = 5;
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.DefaultText = "";
            this.txtAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccount.DisabledState.Parent = this.txtAccount;
            this.txtAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccount.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtAccount.FocusedState.Parent = this.txtAccount;
            this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.ForeColor = System.Drawing.Color.Black;
            this.txtAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccount.HoverState.Parent = this.txtAccount;
            this.txtAccount.Location = new System.Drawing.Point(251, 205);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAccount.PlaceholderText = "Tên đăng nhập";
            this.txtAccount.SelectedText = "";
            this.txtAccount.ShadowDecoration.Parent = this.txtAccount;
            this.txtAccount.Size = new System.Drawing.Size(231, 38);
            this.txtAccount.TabIndex = 41;
            this.txtAccount.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtFullName
            // 
            this.txtFullName.BorderColor = System.Drawing.Color.Gray;
            this.txtFullName.BorderRadius = 5;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.Parent = this.txtFullName;
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtFullName.FocusedState.Parent = this.txtFullName;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.HoverState.Parent = this.txtFullName;
            this.txtFullName.Location = new System.Drawing.Point(251, 140);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFullName.PlaceholderText = "Họ tên";
            this.txtFullName.SelectedText = "";
            this.txtFullName.ShadowDecoration.Parent = this.txtFullName;
            this.txtFullName.Size = new System.Drawing.Size(231, 38);
            this.txtFullName.TabIndex = 41;
            this.txtFullName.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnDelete.Location = new System.Drawing.Point(301, 458);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(167, 39);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(83, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(80, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(57, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm Kiếm";
            // 
            // dgvQLAccount
            // 
            this.dgvQLAccount.AllowUserToAddRows = false;
            this.dgvQLAccount.AllowUserToDeleteRows = false;
            this.dgvQLAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvQLAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLAccount.ColumnHeadersHeight = 40;
            this.dgvQLAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgvQLAccount.Location = new System.Drawing.Point(554, 0);
            this.dgvQLAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQLAccount.Name = "dgvQLAccount";
            this.dgvQLAccount.ReadOnly = true;
            this.dgvQLAccount.RowHeadersVisible = false;
            this.dgvQLAccount.RowHeadersWidth = 51;
            this.dgvQLAccount.Size = new System.Drawing.Size(754, 641);
            this.dgvQLAccount.TabIndex = 13;
            this.dgvQLAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLAccount_CellClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Họ Tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Đăng Nhập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quyền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmNV_ListAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 642);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgvQLAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNV_ListAccount";
            this.Text = "Danh Sách Tài Khoản";
            this.Load += new System.EventHandler(this.frmNV_ListAccount_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvQLAccount;
        private Guna.UI2.WinForms.Guna2ComboBox cmbQuyen;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAcc;
        private Guna.UI2.WinForms.Guna2TextBox txtAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbViewListAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}