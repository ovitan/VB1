using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDVVTHH.UI;
using QLDVVTHH.DTO;

namespace QLDVVTHH
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mnquanlynhanvien_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmNhanVien")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmNhanVien uc = new frmNhanVien();
            uc.Show();
            uc.MdiParent = this;
        }
        
        private void mnlaphopdong_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmHopDong")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmHopDong uc = new frmHopDong();
            uc.Show();
            uc.MdiParent = this;
        }

        private void mnnhapbangke_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmBangKe")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmBangKe uc = new frmBangKe();
            uc.Show();
            uc.MdiParent = this;
        }



        private void mnlaphoadon_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmHoaDon")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmHoaDon uc = new frmHoaDon();
            uc.Show();
            uc.MdiParent = this;
        }

        private void mnacongno_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmCongNo")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmCongNo uc = new frmCongNo();
            uc.Show();
            uc.MdiParent = this;
        }

        private void mndanhsachkhachhang_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmInAn")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            DTO_ResizeForm rz = new DTO_ResizeForm();
            rz.CHIEU_CAO=214;
            rz.CHIEU_DAI=130;
            rz.Index = "0001";
            frmInAn uc = new frmInAn(rz);
            uc.Show();
            uc.MdiParent = this;
        }

        private void mnxuathoadon_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmInAn")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            DTO_ResizeForm rz = new DTO_ResizeForm();
            rz.CHIEU_CAO = 214;
            rz.CHIEU_DAI = 250;
            rz.Index = "0004";
            frmInAn uc = new frmInAn(rz);
            uc.Show();
            uc.MdiParent = this;
        }

        private void mndanhsachxe_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmInAn")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            DTO_ResizeForm rz = new DTO_ResizeForm();
            rz.CHIEU_CAO = 214;
            rz.CHIEU_DAI = 100;
            rz.Index = "0003";
            frmInAn uc = new frmInAn(rz);
            uc.Show();
            uc.MdiParent = this;
        }

        private void mndanhsachnhanvien_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmInAn")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            DTO_ResizeForm rz = new DTO_ResizeForm();
            rz.CHIEU_CAO = 214;
            rz.CHIEU_DAI = 100;
            rz.Index = "0002";
            frmInAn uc = new frmInAn(rz);
            uc.Show();
            uc.MdiParent = this;
        }
        private void mnxemcongnokhachhang_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmThongKeCongNo")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmThongKeCongNo uc = new frmThongKeCongNo();
            uc.Show();
            uc.MdiParent = this;
        }
        private void mnquanlykhachang_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmKhachHang")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmKhachHang uc = new frmKhachHang();
            uc.Show();
            uc.MdiParent = this;
        }

        private void tìnhTrạngXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmTinhTrangXe")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmTinhTrangXe uc = new frmTinhTrangXe();
            uc.Show();
            uc.MdiParent = this;
        }

        private void mnquanlyxe_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmXe")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmXe uc = new frmXe();
            uc.Show();
            uc.MdiParent = this;
        }

        private void tìnhTrạngXeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmTinhTrangXe")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmTinhTrangXe uc = new frmTinhTrangXe();
            uc.Show();
            uc.MdiParent = this;
        }


        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmDịchVu")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmDichVu uc = new frmDichVu();
            uc.Show();
            uc.MdiParent = this;
        }
        private void mndx_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmTTDieuXe")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmTTDieuXe uc = new frmTTDieuXe();
            uc.Show();
            uc.MdiParent = this;
        }

        private void mnbaogia_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "txt_mabaogia")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            txt_mabaogia uc = new txt_mabaogia();
            uc.Show();
            uc.MdiParent = this;
        }

        private void mnsaoluucsdl_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == "frmSaoLuuData")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmSaoLuuData uc = new frmSaoLuuData();
            uc.Show();
            uc.MdiParent = this;
        }
    }
}
