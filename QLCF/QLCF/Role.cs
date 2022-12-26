using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF
{
    public class Role
    {
        public int _value { get; set; }
        public string _display { get; set; }
        public Role()
        {

        }
        public Role(int _val, string _dis)
        {
            this._value = _val;
            this._display = _dis;
        }
        public static List<Role> getList()
        {
            List<Role> lst = new List<Role>();
            Role[] collect = new Role[3]
            {
                new Role(1,"Thu Ngân"),
                new Role(2,"Quản lí"),
                new Role(3,"Pha Chế")
            };
            lst.AddRange(collect);
            return lst;
        }
    }
}
