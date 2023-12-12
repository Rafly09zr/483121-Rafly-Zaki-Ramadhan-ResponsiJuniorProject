using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESPONSI_483121
{
    public class Manager : Karyawan
    {
        private string departement;

        public string Departement
        {
            get { return departement; }
            set { departement = value; }
        }

        public Manager(string name, string departement) : base(name)
        {
            Departement = departement;
        }
    }
}
