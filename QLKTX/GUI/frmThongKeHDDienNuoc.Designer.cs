
namespace QLKTX.GUI
{
    partial class frmThongKeHDDienNuoc
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnThongKeDienNuoc = new Guna.UI2.WinForms.Guna2Button();
            this.robThongKeTuDen = new System.Windows.Forms.RadioButton();
            this.robThongKeThang = new System.Windows.Forms.RadioButton();
            this.robThongKeNam = new System.Windows.Forms.RadioButton();
            this.dtpTKDen = new System.Windows.Forms.DateTimePicker();
            this.dtpTKTu = new System.Windows.Forms.DateTimePicker();
            this.dtpTKThang = new System.Windows.Forms.DateTimePicker();
            this.dtpTKNam = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(0, 276);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1112, 484);
            this.reportViewer2.TabIndex = 1;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.btnThongKeDienNuoc);
            this.guna2GroupBox2.Controls.Add(this.robThongKeTuDen);
            this.guna2GroupBox2.Controls.Add(this.robThongKeThang);
            this.guna2GroupBox2.Controls.Add(this.robThongKeNam);
            this.guna2GroupBox2.Controls.Add(this.dtpTKDen);
            this.guna2GroupBox2.Controls.Add(this.dtpTKTu);
            this.guna2GroupBox2.Controls.Add(this.dtpTKThang);
            this.guna2GroupBox2.Controls.Add(this.dtpTKNam);
            this.guna2GroupBox2.Controls.Add(this.label16);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(1114, 271);
            this.guna2GroupBox2.TabIndex = 56;
            this.guna2GroupBox2.Text = "Hóa Đơn Điện Nước";
            // 
            // btnThongKeDienNuoc
            // 
            this.btnThongKeDienNuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThongKeDienNuoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnThongKeDienNuoc.BorderRadius = 5;
            this.btnThongKeDienNuoc.BorderThickness = 1;
            this.btnThongKeDienNuoc.CheckedState.Parent = this.btnThongKeDienNuoc;
            this.btnThongKeDienNuoc.CustomImages.Parent = this.btnThongKeDienNuoc;
            this.btnThongKeDienNuoc.DisabledState.Parent = this.btnThongKeDienNuoc;
            this.btnThongKeDienNuoc.FillColor = System.Drawing.Color.Transparent;
            this.btnThongKeDienNuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeDienNuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnThongKeDienNuoc.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnThongKeDienNuoc.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThongKeDienNuoc.HoverState.Parent = this.btnThongKeDienNuoc;
            this.btnThongKeDienNuoc.Location = new System.Drawing.Point(888, 84);
            this.btnThongKeDienNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKeDienNuoc.Name = "btnThongKeDienNuoc";
            this.btnThongKeDienNuoc.ShadowDecoration.Parent = this.btnThongKeDienNuoc;
            this.btnThongKeDienNuoc.Size = new System.Drawing.Size(129, 107);
            this.btnThongKeDienNuoc.TabIndex = 39;
            this.btnThongKeDienNuoc.Text = "Thống Kê";
            this.btnThongKeDienNuoc.Click += new System.EventHandler(this.btnThongKeDienNuoc_Click);
            // 
            // robThongKeTuDen
            // 
            this.robThongKeTuDen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.robThongKeTuDen.AutoSize = true;
            this.robThongKeTuDen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.robThongKeTuDen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robThongKeTuDen.ForeColor = System.Drawing.Color.Black;
            this.robThongKeTuDen.Location = new System.Drawing.Point(78, 212);
            this.robThongKeTuDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.robThongKeTuDen.Name = "robThongKeTuDen";
            this.robThongKeTuDen.Size = new System.Drawing.Size(148, 32);
            this.robThongKeTuDen.TabIndex = 38;
            this.robThongKeTuDen.Text = "Thống kê từ";
            this.robThongKeTuDen.UseVisualStyleBackColor = false;
            // 
            // robThongKeThang
            // 
            this.robThongKeThang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.robThongKeThang.AutoSize = true;
            this.robThongKeThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.robThongKeThang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robThongKeThang.ForeColor = System.Drawing.Color.Black;
            this.robThongKeThang.Location = new System.Drawing.Point(78, 141);
            this.robThongKeThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.robThongKeThang.Name = "robThongKeThang";
            this.robThongKeThang.Size = new System.Drawing.Size(231, 32);
            this.robThongKeThang.TabIndex = 38;
            this.robThongKeThang.Text = "Thống kê theo tháng";
            this.robThongKeThang.UseVisualStyleBackColor = false;
            // 
            // robThongKeNam
            // 
            this.robThongKeNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.robThongKeNam.AutoSize = true;
            this.robThongKeNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.robThongKeNam.Checked = true;
            this.robThongKeNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robThongKeNam.ForeColor = System.Drawing.Color.Black;
            this.robThongKeNam.Location = new System.Drawing.Point(78, 71);
            this.robThongKeNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.robThongKeNam.Name = "robThongKeNam";
            this.robThongKeNam.Size = new System.Drawing.Size(217, 32);
            this.robThongKeNam.TabIndex = 38;
            this.robThongKeNam.TabStop = true;
            this.robThongKeNam.Text = "Thống kê theo năm";
            this.robThongKeNam.UseVisualStyleBackColor = false;
            // 
            // dtpTKDen
            // 
            this.dtpTKDen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTKDen.CustomFormat = "dd/MM/yyyy";
            this.dtpTKDen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpTKDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTKDen.Location = new System.Drawing.Point(634, 210);
            this.dtpTKDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTKDen.Name = "dtpTKDen";
            this.dtpTKDen.Size = new System.Drawing.Size(182, 34);
            this.dtpTKDen.TabIndex = 37;
            // 
            // dtpTKTu
            // 
            this.dtpTKTu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTKTu.CustomFormat = "dd/MM/yyyy";
            this.dtpTKTu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpTKTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTKTu.Location = new System.Drawing.Point(378, 209);
            this.dtpTKTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTKTu.Name = "dtpTKTu";
            this.dtpTKTu.Size = new System.Drawing.Size(182, 34);
            this.dtpTKTu.TabIndex = 36;
            // 
            // dtpTKThang
            // 
            this.dtpTKThang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTKThang.CustomFormat = "dd/MM/yyyy";
            this.dtpTKThang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpTKThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTKThang.Location = new System.Drawing.Point(378, 138);
            this.dtpTKThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTKThang.Name = "dtpTKThang";
            this.dtpTKThang.Size = new System.Drawing.Size(182, 34);
            this.dtpTKThang.TabIndex = 35;
            // 
            // dtpTKNam
            // 
            this.dtpTKNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTKNam.CustomFormat = "dd/MM/yyyy";
            this.dtpTKNam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpTKNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTKNam.Location = new System.Drawing.Point(378, 68);
            this.dtpTKNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTKNam.Name = "dtpTKNam";
            this.dtpTKNam.Size = new System.Drawing.Size(182, 34);
            this.dtpTKNam.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(586, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 28);
            this.label16.TabIndex = 2;
            this.label16.Text = "~";
            // 
            // frmThongKeHDDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1114, 752);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.reportViewer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeHDDienNuoc";
            this.Text = "Thống Kê Hóa Đơn Điện Nước";
            this.Load += new System.EventHandler(this.frmThongKeHDDienNuoc_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.DateTimePicker dtpTKDen;
        private System.Windows.Forms.DateTimePicker dtpTKTu;
        private System.Windows.Forms.DateTimePicker dtpTKThang;
        private System.Windows.Forms.DateTimePicker dtpTKNam;
        private System.Windows.Forms.RadioButton robThongKeTuDen;
        private System.Windows.Forms.RadioButton robThongKeThang;
        private System.Windows.Forms.RadioButton robThongKeNam;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button btnThongKeDienNuoc;
    }
}