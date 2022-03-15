using Appcore.IService;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Service
{
    public class TextoService : BaseServices<String> , ITexto
    {

        TextoModel textoModel;
        public TextoService(TextoModel model) : base(model)
        {
            this.textoModel = model;
        }

        public string Guardar(string text)
        {
            throw new NotImplementedException();
        }
    }
}
