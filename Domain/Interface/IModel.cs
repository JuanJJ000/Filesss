using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IModel<T>
    {
        void Add(T t);
        void Read(T t);

    }
}
