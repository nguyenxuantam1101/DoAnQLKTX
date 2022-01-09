
namespace QLKTX.GUI
{
    partial class frmLogin
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
            this.cbRememberMe = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnPicture = new Guna.UI2.WinForms.Guna2Panel();
            this.Minisize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.picBackground = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.pnLogin.Controls.Add(this.cbRememberMe);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.lblForgotPassword);
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Controls.Add(this.txtPass);
            this.pnLogin.Controls.Add(this.txtUser);
            this.pnLogin.Controls.Add(this.picLogo);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.ShadowDecoration.Parent = this.pnLogin;
            this.pnLogin.Size = new System.Drawing.Size(275, 559);
            this.pnLogin.TabIndex = 4;
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.BackColor = System.Drawing.Color.White;
            this.cbRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.cbRememberMe.CheckedState.BorderRadius = 2;
            this.cbRememberMe.CheckedState.BorderThickness = 0;
            this.cbRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.cbRememberMe.CheckedState.Parent = this.cbRememberMe;
            this.cbRememberMe.Location = new System.Drawing.Point(20, 327);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.ShadowDecoration.Parent = this.cbRememberMe;
            this.cbRememberMe.Size = new System.Drawing.Size(15, 16);
            this.cbRememberMe.TabIndex = 3;
            this.cbRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.cbRememberMe.UncheckedState.BorderRadius = 2;
            this.cbRememberMe.UncheckedState.BorderThickness = 1;
            this.cbRememberMe.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.UncheckedState.Parent = this.cbRememberMe;
            this.cbRememberMe.Click += new System.EventHandler(this.cbRememberMe_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(67, 378);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(135, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseTransparentBackground = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPassword.Location = new System.Drawing.Point(171, 330);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(86, 13);
            this.lblForgotPassword.TabIndex = 3;
            this.lblForgotPassword.Text = "Forgot Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remember Me";
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
            this.txtPass.Location = new System.Drawing.Point(20, 279);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Parent = this.txtPass;
            this.txtPass.Size = new System.Drawing.Size(237, 29);
            this.txtPass.TabIndex = 2;
            this.txtPass.IconRightClick += new System.EventHandler(this.txtPass_IconRightClick);
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
            this.txtUser.Location = new System.Drawing.Point(20, 226);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderText = "User";
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.Parent = this.txtUser;
            this.txtUser.Size = new System.Drawing.Size(237, 29);
            this.txtUser.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::QLKTX.Properties.Resources.logohutech;
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(20, 38);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Parent = this.picLogo;
            this.picLogo.Size = new System.Drawing.Size(237, 131);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnPicture
            // 
            this.pnPicture.Controls.Add(this.Minisize);
            this.pnPicture.Controls.Add(this.Exit);
            this.pnPicture.Controls.Add(this.picBackground);
            this.pnPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPicture.Location = new System.Drawing.Point(277, 0);
            this.pnPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnPicture.Name = "pnPicture";
            this.pnPicture.ShadowDecoration.Parent = this.pnPicture;
            this.pnPicture.Size = new System.Drawing.Size(517, 559);
            this.pnPicture.TabIndex = 3;
            // 
            // Minisize
            // 
            this.Minisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minisize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minisize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.Minisize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.Minisize.HoverState.Parent = this.Minisize;
            this.Minisize.IconColor = System.Drawing.Color.White;
            this.Minisize.Location = new System.Drawing.Point(441, 10);
            this.Minisize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Minisize.Name = "Minisize";
            this.Minisize.ShadowDecoration.Parent = this.Minisize;
            this.Minisize.Size = new System.Drawing.Size(30, 32);
            this.Minisize.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.Exit.HoverState.FillColor = System.Drawing.Color.Red;
            this.Exit.HoverState.Parent = this.Exit;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(476, 10);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.ShadowDecoration.Parent = this.Exit;
            this.Exit.Size = new System.Drawing.Size(30, 32);
            this.Exit.TabIndex = 1;
            // 
            // picBackground
            // 
            this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackground.Image = global::QLKTX.Properties.Resources.PicHomeLogin;
            this.picBackground.ImageRotate = 0F;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBackground.Name = "picBackground";
            this.picBackground.ShadowDecoration.Parent = this.picBackground;
            this.picBackground.Size = new System.Drawing.Size(517, 559);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
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
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.picBackground;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 559);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1440, 837);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnLogin;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbRememberMe;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Panel pnPicture;
        private Guna.UI2.WinForms.Guna2ControlBox Minisize;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2PictureBox picBackground;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
    }
}