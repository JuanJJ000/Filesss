using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.IServices
{
    public interface IServices<T>
    {

        void Add(T t);
        string Read(T t);

    }
}
