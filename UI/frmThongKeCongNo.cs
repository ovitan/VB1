using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDVVTHH.DTO;
using QLDVVTHH.BLL;

namespace QLDVVTHH.UI
{
    public partial class frmThongKeCongNo : Form
    {
        public frmThongKeCongNo()
        {
            InitializeComponent();
            _Load_CongNo();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKeCongNo_Load(object sender, EventArgs e)
        {
            _Load_CongNo();
        }
        private void _Load_CongNo()
        {
            DTO_CongNo dto = new DTO_CongNo();
            lvthongkecongno.Items.Clear();
            if (new BLL_CongNo()._Thong_Ke_Cong_No(dto) != null)
            {
                int STT = 1;
                foreach (DTO_CongNo cn in new BLL_CongNo()._Thong_Ke_Cong_No(dto))
                {
                    ListViewItem item = new ListViewItem(STT.ToString());

                    ListViewItem.ListViewSubItem it1 = new ListViewItem.ListViewSubItem(item,cn.ma_khach_hang);
                    item.SubItems.Add(it1);
                    ListViewItem.ListViewSubItem it2 = new ListViewItem.ListViewSubItem(item, cn.tenkhachhang);
                    item.SubItems.Add(it2);
                    ListViewItem.ListViewSubItem it3 = new ListViewItem.ListViewSubItem(item, cn.ma_hop_dong);
                    item.SubItems.Add(it3);
                    ListViewItem.ListViewSubItem it4 = new ListViewItem.ListViewSubItem(item, cn.tongno.ToString("###,###,###"));
                    item.SubItems.Add(it4);
                    ListViewItem.ListViewSubItem it5 = new ListViewItem.ListViewSubItem(item, cn.tongtra.ToString("###,###,###"));
                    item.SubItems.Add(it5);
                    ListViewItem.ListViewSubItem it6 = new ListViewItem.ListViewSubItem(item, (cn.tongno-cn.tongtra).ToString("###,###,###"));
                    item.SubItems.Add(it6);
                    ListViewItem.ListViewSubItem it7 = new ListViewItem.ListViewSubItem(item, "VNĐ");
                    item.SubItems.Add(it7);

                    lvthongkecongno.Items.Add(item);
                    STT++;
                }
            }
        }
    }
}
