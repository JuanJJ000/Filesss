using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IModel<T>
    {
        void Add(T t, T g);
        string Read(T t);
      
    }
}
