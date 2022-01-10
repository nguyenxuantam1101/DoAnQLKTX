
namespace QLKTX.GUI
{
    partial class frmChangePass
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassRe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnLogin.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnLogin.Controls.Add(this.guna2Panel1);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.ShadowDecoration.Parent = this.pnLogin;
            this.pnLogin.Size = new System.Drawing.Size(929, 692);
            this.pnLogin.TabIndex = 7;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.guna2Panel1.BorderThickness = 5;
            this.guna2Panel1.Controls.Add(this.btnChangePass);
            this.guna2Panel1.Controls.Add(this.txtPass);
            this.guna2Panel1.Controls.Add(this.txtNewPassRe);
            this.guna2Panel1.Controls.Add(this.txtNewPass);
            this.guna2Panel1.Controls.Add(this.txtUser);
            this.guna2Panel1.Location = new System.Drawing.Point(198, 72);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(542, 498);
            this.guna2Panel1.TabIndex = 32;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnChangePass.BorderRadius = 5;
            this.btnChangePass.BorderThickness = 1;
            this.btnChangePass.CheckedState.Parent = this.btnChangePass;
            this.btnChangePass.CustomImages.Parent = this.btnChangePass;
            this.btnChangePass.DisabledState.Parent = this.btnChangePass;
            this.btnChangePass.FillColor = System.Drawing.Color.Transparent;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.btnChangePass.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnChangePass.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChangePass.HoverState.Parent = this.btnChangePass;
            this.btnChangePass.Location = new System.Drawing.Point(180, 348);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.ShadowDecoration.Parent = this.btnChangePass;
            this.btnChangePass.Size = new System.Drawing.Size(199, 50);
            this.btnChangePass.TabIndex = 31;
            this.btnChangePass.Text = "Đổi Mật Khẩu";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtPass
            // 
            this.txtPass.Animated = true;
            this.txtPass.BorderColor = System.Drawing.Color.Gray;
            this.txtPass.BorderRadius = 5;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.Parent = this.txtPass;
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.FocusedState.Parent = this.txtPass;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.HoverState.Parent = this.txtPass;
            this.txtPass.IconRight = global::QLKTX.Properties.Resources.icon_hide_final;
            this.txtPass.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtPass.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtPass.Location = new System.Drawing.Point(121, 135);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPass.PlaceholderText = "Mật khẩu cũ";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Parent = this.txtPass;
            this.txtPass.Size = new System.Drawing.Size(316, 36);
            this.txtPass.TabIndex = 2;
            // 
            // txtNewPassRe
            // 
            this.txtNewPassRe.Animated = true;
            this.txtNewPassRe.BorderColor = System.Drawing.Color.Gray;
            this.txtNewPassRe.BorderRadius = 5;
            this.txtNewPassRe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassRe.DefaultText = "";
            this.txtNewPassRe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassRe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassRe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassRe.DisabledState.Parent = this.txtNewPassRe;
            this.txtNewPassRe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassRe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassRe.FocusedState.Parent = this.txtNewPassRe;
            this.txtNewPassRe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassRe.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassRe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassRe.HoverState.Parent = this.txtNewPassRe;
            this.txtNewPassRe.IconRight = global::QLKTX.Properties.Resources.icon_hide_final;
            this.txtNewPassRe.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtNewPassRe.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtNewPassRe.Location = new System.Drawing.Point(121, 264);
            this.txtNewPassRe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassRe.Name = "txtNewPassRe";
            this.txtNewPassRe.PasswordChar = '\0';
            this.txtNewPassRe.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNewPassRe.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txtNewPassRe.SelectedText = "";
            this.txtNewPassRe.ShadowDecoration.Parent = this.txtNewPassRe;
            this.txtNewPassRe.Size = new System.Drawing.Size(316, 36);
            this.txtNewPassRe.TabIndex = 2;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Animated = true;
            this.txtNewPass.BorderColor = System.Drawing.Color.Gray;
            this.txtNewPass.BorderRadius = 5;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.Parent = this.txtNewPass;
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.FocusedState.Parent = this.txtNewPass;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.Black;
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.HoverState.Parent = this.txtNewPass;
            this.txtNewPass.IconRight = global::QLKTX.Properties.Resources.icon_hide_final;
            this.txtNewPass.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtNewPass.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtNewPass.Location = new System.Drawing.Point(121, 201);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNewPass.PlaceholderText = "Mật khẩu mới";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.ShadowDecoration.Parent = this.txtNewPass;
            this.txtNewPass.Size = new System.Drawing.Size(316, 36);
            this.txtNewPass.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Animated = true;
            this.txtUser.BorderColor = System.Drawing.Color.Gray;
            this.txtUser.BorderRadius = 5;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.Parent = this.txtUser;
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.FocusedState.Parent = this.txtUser;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.HoverState.Parent = this.txtUser;
            this.txtUser.Location = new System.Drawing.Point(121, 74);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUser.PlaceholderText = "User";
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.Parent = this.txtUser;
            this.txtUser.Size = new System.Drawing.Size(316, 36);
            this.txtUser.TabIndex = 1;
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
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 692);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePass";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.pnLogin.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassRe;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnChangePass;
    }
}