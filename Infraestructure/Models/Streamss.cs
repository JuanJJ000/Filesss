using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class Streamss
    {

        private BinaryReader binaryReader;
        private BinaryWriter binaryWriter;
        private string fileName = "activo.txt";
        public Streamss()
        {

        }
        public void Add(string texto)
        {
            try
            {

                using (FileStream fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                {
                    binaryWriter = new BinaryWriter(fileStream);
                    binaryWriter.Write(texto);

                }

            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Mostrar()
        {


        }
    }
}
    
