
namespace QLKTX.GUI
{
    partial class frmSV_InfoBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDienNuoc = new System.Windows.Forms.TabPage();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvSVCTDienNuoc = new System.Windows.Forms.DataGridView();
            this.TENDICHVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHISOSUDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDienNuoc = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvSVDienNuoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLePhi = new System.Windows.Forms.TabPage();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbHanCuoi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbHoTenSV = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSoThang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnGiaHan = new Guna.UI2.WinForms.Guna2Button();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDienNuoc.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVCTDienNuoc)).BeginInit();
            this.gbDienNuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVDienNuoc)).BeginInit();
            this.tabLePhi.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDienNuoc);
            this.tabControl1.Controls.Add(this.tabLePhi);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1260, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDienNuoc
            // 
            this.tabDienNuoc.Controls.Add(this.guna2GroupBox3);
            this.tabDienNuoc.Controls.Add(this.gbDienNuoc);
            this.tabDienNuoc.Location = new System.Drawing.Point(4, 32);
            this.tabDienNuoc.Name = "tabDienNuoc";
            this.tabDienNuoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabDienNuoc.Size = new System.Drawing.Size(1252, 631);
            this.tabDienNuoc.TabIndex = 0;
            this.tabDienNuoc.Text = "Hóa đơn điện nước";
            this.tabDienNuoc.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox3.Controls.Add(this.dgvSVCTDienNuoc);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox3.Location = new System.Drawing.Point(766, 0);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(490, 635);
            this.guna2GroupBox3.TabIndex = 37;
            this.guna2GroupBox3.Text = "Chi tiết hóa đơn";
            // 
            // dgvSVCTDienNuoc
            // 
            this.dgvSVCTDienNuoc.AllowUserToAddRows = false;
            this.dgvSVCTDienNuoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSVCTDienNuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSVCTDienNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSVCTDienNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSVCTDienNuoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSVCTDienNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSVCTDienNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENDICHVU,
            this.CHISOSUDUNG,
            this.DONGIA,
            this.THANHTIEN});
            this.dgvSVCTDienNuoc.Location = new System.Drawing.Point(1, 40);
            this.dgvSVCTDienNuoc.Name = "dgvSVCTDienNuoc";
            this.dgvSVCTDienNuoc.ReadOnly = true;
            this.dgvSVCTDienNuoc.RowHeadersVisible = false;
            this.dgvSVCTDienNuoc.RowHeadersWidth = 51;
            this.dgvSVCTDienNuoc.RowTemplate.Height = 24;
            this.dgvSVCTDienNuoc.Size = new System.Drawing.Size(485, 591);
            this.dgvSVCTDienNuoc.TabIndex = 37;
            // 
            // TENDICHVU
            // 
            this.TENDICHVU.HeaderText = "Tên Dịch Vụ";
            this.TENDICHVU.MinimumWidth = 6;
            this.TENDICHVU.Name = "TENDICHVU";
            this.TENDICHVU.ReadOnly = true;
            // 
            // CHISOSUDUNG
            // 
            this.CHISOSUDUNG.HeaderText = "Chỉ Số Sử Dụng";
            this.CHISOSUDUNG.MinimumWidth = 6;
            this.CHISOSUDUNG.Name = "CHISOSUDUNG";
            this.CHISOSUDUNG.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // gbDienNuoc
            // 
            this.gbDienNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDienNuoc.Controls.Add(this.dgvSVDienNuoc);
            this.gbDienNuoc.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.gbDienNuoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gbDienNuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbDienNuoc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbDienNuoc.Location = new System.Drawing.Point(3, 0);
            this.gbDienNuoc.Name = "gbDienNuoc";
            this.gbDienNuoc.ShadowDecoration.Parent = this.gbDienNuoc;
            this.gbDienNuoc.Size = new System.Drawing.Size(767, 635);
            this.gbDienNuoc.TabIndex = 36;
            this.gbDienNuoc.Text = "Hóa đơn";
            // 
            // dgvSVDienNuoc
            // 
            this.dgvSVDienNuoc.AllowUserToAddRows = false;
            this.dgvSVDienNuoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvSVDienNuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSVDienNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSVDienNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSVDienNuoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSVDienNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSVDienNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvSVDienNuoc.Location = new System.Drawing.Point(-3, 40);
            this.dgvSVDienNuoc.Name = "dgvSVDienNuoc";
            this.dgvSVDienNuoc.ReadOnly = true;
            this.dgvSVDienNuoc.RowHeadersVisible = false;
            this.dgvSVDienNuoc.RowHeadersWidth = 51;
            this.dgvSVDienNuoc.RowTemplate.Height = 24;
            this.dgvSVDienNuoc.Size = new System.Drawing.Size(769, 591);
            this.dgvSVDienNuoc.TabIndex = 38;
            this.dgvSVDienNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSVDienNuoc_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã HĐ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Người Lập HĐ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tòa";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Phòng";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày Lập";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tổng Tiền";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // tabLePhi
            // 
            this.tabLePhi.Controls.Add(this.guna2GroupBox2);
            this.tabLePhi.Location = new System.Drawing.Point(4, 32);
            this.tabLePhi.Name = "tabLePhi";
            this.tabLePhi.Padding = new System.Windows.Forms.Padding(3);
            this.tabLePhi.Size = new System.Drawing.Size(1252, 631);
            this.tabLePhi.TabIndex = 1;
            this.tabLePhi.Text = "Hóa đơn lệ phí";
            this.tabLePhi.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.Controls.Add(this.panel2);
            this.guna2GroupBox2.Controls.Add(this.panel1);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox2.Location = new System.Drawing.Point(-4, 0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(1256, 631);
            this.guna2GroupBox2.TabIndex = 36;
            this.guna2GroupBox2.Text = "Thông Tin Hóa Đơn Lệ Phí";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lbTrangThai);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lbTongTien);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lbCCCD);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbHanCuoi);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lbHoTenSV);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(4, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 589);
            this.panel1.TabIndex = 70;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lbTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.Black;
            this.lbTrangThai.Location = new System.Drawing.Point(306, 283);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(106, 28);
            this.lbTrangThai.TabIndex = 59;
            this.lbTrangThai.Text = "Trạng Thái";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(113, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 28);
            this.label15.TabIndex = 60;
            this.label15.Text = "Trạng Thái:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Black;
            this.lbTongTien.Location = new System.Drawing.Point(306, 239);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(104, 28);
            this.lbTongTien.TabIndex = 61;
            this.lbTongTien.Text = "Tổng Tiền";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(118, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 28);
            this.label14.TabIndex = 62;
            this.label14.Text = "Tổng Tiền:";
            // 
            // lbCCCD
            // 
            this.lbCCCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lbCCCD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCCCD.ForeColor = System.Drawing.Color.Black;
            this.lbCCCD.Location = new System.Drawing.Point(306, 151);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(60, 28);
            this.lbCCCD.TabIndex = 63;
            this.lbCCCD.Text = "CCCD";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(164, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 28);
            this.label10.TabIndex = 64;
            this.label10.Text = "CCCD:";
            // 
            // lbHanCuoi
            // 
            this.lbHanCuoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHanCuoi.AutoSize = true;
            this.lbHanCuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lbHanCuoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHanCuoi.ForeColor = System.Drawing.Color.Black;
            this.lbHanCuoi.Location = new System.Drawing.Point(306, 194);
            this.lbHanCuoi.Name = "lbHanCuoi";
            this.lbHanCuoi.Size = new System.Drawing.Size(96, 28);
            this.lbHanCuoi.TabIndex = 65;
            this.lbHanCuoi.Text = "Hạn Cuối";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(127, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 28);
            this.label13.TabIndex = 66;
            this.label13.Text = "Hạn Cuối:";
            // 
            // lbHoTenSV
            // 
            this.lbHoTenSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHoTenSV.AutoSize = true;
            this.lbHoTenSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lbHoTenSV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTenSV.ForeColor = System.Drawing.Color.Black;
            this.lbHoTenSV.Location = new System.Drawing.Point(306, 106);
            this.lbHoTenSV.Name = "lbHoTenSV";
            this.lbHoTenSV.Size = new System.Drawing.Size(107, 28);
            this.lbHoTenSV.TabIndex = 67;
            this.lbHoTenSV.Text = "Họ Tên SV";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(118, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 28);
            this.label9.TabIndex = 68;
            this.label9.Text = "Họ Tên SV:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(659, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 589);
            this.panel2.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSoThang);
            this.groupBox1.Controls.Add(this.btnGiaHan);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Location = new System.Drawing.Point(35, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 423);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // cmbSoThang
            // 
            this.cmbSoThang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSoThang.BackColor = System.Drawing.Color.Transparent;
            this.cmbSoThang.BorderColor = System.Drawing.Color.Gray;
            this.cmbSoThang.BorderRadius = 5;
            this.cmbSoThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSoThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoThang.Enabled = false;
            this.cmbSoThang.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSoThang.FocusedState.Parent = this.cmbSoThang;
            this.cmbSoThang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.cmbSoThang.ForeColor = System.Drawing.Color.Black;
            this.cmbSoThang.FormattingEnabled = true;
            this.cmbSoThang.HoverState.Parent = this.cmbSoThang;
            this.cmbSoThang.ItemHeight = 30;
            this.cmbSoThang.Items.AddRange(new object[] {
            "6",
            "12"});
            this.cmbSoThang.ItemsAppearance.Parent = this.cmbSoThang;
            this.cmbSoThang.Location = new System.Drawing.Point(335, 81);
            this.cmbSoThang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbSoThang.Name = "cmbSoThang";
            this.cmbSoThang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSoThang.ShadowDecoration.Parent = this.cmbSoThang;
            this.cmbSoThang.Size = new System.Drawing.Size(86, 36);
            this.cmbSoThang.TabIndex = 64;
            this.cmbSoThang.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(24, 89);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(221, 28);
            this.label22.TabIndex = 65;
            this.label22.Text = "Gia hạn đăng ký thêm";
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGiaHan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnGiaHan.BorderRadius = 5;
            this.btnGiaHan.BorderThickness = 1;
            this.btnGiaHan.CheckedState.Parent = this.btnGiaHan;
            this.btnGiaHan.CustomImages.Parent = this.btnGiaHan;
            this.btnGiaHan.DisabledState.Parent = this.btnGiaHan;
            this.btnGiaHan.Enabled = false;
            this.btnGiaHan.FillColor = System.Drawing.Color.Transparent;
            this.btnGiaHan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGiaHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnGiaHan.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnGiaHan.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGiaHan.HoverState.Parent = this.btnGiaHan;
            this.btnGiaHan.Location = new System.Drawing.Point(153, 261);
            this.btnGiaHan.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.ShadowDecoration.Parent = this.btnGiaHan;
            this.btnGiaHan.Size = new System.Drawing.Size(238, 57);
            this.btnGiaHan.TabIndex = 63;
            this.btnGiaHan.Text = "Gia Hạn Ở KTX";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.txtTongTien.BorderRadius = 15;
            this.txtTongTien.BorderThickness = 2;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.DisabledState.Parent = this.txtTongTien;
            this.txtTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTongTien.FocusedState.Parent = this.txtTongTien;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.HoverState.Parent = this.txtTongTien;
            this.txtTongTien.Location = new System.Drawing.Point(153, 185);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTongTien.PlaceholderText = "Tổng tiền lệ phí";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.ShadowDecoration.Parent = this.txtTongTien;
            this.txtTongTien.Size = new System.Drawing.Size(238, 50);
            this.txtTongTien.TabIndex = 45;
            this.txtTongTien.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(430, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 68;
            this.label1.Text = "tháng";
            // 
            // frmSV_InfoBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 667);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSV_InfoBill";
            this.Text = "Hóa Đơn, Biên Lai";
            this.Load += new System.EventHandler(this.frmSV_InfoBill_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDienNuoc.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVCTDienNuoc)).EndInit();
            this.gbDienNuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVDienNuoc)).EndInit();
            this.tabLePhi.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLePhi;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.TabPage tabDienNuoc;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.DataGridView dgvSVCTDienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDICHVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHISOSUDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private Guna.UI2.WinForms.Guna2GroupBox gbDienNuoc;
        private System.Windows.Forms.DataGridView dgvSVDienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSoThang;
        private Guna.UI2.WinForms.Guna2Button btnGiaHan;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbHanCuoi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbHoTenSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}