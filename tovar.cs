using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLab1
{
    public class tovar
    {
        public string Name { get; set; }
        public int kol { get; set; }
        public float stoim { get; set; }
        public tovar (string Name,int kol,float stoim)
        {
            this.Name = Name;
            this.kol = kol;
            this.stoim = stoim;
        }
    }
}
