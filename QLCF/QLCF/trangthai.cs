using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF
{
    public class trangthai
    {
        public int _value { get; set; }
        public string _display { get; set; }
        public trangthai()
        {

        }
        public trangthai(int _val, string _dis)
        {
            this._value = _val;
            this._display = _dis;
        }
        public static List<trangthai> getList()
        {
            List<trangthai> lst = new List<trangthai>();
            trangthai[] collect = new trangthai[2]
            {
                new trangthai(1,"Áp Dụng"),
                new trangthai(2,"Hết Hạn")
                
            };
            lst.AddRange(collect);
            return lst;
        }
    }
}
