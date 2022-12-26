using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF
{
    public class Unit
    {
        public int _value { get; set; }
        public string _display { get; set; }
        public Unit()
        {

        }
        public Unit(int _val, string _dis)
        {
            this._value = _val;
            this._display = _dis;
        }
        public static List<Unit> getList()
        {
            List<Unit> lst = new List<Unit>();
            Unit[] collect = new Unit[3]
            {
                new Unit(1,"Cốc"),
                new Unit(2,"Đĩa"),
                new Unit(3,"Gói")
            };
            lst.AddRange(collect);
            return lst;
        }
    }
}
