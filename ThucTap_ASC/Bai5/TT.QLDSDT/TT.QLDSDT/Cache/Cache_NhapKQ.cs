using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.QLDSDT.Cache
{
   public static class Cache_NhapKQ
    {
        private static string maDT;
        private static string tenDT;
        private static string sinhVien;
        private static string hoTenSV;
        private static string giangVien;
        private static string hoTenGV;
        private static string diem;

        public static string MaDT { get => maDT; set => maDT = value; }
        public static string TenDT { get => tenDT; set => tenDT = value; }
        public static string SinhVien { get => sinhVien; set => sinhVien = value; }
        public static string HoTenSV { get => hoTenSV; set => hoTenSV = value; }
        public static string GiangVien { get => giangVien; set => giangVien = value; }
        public static string HoTenGV { get => hoTenGV; set => hoTenGV = value; }
        public static string Diem { get => diem; set => diem = value; }
    }
}
