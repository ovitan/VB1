using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDVVTHH.UC;
using QLDVVTHH.DTO;
using QLDVVTHH.BLL;
using QLDVVTHH.UC_TIMKIEM;

namespace QLDVVTHH.UI
{
    public partial class frmTimKiem : Form
    {
        private int originalWidth;
        private int originalHeight;
        public frmTimKiem(DTO_ResizeForm rz)
        {
            InitializeComponent();
            _Load_Combobox();
            DTO_ResizeForm rs = rz;
            originalHeight = rs.CHIEU_CAO;
            originalWidth = rs.CHIEU_DAI;
            //cbdanhmuc.SelectedValue = rs.Index.ToString();
            //if (cbdanhmuc.SelectedValue.ToString().Trim() == "0005")
            //{
            //    this.Width = 300;
            //    this.Height = 200;
            //    pncontrol.Controls.Clear();
            //    uchopdong uc = new uchopdong();
            //    pncontrol.Controls.Add(uc);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in Main.ActiveForm.MdiChildren)
            {
                if (mdiChild.Name == "frmTimKetQua")
                {
                    mdiChild.Activate();
                    return;
                }
            }
            frmTimKetQua uc = new frmTimKetQua();
            uc.MdiParent = Main.ActiveForm;
            uc.Show();
        }
        private void _Load_Combobox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Value");
            DataRow row = dt.NewRow();
            row["Text"] = "Tìm Thông Tin Khách Hàng";
            row["Value"] = "0001";
            dt.Rows.InsertAt(row, 0);
            DataRow row2 = dt.NewRow();
            row2["Text"] = "Tìm Thông Tin Nhân Viên";
            row2["Value"] = "0002";
            dt.Rows.InsertAt(row2, 0);

            DataRow row3 = dt.NewRow();
            row3["Text"] = "Tìm Thông Tin Xe ";
            row3["Value"] = "0003";
            dt.Rows.InsertAt(row3, 0);

            DataRow row4 = dt.NewRow();
            row4["Text"] = "Tìm Thông Tin Hóa Đơn ";
            row4["Value"] = "0004";
            dt.Rows.InsertAt(row4, 0);

            DataRow row5 = dt.NewRow();
            row5["Text"] = "Tìm Thông Tin Hợp Đồng ";
            row5["Value"] = "0005";
            dt.Rows.InsertAt(row5, 0);


            //cbdanhmuc.DataSource = dt;
            //cbdanhmuc.DisplayMember = "Text";
            //cbdanhmuc.ValueMember = "Value";

            //cbdanhmuc.SelectedIndex = 0;
        }
        private void cbdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbdanhmuc.SelectedValue.ToString().Trim() == "0001")
            //{
            //    this.Width = 300;
            //    this.Height = 250;
            //    pncontrol.Controls.Clear();
            //    uctkhachang uc = new uctkhachang();
            //    pncontrol.Controls.Add(uc);
            //}
            //if (cbdanhmuc.SelectedValue.ToString().Trim() == "0002")
            //{
            //    this.Width = 300;
            //    this.Height = 265;
            //    pncontrol.Controls.Clear();
            //    uctnhanvien uc = new uctnhanvien();
            //    pncontrol.Controls.Add(uc);
            //}
            //if (cbdanhmuc.SelectedValue.ToString().Trim() == "0003")
            //{
            //    this.Width = 300;
            //    this.Height = 200;
            //    pncontrol.Controls.Clear();
            //    uctxe uc = new uctxe();
            //    pncontrol.Controls.Add(uc);
            //}
            //if (cbdanhmuc.SelectedValue.ToString().Trim() == "0004")
            //{
            //    this.Width = 300;
            //    this.Height = 200;
            //    pncontrol.Controls.Clear();
            //    ucthoadon uc = new ucthoadon();
            //    pncontrol.Controls.Add(uc);
            //}
            //if (cbdanhmuc.SelectedValue.ToString().Trim() == "0005")
            //{
            //    this.Width = 300;
            //    this.Height = 200;
            //    pncontrol.Controls.Clear();
            //    uchopdong uc = new uchopdong();
            //    pncontrol.Controls.Add(uc);
            //}
        }
    }
}
