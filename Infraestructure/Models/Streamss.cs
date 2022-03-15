using Domain.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class Streamss : TextoModel
    {
        private BinaryWriter binaryWriter;
    
        public Streamss()
        {

        }
        public void Add(string texto, string ruta)
        {
            try
            { 
                using (FileStream fileStream = new FileStream(ruta, FileMode.Append, FileAccess.Write))
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

        public string Guardar(string text)
        {
            throw new NotImplementedException();
        }

       

        public string Read(string t)
        {
            
          string text= string.Empty;
           
            try
            {

                text = File.ReadAllText(t);

                return text;
            }
            catch (IOException)
            {

                throw;
            }
            
        }

  
    }
}
    
