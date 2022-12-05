using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.QLDSDT.Data;

namespace TT.QLDSDT
{
   public class Data_QuanLyDanhSachHuongDanDeTai
    {
        ThucTapDataContext db = new ThucTapDataContext();
        #region load Danh sách hướng dẫn
        public object GetBLHuongDans()
        {
            var ds = (from hd in db.TBLHuongDans
                      join sv in db.TBLSinhViens on hd.Masv equals sv.Masv
                      join gv in db.TBLGiangViens on hd.Magv equals gv.Magv
                      join dt in db.TBLDeTais on hd.Madt equals dt.Madt
                      select new { sv.Makhoa, sv.Masv, sv.Hotensv, gv.Magv, gv.Hotengv, dt.Madt, dt.Tendt, hd.KetQua }
                    );
            return ds;
        }
        #endregion

        #region Combobox
        //Trạng thái
        public List<string> getCBB_TrangThai()
        {
            string[] s = { "Tất cả", "Đã có điểm", "Chưa có điểm" };
            List<string> lsTT = new List<string>(s);
            return lsTT;
        }
        //Mã đề tài
        public List<TBLDeTai> getCBB_MaDeTai()
        {
            var ds = db.TBLDeTais.ToList();
            return ds;
        }
        //Sinh viên
        public List<TBLSinhVien> getCBB_SinhVien()
        {
            var ds = db.TBLSinhViens.ToList();
            return ds;
        }
        //Giảng viên
        public List<TBLGiangVien> getCBB_GiangVien()
        {
            var ds = db.TBLGiangViens.ToList();
            return ds;
        }
        #endregion

        #region Tim kiếm đề tài
        public object TimKiemHuongDanDeTai(string pTendt, string pGiangVien, string pSinhVien, string pTrangThai)
        {

            if (pTrangThai== "Tất cả")//tất cả
            {
                var ds = (from hd in db.TBLHuongDans
                          join sv in db.TBLSinhViens on hd.Masv equals sv.Masv
                          join gv in db.TBLGiangViens on hd.Magv equals gv.Magv
                          join dt in db.TBLDeTais on hd.Madt equals dt.Madt
                          where dt.Tendt.Contains(pTendt) && gv.Hotengv.Contains(pGiangVien) 
                          && sv.Hotensv.Contains(pSinhVien)
                          select new { sv.Makhoa, sv.Masv, sv.Hotensv, gv.Magv, gv.Hotengv, dt.Madt, dt.Tendt, hd.KetQua }
                    );
                return ds;
            }
            if (pTrangThai== "Đã có điểm")//đã có điểm
            {
                var ds = (from hd in db.TBLHuongDans
                          join sv in db.TBLSinhViens on hd.Masv equals sv.Masv
                          join gv in db.TBLGiangViens on hd.Magv equals gv.Magv
                          join dt in db.TBLDeTais on hd.Madt equals dt.Madt
                          where dt.Tendt.Contains(pTendt) && gv.Hotengv.Contains(pGiangVien)
                          && sv.Hotensv.Contains(pSinhVien) && hd.KetQua!=null
                          select new { sv.Makhoa, sv.Masv, sv.Hotensv, gv.Magv, gv.Hotengv, dt.Madt, dt.Tendt, hd.KetQua }
                    );
                return ds;
            }
            else//Chưa có điểm
            {
                var ds = (from hd in db.TBLHuongDans
                          join sv in db.TBLSinhViens on hd.Masv equals sv.Masv
                          join gv in db.TBLGiangViens on hd.Magv equals gv.Magv
                          join dt in db.TBLDeTais on hd.Madt equals dt.Madt
                          where dt.Tendt.Contains(pTendt) && gv.Hotengv.Contains(pGiangVien)
                          && sv.Hotensv.Contains(pSinhVien) && hd.KetQua == null
                          select new { sv.Makhoa, sv.Masv, sv.Hotensv, gv.Magv, gv.Hotengv, dt.Madt, dt.Tendt, hd.KetQua }
                   );
                return ds;
            }
        }
        #endregion

        #region kiểm tra trùng
        public bool KTraTrungHuongDanDeTai(int pMasv)
        {
            TBLHuongDan dt = db.TBLHuongDans.FirstOrDefault(c => c.Masv == pMasv);
            if (dt == null)//Không trùng
            {
                return false;
            }
            return true;//trùng
        }
        #endregion

        #region Them moi
        public bool Them(int pMasv,string pMadt,int pMagv)
        {
            try
            {
                TBLHuongDan hd = new TBLHuongDan();
                hd.Masv = pMasv;
                hd.Madt = pMadt;
                hd.Magv = pMagv;
                db.TBLHuongDans.InsertOnSubmit(hd);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Xóa
        public bool Xoa(int pMasv)
        {
            try
            {
                TBLHuongDan dt = db.TBLHuongDans.Single(c => c.Masv == pMasv);
                db.TBLHuongDans.DeleteOnSubmit(dt);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region nhập kết quả
        public bool NhapKQ(int pMasv,string pDiem)
        {
            try
            {
                TBLHuongDan hd = db.TBLHuongDans.Single(c => c.Masv == pMasv);
                hd.KetQua = decimal.Parse(pDiem);
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
