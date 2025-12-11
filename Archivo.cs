using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWF
{
    
    internal class Archivo
    {
        //public string nombreArchivo = "Historial.dat";

        public static void GuardarOperacion(string operacion, string nombreArchivo)
        {
            using(FileStream fs = new FileStream(nombreArchivo, FileMode.OpenOrCreate))
            using(BinaryWriter Writer = new BinaryWriter(fs))
            {
                fs.Seek(0, SeekOrigin.End);
                Writer.Write(operacion);
            }
        }

        public static List<string> ObtenerOperaciones(string nombreArchivo)
        {
            List<string> operaciones = new List<string>();

            if (!File.Exists(nombreArchivo))
                return operaciones;

            using(FileStream fs = new FileStream(nombreArchivo, FileMode.Open))
            using(BinaryReader Reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    try
                    {
                        string operacion = Reader.ReadString();
                        operaciones.Add(operacion);
                    }
                    catch (EndOfStreamException)
                    {
                        break;
                    }
                }
            }

            return operaciones;
        }

        
    }
}
