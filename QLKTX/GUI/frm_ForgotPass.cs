using QLKTX.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.GUI
{
    public partial class frm_ForgotPass : Form
    {
        KTXDBContext context = new KTXDBContext();
        public frm_ForgotPass()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
            this.Hide();
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text != "" && txtPass.Text != "" && txtCCCD.Text != "" && txtSDT.Text != "" && txtNewPass.Text != "")
                {
                    ACCOUNT up = context.ACCOUNT.FirstOrDefault(p => p.USER == txtUser.Text);
                    SINHVIEN sv = context.SINHVIEN.FirstOrDefault(p => p.CCCD == txtCCCD.Text);
                    NHANVIEN nv = context.NHANVIEN.FirstOrDefault(p => p.MANV == txtCCCD.Text);
                    //List<ACCOUNT> acc = context.ACCOUNT.Where(p => p.CCCD == txtCCCD.Text).ToList();
                    if (up == null)
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (txtCCCD.Text == up.CCCD && txtCCCD.Text == sv.CCCD && sv.SDT == txtSDT.Text)
                        {
                            up.PASS = txtNewPass.Text;
                            context.SaveChanges();
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else if (txtCCCD.Text == up.MANV && txtCCCD.Text == nv.MANV && nv.SDT == txtSDT.Text)
                        {
                            up.PASS = txtNewPass.Text;
                            context.SaveChanges();
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Thông tin bạn nhập chưa chính xác!", "Thông báo", MessageBoxButtons.OK);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng không để trống thông tin!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
