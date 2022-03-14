using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Objetos
    {
       public string Texto { get; set; }

        public Objetos(string a)
        {
            this.Texto = a;
        }
    }
}
