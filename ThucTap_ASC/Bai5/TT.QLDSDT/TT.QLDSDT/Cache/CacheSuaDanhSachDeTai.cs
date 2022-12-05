using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.QLDSDT.Cache
{
   public static class CacheSuaDanhSachDeTai
    {
        private static string madtSua;

        public static string MadtSua { get => madtSua; set => madtSua = value; }
    }
}
