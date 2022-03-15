using Appcore.IService;
using Appcore.Service;
using Autofac;
using Domain.Interface;
using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ContainerBuilder();
            builder.RegisterType<Streamss>().As<TextoModel>();
            builder.RegisterType<TextoService>().As<ITexto>();
            var container = builder.Build();
            Application.Run(new Formulario1(container.Resolve<ITexto>()));
        }
    }
}
