using QLKTX.DATA;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLKTX.GUI
{
    public partial class frmChangePass : Form
    {
        KTXDBContext context = new KTXDBContext();
        string userLogin = "";
        public frmChangePass(string userLogin)
        {
            InitializeComponent();
            this.userLogin = userLogin;
        }
        string passOld = "";
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (passOld == txtPass.Text.Trim())
                {
                    ACCOUNT up = context.ACCOUNT.FirstOrDefault(p => p.USER == txtUser.Text);
                        if (txtNewPass.Text.Trim() == txtNewPassRe.Text.Trim())
                        {
                            up.PASS = txtNewPass.Text;
                            context.SaveChanges();
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu nhập vào không trùng nhau!", "Thông báo", MessageBoxButtons.OK);
                        }
                }
                else
                {
                    MessageBox.Show("Thông tin bạn nhập chưa chính xác!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            ACCOUNT acc = context.ACCOUNT.FirstOrDefault(p => p.USER == userLogin);
            txtUser.Text = acc.USER;
            passOld = acc.PASS;
        }
    }
}
