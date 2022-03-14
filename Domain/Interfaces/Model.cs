using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface Model<H>
    {
        void Add(H y);
        void Delete(H z);
        List<H> Read();
    }
}
