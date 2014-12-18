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

namespace QLDVVTHH.UI
{
    public partial class frmInAn : Form
    {
        private int originalWidth;
        private int originalHeight;
        public frmInAn(DTO_ResizeForm rz)
        {
            InitializeComponent();
            _Load_Combobox();
            DTO_ResizeForm rs = rz;
            originalHeight = rs.CHIEU_CAO;
            originalWidth = rs.CHIEU_DAI;
            cbdanhmuc.SelectedValue = rs.Index;
            if (cbdanhmuc.SelectedValue.ToString() == "0001")
            {
                pncontrol.Controls.Clear();
                uckhachhang uc = new uckhachhang();
                pncontrol.Controls.Add(uc);
                this.Width = 214;
                this.Height = 130;
            }
          
        }
        private void _Load_Combobox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Value");
            DataRow row = dt.NewRow();
            row["Text"] = "In Danh Sách Khách Hàng";
            row["Value"] = "0001";
            dt.Rows.InsertAt(row, 0);

            //DataRow row2 = dt.NewRow();
            //row2["Text"] = "In Danh Sách Nhân Viên";
            //row2["Value"] = "0002";
            //dt.Rows.InsertAt(row2, 0);

            //DataRow row3 = dt.NewRow();
            //row3["Text"] = "In Danh Sách Xe ";
            //row3["Value"] = "0003";
            //dt.Rows.InsertAt(row3, 0);

            //DataRow row4 = dt.NewRow();
            //row4["Text"] = "In Hóa Đơn ";
            //row4["Value"] = "0004";
            //dt.Rows.InsertAt(row4, 0);
          

            cbdanhmuc.DataSource = dt;
            cbdanhmuc.DisplayMember = "Text";
            cbdanhmuc.ValueMember = "Value";

            cbdanhmuc.SelectedIndex = 0;

        }

        private void cbdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdanhmuc.SelectedValue.ToString().Trim() == "0001")
            {
                this.Width = 214;
                this.Height = 130;
                pncontrol.Controls.Clear();
                uckhachhang uc = new uckhachhang();
                pncontrol.Controls.Add(uc);
            }
            //if (cbdanhmuc.SelectedValue.ToString().Trim() == "0002")
            //{
            //    this.Width = 214;
            //    this.Height = 100;
            //    pncontrol.Controls.Clear();
            //    ucnhanvien uc = new ucnhanvien();
            //    pncontrol.Controls.Add(uc);
            //}
            //if (cbdanhmuc.SelectedValue.ToString().Trim() == "0003")
            //{
            //    this.Width = 214;
            //    this.Height = 100;
            //    pncontrol.Controls.Clear();
            //    ucxe uc = new ucxe();
            //    pncontrol.Controls.Add(uc);
            //}
            //if (cbdanhmuc.SelectedValue.ToString().Trim() == "0004")
            //{
            //    this.Width = 214;
            //    this.Height = 250;
            //    pncontrol.Controls.Clear();
            //    uchoadon uc = new uchoadon();
            //    pncontrol.Controls.Add(uc);
            //}
        }
    }
}
