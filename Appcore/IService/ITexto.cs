using Appcore.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.IService
{
    public interface ITexto : IServices<String>
    {

        String  Guardar(string text);

    }
}
