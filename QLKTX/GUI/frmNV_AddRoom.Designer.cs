
namespace QLKTX.GUI
{
    partial class frmNV_AddRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbToa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTrangThaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtGiaPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Gi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.TrangThaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
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
            this.btnDelete.Location = new System.Drawing.Point(377, 530);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(117, 39);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(77, 530);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(117, 39);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(224, 530);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(117, 39);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(41, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tòa";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox1.Controls.Add(this.txtFind);
            this.guna2GroupBox1.Controls.Add(this.cmbToa);
            this.guna2GroupBox1.Controls.Add(this.cmbTrangThaiPhong);
            this.guna2GroupBox1.Controls.Add(this.cmbLoaiPhong);
            this.guna2GroupBox1.Controls.Add(this.txtGiaPhong);
            this.guna2GroupBox1.Controls.Add(this.txtRoomName);
            this.guna2GroupBox1.Controls.Add(this.txtRoomID);
            this.guna2GroupBox1.Controls.Add(this.btnDelete);
            this.guna2GroupBox1.Controls.Add(this.btnAdd);
            this.guna2GroupBox1.Controls.Add(this.btnUpdate);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.Gi);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox1.Location = new System.Drawing.Point(-1, 0);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(567, 684);
            this.guna2GroupBox1.TabIndex = 38;
            this.guna2GroupBox1.Text = "Thông Tin Phòng";
            // 
            // txtFind
            // 
            this.txtFind.AutoRoundedCorners = true;
            this.txtFind.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.txtFind.BorderRadius = 25;
            this.txtFind.BorderThickness = 2;
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.Parent = this.txtFind;
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.FocusedState.Parent = this.txtFind;
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.HoverState.Parent = this.txtFind;
            this.txtFind.Location = new System.Drawing.Point(96, 604);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFind.PlaceholderText = "Nhập Để Tìm Kiếm";
            this.txtFind.SelectedText = "";
            this.txtFind.ShadowDecoration.Parent = this.txtFind;
            this.txtFind.Size = new System.Drawing.Size(369, 53);
            this.txtFind.TabIndex = 0;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // cmbToa
            // 
            this.cmbToa.BackColor = System.Drawing.Color.Transparent;
            this.cmbToa.BorderColor = System.Drawing.Color.Gray;
            this.cmbToa.BorderRadius = 5;
            this.cmbToa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbToa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToa.FocusedColor = System.Drawing.Color.Empty;
            this.cmbToa.FocusedState.Parent = this.cmbToa;
            this.cmbToa.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cmbToa.ForeColor = System.Drawing.Color.Black;
            this.cmbToa.FormattingEnabled = true;
            this.cmbToa.HoverState.Parent = this.cmbToa;
            this.cmbToa.ItemHeight = 30;
            this.cmbToa.ItemsAppearance.Parent = this.cmbToa;
            this.cmbToa.Location = new System.Drawing.Point(296, 438);
            this.cmbToa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbToa.Name = "cmbToa";
            this.cmbToa.ShadowDecoration.Parent = this.cmbToa;
            this.cmbToa.Size = new System.Drawing.Size(198, 36);
            this.cmbToa.TabIndex = 40;
            this.cmbToa.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // cmbTrangThaiPhong
            // 
            this.cmbTrangThaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cmbTrangThaiPhong.BorderColor = System.Drawing.Color.Gray;
            this.cmbTrangThaiPhong.BorderRadius = 5;
            this.cmbTrangThaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTrangThaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThaiPhong.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTrangThaiPhong.FocusedState.Parent = this.cmbTrangThaiPhong;
            this.cmbTrangThaiPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cmbTrangThaiPhong.ForeColor = System.Drawing.Color.Black;
            this.cmbTrangThaiPhong.FormattingEnabled = true;
            this.cmbTrangThaiPhong.HoverState.Parent = this.cmbTrangThaiPhong;
            this.cmbTrangThaiPhong.ItemHeight = 30;
            this.cmbTrangThaiPhong.Items.AddRange(new object[] {
            "Còn Trống",
            "Đã Đủ",
            "Bảo Trì"});
            this.cmbTrangThaiPhong.ItemsAppearance.Parent = this.cmbTrangThaiPhong;
            this.cmbTrangThaiPhong.Location = new System.Drawing.Point(296, 365);
            this.cmbTrangThaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTrangThaiPhong.Name = "cmbTrangThaiPhong";
            this.cmbTrangThaiPhong.ShadowDecoration.Parent = this.cmbTrangThaiPhong;
            this.cmbTrangThaiPhong.Size = new System.Drawing.Size(198, 36);
            this.cmbTrangThaiPhong.TabIndex = 40;
            this.cmbTrangThaiPhong.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiPhong.BorderColor = System.Drawing.Color.Gray;
            this.cmbLoaiPhong.BorderRadius = 5;
            this.cmbLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPhong.FocusedColor = System.Drawing.Color.Empty;
            this.cmbLoaiPhong.FocusedState.Parent = this.cmbLoaiPhong;
            this.cmbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cmbLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.HoverState.Parent = this.cmbLoaiPhong;
            this.cmbLoaiPhong.ItemHeight = 30;
            this.cmbLoaiPhong.Items.AddRange(new object[] {
            "Phòng 2",
            "Phòng 4",
            "Phòng 6",
            "Phòng 8"});
            this.cmbLoaiPhong.ItemsAppearance.Parent = this.cmbLoaiPhong;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(296, 217);
            this.cmbLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.ShadowDecoration.Parent = this.cmbLoaiPhong;
            this.cmbLoaiPhong.Size = new System.Drawing.Size(198, 36);
            this.cmbLoaiPhong.TabIndex = 40;
            this.cmbLoaiPhong.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.BorderColor = System.Drawing.Color.Gray;
            this.txtGiaPhong.BorderRadius = 5;
            this.txtGiaPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaPhong.DefaultText = "";
            this.txtGiaPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaPhong.DisabledState.Parent = this.txtGiaPhong;
            this.txtGiaPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaPhong.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtGiaPhong.FocusedState.Parent = this.txtGiaPhong;
            this.txtGiaPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtGiaPhong.ForeColor = System.Drawing.Color.Black;
            this.txtGiaPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaPhong.HoverState.Parent = this.txtGiaPhong;
            this.txtGiaPhong.Location = new System.Drawing.Point(296, 289);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.PasswordChar = '\0';
            this.txtGiaPhong.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtGiaPhong.PlaceholderText = "Nhập giá phòng";
            this.txtGiaPhong.SelectedText = "";
            this.txtGiaPhong.ShadowDecoration.Parent = this.txtGiaPhong;
            this.txtGiaPhong.Size = new System.Drawing.Size(198, 39);
            this.txtGiaPhong.TabIndex = 39;
            this.txtGiaPhong.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtRoomName
            // 
            this.txtRoomName.BorderColor = System.Drawing.Color.Gray;
            this.txtRoomName.BorderRadius = 5;
            this.txtRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomName.DefaultText = "";
            this.txtRoomName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomName.DisabledState.Parent = this.txtRoomName;
            this.txtRoomName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomName.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtRoomName.FocusedState.Parent = this.txtRoomName;
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtRoomName.ForeColor = System.Drawing.Color.Black;
            this.txtRoomName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomName.HoverState.Parent = this.txtRoomName;
            this.txtRoomName.Location = new System.Drawing.Point(296, 139);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PasswordChar = '\0';
            this.txtRoomName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRoomName.PlaceholderText = "Nhập tên phòng";
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.ShadowDecoration.Parent = this.txtRoomName;
            this.txtRoomName.Size = new System.Drawing.Size(198, 39);
            this.txtRoomName.TabIndex = 39;
            this.txtRoomName.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtRoomID
            // 
            this.txtRoomID.BorderColor = System.Drawing.Color.Gray;
            this.txtRoomID.BorderRadius = 5;
            this.txtRoomID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomID.DefaultText = "";
            this.txtRoomID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomID.DisabledState.Parent = this.txtRoomID;
            this.txtRoomID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomID.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtRoomID.FocusedState.Parent = this.txtRoomID;
            this.txtRoomID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomID.ForeColor = System.Drawing.Color.Black;
            this.txtRoomID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomID.HoverState.Parent = this.txtRoomID;
            this.txtRoomID.Location = new System.Drawing.Point(296, 65);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.PasswordChar = '\0';
            this.txtRoomID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRoomID.PlaceholderText = "Nhập mã phòng";
            this.txtRoomID.SelectedText = "";
            this.txtRoomID.ShadowDecoration.Parent = this.txtRoomID;
            this.txtRoomID.Size = new System.Drawing.Size(198, 38);
            this.txtRoomID.TabIndex = 39;
            this.txtRoomID.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phòng";
            // 
            // Gi
            // 
            this.Gi.AutoSize = true;
            this.Gi.ForeColor = System.Drawing.Color.Black;
            this.Gi.Location = new System.Drawing.Point(41, 300);
            this.Gi.Name = "Gi";
            this.Gi.Size = new System.Drawing.Size(109, 28);
            this.Gi.TabIndex = 1;
            this.Gi.Text = "Giá Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trạng thái phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại phòng";
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá Phòng";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Còn Trống";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Loại Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // TenToa
            // 
            this.TenToa.HeaderText = "Tên phòng";
            this.TenToa.MinimumWidth = 6;
            this.TenToa.Name = "TenToa";
            this.TenToa.ReadOnly = true;
            // 
            // MaToa
            // 
            this.MaToa.HeaderText = "Mã phòng";
            this.MaToa.MinimumWidth = 6;
            this.MaToa.Name = "MaToa";
            this.MaToa.ReadOnly = true;
            // 
            // toa
            // 
            this.toa.HeaderText = "Tòa";
            this.toa.MinimumWidth = 6;
            this.toa.Name = "toa";
            this.toa.ReadOnly = true;
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoom.ColumnHeadersHeight = 40;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toa,
            this.MaToa,
            this.TenToa,
            this.Column1,
            this.Column2,
            this.gia,
            this.TrangThaiPhong});
            this.dgvRoom.Location = new System.Drawing.Point(566, 0);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersVisible = false;
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(673, 684);
            this.dgvRoom.TabIndex = 37;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // TrangThaiPhong
            // 
            this.TrangThaiPhong.HeaderText = "Trạng thái phòng";
            this.TrangThaiPhong.MinimumWidth = 6;
            this.TrangThaiPhong.Name = "TrangThaiPhong";
            this.TrangThaiPhong.ReadOnly = true;
            // 
            // frmNV_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 685);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgvRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNV_AddRoom";
            this.Text = "Thông Tin Phòng Ở";
            this.Load += new System.EventHandler(this.frmNV_AddRoom_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Gi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn toa;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtFind;
        private Guna.UI2.WinForms.Guna2ComboBox cmbToa;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTrangThaiPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomName;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomID;
    }
}