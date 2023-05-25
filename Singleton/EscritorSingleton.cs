using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Singleton
{
    internal class EscritorSingleton
    {
        private static EscritorSingleton instancia;
        private static readonly object bloqueo = new object();

        private EscritorSingleton() { 
        }

        public static EscritorSingleton Instancia { 
            get
            {
                if (instancia == null)
                {
                    lock(bloqueo)
                    {
                        if (instancia == null) { 
                            instancia = new EscritorSingleton();
                        }
                    }
                }
                return instancia;
            }
        }

        public void EscribirMensaje(string mensaje) {
            System.IO.StreamWriter arc = new StreamWriter(@"c:\temp\singleton.txt", true);
            arc.WriteLine(DateTime.Now.ToShortTimeString() + " : " + mensaje.ToUpper());
            arc.Close();
            return;
        }






    }
}
