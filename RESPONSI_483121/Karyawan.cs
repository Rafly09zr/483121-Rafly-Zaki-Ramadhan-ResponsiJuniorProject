using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESPONSI_483121
{
    //Base Class and Encapsulation
    public class Karyawan
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Karyawan(string name)
        {
            Name = name;
        }
    }
}
