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
    public partial class frmNV_NoiQuy : Form
    {
        KTXDBContext context = new KTXDBContext();
        public frmNV_NoiQuy()
        {
            InitializeComponent();
        }

        private void BindGrid(List<NOIQUYKTX> listNoiQuy)
        {
            dgvNoiQuy.Rows.Clear();
            foreach (var item in listNoiQuy)
            {
                {      
                    int index = dgvNoiQuy.Rows.Add();
                    dgvNoiQuy.Rows[index].Cells[0].Value = item.MANOIQUY;
                    dgvNoiQuy.Rows[index].Cells[1].Value = item.TENNOIQUY;
                    dgvNoiQuy.Rows[index].Cells[2].Value = item.NOIDUNG;
                    dgvNoiQuy.Rows[index].Cells[3].Value = item.HINHTHUCPHAT;
                    
                }
            }
        }
        private void reloadDGV()
        {
            List<NOIQUYKTX> listNoiQuy = context.NOIQUYKTX.ToList();
            BindGrid(listNoiQuy);
        }

        private void setNull()
        {
            txtMaNoiQuy.Text = "";
            txtTenNoiQuy.Text = "";
            txtNoiDung.Text = "";
            txtHinhThucPhat.Text = "";
        }

        private void frmNV_NoiQuy_Load(object sender, EventArgs e)
        {
            List<NOIQUYKTX> listNoiQuy = context.NOIQUYKTX.ToList();
            BindGrid(listNoiQuy);
            setNull();
        }
        private void dgvNoiQuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvNoiQuy.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvNoiQuy.CurrentRow.Selected = true;
                    txtMaNoiQuy.Text = dgvNoiQuy.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenNoiQuy.Text = dgvNoiQuy.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtNoiDung.Text = dgvNoiQuy.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtHinhThucPhat.Text = dgvNoiQuy.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedRow(string MANQ)
        {
            for (int i = 0; i < dgvNoiQuy.Rows.Count; i++)
            {
                if (dgvNoiQuy.Rows[i].Cells[0].Value != null) // check null dgv
                {
                    if (dgvNoiQuy.Rows[i].Cells[0].Value.ToString() == MANQ)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtHinhThucPhat.Text) || string.IsNullOrEmpty(txtMaNoiQuy.Text) || string.IsNullOrEmpty(txtNoiDung.Text) || string.IsNullOrEmpty(txtTenNoiQuy.Text))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Thông Báo");
                }
                else
                {
                    if (GetSelectedRow(txtMaNoiQuy.Text) == -1)
                    {
                        NOIQUYKTX nq = context.NOIQUYKTX.FirstOrDefault(p => p.MANOIQUY == txtMaNoiQuy.Text);
                        if (nq == null)
                        {
                            NOIQUYKTX nv = new NOIQUYKTX()
                            {
                                MANOIQUY = txtMaNoiQuy.Text,
                                TENNOIQUY = txtTenNoiQuy.Text,
                                NOIDUNG = txtNoiDung.Text,
                                HINHTHUCPHAT = txtHinhThucPhat.Text
                            };
                            context.NOIQUYKTX.Add(nq);
                            context.SaveChanges();
                            reloadDGV();
                            setNull();
                            MessageBox.Show("Thêm mới dữ liệu thành công!" , "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nội Quy Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtHinhThucPhat.Text) || string.IsNullOrEmpty(txtMaNoiQuy.Text) || string.IsNullOrEmpty(txtNoiDung.Text) || string.IsNullOrEmpty(txtTenNoiQuy.Text))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Thông Báo");
                }
                else
                {
                    if (GetSelectedRow(txtMaNoiQuy.Text) == -1)
                    {
                        NOIQUYKTX nq = context.NOIQUYKTX.FirstOrDefault(p => p.MANOIQUY == txtMaNoiQuy.Text);
                        if (nq != null)
                        {
                            nq.MANOIQUY = txtMaNoiQuy.Text;
                            nq.TENNOIQUY = txtTenNoiQuy.Text;
                            nq.NOIDUNG = txtNoiDung.Text;
                            nq.HINHTHUCPHAT = txtHinhThucPhat.Text;
                            context.SaveChanges();
                            reloadDGV();
                            setNull();
                            MessageBox.Show("Cập nhập dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nội quy cần sửa", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NOIQUYKTX dbDelete = context.NOIQUYKTX.FirstOrDefault(p => p.MANOIQUY == txtMaNoiQuy.Text);
            if (dbDelete != null)
            {
                DialogResult noti = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo);
                if (noti == DialogResult.Yes)
                {
                    context.NOIQUYKTX.Remove(dbDelete);
                    context.SaveChanges();
                    reloadDGV();
                    setNull();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    //Sum();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản cần Xóa ", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
