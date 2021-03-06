﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDVVTHH.UC_TIMKIEM;
using QLDVVTHH.BLL;
using QLDVVTHH.UI;

namespace QLDVVTHH.UC_TIMKIEM
{
    public partial class uctnhanvien : UserControl
    {
        public uctnhanvien()
        {
            InitializeComponent();
        }

        private void btntruyvan_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in Main.ActiveForm.MdiChildren)
            {
                if (mdiChild.Name == "frmTimKetQua")
                {
                    mdiChild.Activate();
                    mdiChild.Close();
                }
            }
            frmTimKetQua uc = new frmTimKetQua();
            uc._truyvan = "nhanvien";
            uc._key_name = txttenhanvien.Text.Trim();
            uc._Key_id = txtmanhanvien.Text.Trim();
            uc.MdiParent = Main.ActiveForm;
            uc.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in Main.ActiveForm.MdiChildren)
            {
                if (mdiChild.Name == "frmTimKetQua")
                {
                    mdiChild.Activate();
                    mdiChild.Close();
                }
            }
            foreach (Form mdiChild in Main.ActiveForm.MdiChildren)
            {
                if (mdiChild.Name == "frmTimKiem")
                {
                    mdiChild.Activate();
                    mdiChild.Close();
                }
            }
        }

        private void txttenhanvien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                foreach (Form mdiChild in Main.ActiveForm.MdiChildren)
                {
                    if (mdiChild.Name == "frmTimKetQua")
                    {
                        mdiChild.Activate();
                        mdiChild.Close();
                    }
                }
                frmTimKetQua uc = new frmTimKetQua();
                uc._truyvan = "nhanvien";
                uc._key_name = txttenhanvien.Text.Trim();
                uc._Key_id = txtmanhanvien.Text.Trim();
                uc.MdiParent = Main.ActiveForm;
                uc.Show();
            }
        }

        private void txtmanhanvien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                foreach (Form mdiChild in Main.ActiveForm.MdiChildren)
                {
                    if (mdiChild.Name == "frmTimKetQua")
                    {
                        mdiChild.Activate();
                        mdiChild.Close();
                    }
                }
                frmTimKetQua uc = new frmTimKetQua();
                uc._truyvan = "nhanvien";
                uc._key_name = txttenhanvien.Text.Trim();
                uc._Key_id = txtmanhanvien.Text.Trim();
                uc.MdiParent = Main.ActiveForm;
                uc.Show();
            }
        }
    }
}
