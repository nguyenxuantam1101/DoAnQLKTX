
namespace QLKTX.GUI
{
    partial class frm_ForgotPass
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
            this.components = new System.ComponentModel.Container();
            this.pnLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDoiPass = new Guna.UI2.WinForms.Guna2Button();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Minisize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.pnLogin.Controls.Add(this.Minisize);
            this.pnLogin.Controls.Add(this.btnDoiPass);
            this.pnLogin.Controls.Add(this.Exit);
            this.pnLogin.Controls.Add(this.txtPass);
            this.pnLogin.Controls.Add(this.txtNewPass);
            this.pnLogin.Controls.Add(this.txtSDT);
            this.pnLogin.Controls.Add(this.txtCCCD);
            this.pnLogin.Controls.Add(this.txtUser);
            this.pnLogin.Controls.Add(this.picLogo);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.ShadowDecoration.Parent = this.pnLogin;
            this.pnLogin.Size = new System.Drawing.Size(848, 572);
            this.pnLogin.TabIndex = 6;
            // 
            // btnDoiPass
            // 
            this.btnDoiPass.Animated = true;
            this.btnDoiPass.BackColor = System.Drawing.Color.Transparent;
            this.btnDoiPass.BorderColor = System.Drawing.Color.White;
            this.btnDoiPass.BorderRadius = 10;
            this.btnDoiPass.BorderThickness = 2;
            this.btnDoiPass.CheckedState.Parent = this.btnDoiPass;
            this.btnDoiPass.CustomImages.Parent = this.btnDoiPass;
            this.btnDoiPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiPass.DisabledState.Parent = this.btnDoiPass;
            this.btnDoiPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.btnDoiPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoiPass.ForeColor = System.Drawing.Color.White;
            this.btnDoiPass.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiPass.HoverState.Parent = this.btnDoiPass;
            this.btnDoiPass.Location = new System.Drawing.Point(321, 479);
            this.btnDoiPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiPass.Name = "btnDoiPass";
            this.btnDoiPass.ShadowDecoration.Parent = this.btnDoiPass;
            this.btnDoiPass.Size = new System.Drawing.Size(180, 46);
            this.btnDoiPass.TabIndex = 4;
            this.btnDoiPass.Text = "Đổi Mật Khẩu";
            this.btnDoiPass.UseTransparentBackground = true;
            this.btnDoiPass.Click += new System.EventHandler(this.btnDoiPass_Click);
            // 
            // txtPass
            // 
            this.txtPass.Animated = true;
            this.txtPass.BorderRadius = 6;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.Parent = this.txtPass;
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.FocusedState.Parent = this.txtPass;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.HoverState.Parent = this.txtPass;
            this.txtPass.IconRight = global::QLKTX.Properties.Resources.icon_hide_final;
            this.txtPass.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtPass.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtPass.Location = new System.Drawing.Point(257, 366);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderText = "Mật Khẩu Cũ";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Parent = this.txtPass;
            this.txtPass.Size = new System.Drawing.Size(316, 36);
            this.txtPass.TabIndex = 2;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Animated = true;
            this.txtNewPass.BorderRadius = 6;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.Parent = this.txtNewPass;
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.FocusedState.Parent = this.txtNewPass;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.HoverState.Parent = this.txtNewPass;
            this.txtNewPass.IconRight = global::QLKTX.Properties.Resources.icon_hide_final;
            this.txtNewPass.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtNewPass.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtNewPass.Location = new System.Drawing.Point(257, 420);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderText = "Mật Khẩu Mới";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.ShadowDecoration.Parent = this.txtNewPass;
            this.txtNewPass.Size = new System.Drawing.Size(316, 36);
            this.txtNewPass.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Animated = true;
            this.txtSDT.BorderRadius = 6;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(257, 306);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "Số Điện Thoại";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(316, 36);
            this.txtSDT.TabIndex = 1;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Animated = true;
            this.txtCCCD.BorderRadius = 6;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.Parent = this.txtCCCD;
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.FocusedState.Parent = this.txtCCCD;
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.HoverState.Parent = this.txtCCCD;
            this.txtCCCD.Location = new System.Drawing.Point(257, 250);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PlaceholderText = "CCCD Hoặc Mã Nhân Viên";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.ShadowDecoration.Parent = this.txtCCCD;
            this.txtCCCD.Size = new System.Drawing.Size(316, 36);
            this.txtCCCD.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Animated = true;
            this.txtUser.BorderRadius = 6;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.Parent = this.txtUser;
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.FocusedState.Parent = this.txtUser;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.HoverState.Parent = this.txtUser;
            this.txtUser.Location = new System.Drawing.Point(257, 192);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderText = "User";
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.Parent = this.txtUser;
            this.txtUser.Size = new System.Drawing.Size(316, 36);
            this.txtUser.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::QLKTX.Properties.Resources.logohutech;
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(257, 11);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Parent = this.picLogo;
            this.picLogo.Size = new System.Drawing.Size(316, 161);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnLogin;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 50;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.Red;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.Exit.HoverState.FillColor = System.Drawing.Color.Red;
            this.Exit.HoverState.Parent = this.Exit;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(795, 11);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.ShadowDecoration.Parent = this.Exit;
            this.Exit.Size = new System.Drawing.Size(40, 39);
            this.Exit.TabIndex = 1;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minisize
            // 
            this.Minisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minisize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minisize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.Minisize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.Minisize.HoverState.Parent = this.Minisize;
            this.Minisize.IconColor = System.Drawing.Color.White;
            this.Minisize.Location = new System.Drawing.Point(748, 11);
            this.Minisize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minisize.Name = "Minisize";
            this.Minisize.ShadowDecoration.Parent = this.Minisize;
            this.Minisize.Size = new System.Drawing.Size(40, 39);
            this.Minisize.TabIndex = 1;
            // 
            // frm_ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 572);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ForgotPass";
            this.Text = "FrmFogot";
            this.pnLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnLogin;
        private Guna.UI2.WinForms.Guna2Button btnDoiPass;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2ControlBox Minisize;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
    }
}