using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.QLDSDT.Data;

namespace TT.QLDSDT
{
   public class Data_QuanLyDanhSachDeTai
    {
        ThucTapDataContext db = new ThucTapDataContext();
        #region Hiển thị danh sách đề tài
        public List<TBLDeTai> getDanhSachDeTai()
        {
            var ds = db.TBLDeTais.ToList();
            return ds;
        }
        #endregion
        #region Tìm kiếm đề tài
        public List<TBLDeTai> TimKiemDeTai(string pTendt,string pKinhPhiStart,string pKinhPhiEnd,string pNoiThucTap)
        {

            if(pKinhPhiStart.Length==0 && pKinhPhiEnd.Length==0)//chua nhap kinh phi
            {
                var TimKiemKhongKinhPhi = db.TBLDeTais.Where(m => m.Tendt.Contains(pTendt) && m.Noithuctap.Contains(pNoiThucTap)).ToList();
                return TimKiemKhongKinhPhi;
            }
            if(pKinhPhiEnd.Length==0 && pKinhPhiStart.Length!=0)//nhap kinh phi batdau
            {
                var TimKimCoKinhPhiBatDau= db.TBLDeTais.Where(m => m.Tendt.Contains(pTendt) && m.Noithuctap.Contains(pNoiThucTap)
             && m.Kinhphi >= int.Parse(pKinhPhiStart)).ToList();
                return TimKimCoKinhPhiBatDau;
            }
            if(pKinhPhiEnd.Length != 0 && pKinhPhiStart.Length == 0)//chỉ có kinh phí end
            {
                var TimKimCoKinhPhiEnd = db.TBLDeTais.Where(m => m.Tendt.Contains(pTendt) && m.Noithuctap.Contains(pNoiThucTap)
              && m.Kinhphi <= int.Parse(pKinhPhiEnd)).ToList();
                return TimKimCoKinhPhiEnd;
            }
            else
            {
                var TimKiem = db.TBLDeTais.Where(m => m.Tendt.Contains(pTendt) && m.Noithuctap.Contains(pNoiThucTap)
            && m.Kinhphi >= int.Parse(pKinhPhiStart) && m.Kinhphi <= int.Parse(pKinhPhiEnd)).ToList();
                return TimKiem;
            }
        }

        #endregion
        #region Kiểm tra trùng
        public bool KTraTrungMaDT(string pMadt)
        {
            TBLDeTai dt = db.TBLDeTais.FirstOrDefault(c => c.Madt == pMadt);
            if (dt == null)//Không trùng
            {
                return false;
            }
            return true;//trùng
        }
        public bool KTraTrungMaDTHuongDan(string pMadt)
        {
            TBLHuongDan hd = db.TBLHuongDans.FirstOrDefault(c => c.Madt == pMadt);
            if (hd == null)//Không trùng
            {
                return false;
            }
            return true;//trùng
        }
        #endregion
        #region Thêm mới đề tài
        public bool Them(string pMadt, string pTendt, int pKinhPhi, string pNoiThucTap)
        {
            try
            {
                TBLDeTai dt = new TBLDeTai();
                dt.Madt = pMadt;
                dt.Tendt = pTendt;
                dt.Kinhphi = pKinhPhi;
                dt.Noithuctap = pNoiThucTap;
                db.TBLDeTais.InsertOnSubmit(dt);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Sửa đề tài
        //Load thông tin đề tài cần sửa
        public TBLDeTai GetDeTaiSua(string pMadt)
        {
            TBLDeTai dt = db.TBLDeTais.Single(s => s.Madt == pMadt);
            return dt;
        }
        //Sửa
        public bool Sua(string pMadt, string pTendt, int pKinhPhi, string pNoiThucTap)
        {
            try
            {
                TBLDeTai dt = db.TBLDeTais.Single(c => c.Madt == pMadt.Trim());
                dt.Tendt = pTendt;
                dt.Kinhphi = pKinhPhi;
                dt.Noithuctap = pNoiThucTap;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region Xóa đề tài
        public bool Xoa(string pMadt)
        {
            try
            {
                TBLDeTai dt = db.TBLDeTais.Single(c => c.Madt == pMadt.Trim());
                db.TBLDeTais.DeleteOnSubmit(dt);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
