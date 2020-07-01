using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCSharp.Programacion.Class
{
    class claseCodificacion
    {
        private List<int> palabraCodificada;

        public claseCodificacion()
        {
            this.palabraCodificada = new List<int>();
        }

        public string generarPalabra(int numDecimal)
        {
            string palabra="palabra";

            int resto;
            int cociente;
            int binario = 0;
            int x = 1;

            while (numDecimal > 0)
            {
                if ((numDecimal % 2) == 1)
                {
                    binario = binario + x;
                }
                //numDecimal = Math.Truncate(numDecimal / 2);
                x = x * 10;

            }

            return palabra;
        }
        

    }
}
