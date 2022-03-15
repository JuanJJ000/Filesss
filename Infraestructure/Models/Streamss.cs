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

        private BinaryReader binaryReader;
        private BinaryWriter binaryWriter;
        private string fileName = "archivo.txt";
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

        public string Guardar(string text)
        {
            throw new NotImplementedException();
        }

       

        public string Read(string t)
        {
            
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    binaryReader = new BinaryReader(fileStream);
                    long length = binaryReader.BaseStream.Length;

                    if (length == 0)
                    {
                        return t;
                    }
                    binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (binaryReader.BaseStream.Position < length)
                    {

                        t = binaryReader.ReadString();
                            
                        
                    }
                }
                return t;
            }
            catch (IOException)
            {
                throw;
            }
        }

  
    }
}
    
