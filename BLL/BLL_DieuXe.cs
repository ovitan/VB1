using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLDVVTHH.DTO;
using QLDVVTHH.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QLDVVTHH.BLL
{
    class BLL_DieuXe
    {
        DAL_DieuXe dx = new DAL_DieuXe();
        public List<DTO_DieuXe> GetAll_DX()
        {
            return dx.GetAll_DX();
        }
        public List<DTO_Xe> Get_TrongLuongXe(DTO_Xe dto)
        {
            return dx.Get_TrongLuongXe(dto);
        }
        public bool Create_DX(DTO_DieuXe DX)
        {
            return dx.Create_DX(DX);
        }
        public bool Update_DX(DTO_DieuXe DXE)
        {
            return dx.Update_DX(DXE);
        }
        public bool Delete_Dxe(string ma_dx)
        {
            return dx.Delete_Dxe(ma_dx);
        }
        public string _Ma_Dieu_Xe_Moi()
        {
            return new DAL_DieuXe()._Ma_Dieu_Xe_Moi();
        }
        public List<DTO_DieuXe> Get_NoiNhan()
        {
            return dx.Get_NoiNhan();
        }
        public List<DTO_DieuXe> Get_NoiGiao()
        {
            return dx.Get_NoiGiao();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<DTO_Xe> Get_List_Xe_DangOBai()
        {
            return dx.Get_List_Xe_DangOBai();
        }
        public List<DTO_NhanVien> Get_List_Xe_Nhan_Vien(DTO_NhanVien nv)
        {
            return dx.Get_List_Xe_Nhan_Vien(nv);
        }
        public List<DTO_DieuXe> _List_Get_NoiNhan(DTO_BangBaoGia bg)
        {
            return dx._List_Get_NoiNhan(bg);
        }
        public List<DTO_DieuXe> _List_Get_NoiGiao(DTO_DieuXe dxx)
        {
            return dx._List_Get_NoiGiao(dxx);
        }
        public List<DTO_DieuXe> _List_Get_Dieu_Xe_By_KhachHang_HopDong(DTO_DieuXe dxx)
        {
            return dx._List_Get_Dieu_Xe_By_KhachHang_HopDong(dxx);
        }
        public bool Delete_Dieu_Xe(DTO_DieuXe dxx)
        {
            return dx.Delete_Dieu_Xe(dxx);
        }
        public float _Get_Tong_Trong_Luong(DTO_DieuXe dxx)
        {
            return dx._Get_Tong_Trong_Luong(dxx);
        }
        public bool Update_Dieu_Xe(DTO_DieuXe DXE)
        {
            return dx.Update_Dieu_Xe(DXE);
        }
        public List<DTO_BangBaoGia> _List_Get_Ma_Bao_Gia(DTO_BangBaoGia bg)
        {
            return dx._List_Get_Ma_Bao_Gia(bg);
        }
    }
}
