using System;

namespace LabCSharp.Class
{
    class GenAleatorio
    {
        public Random Rand;
        public GenAleatorio()
        {

        }

        public String GenerarCadena(int longitud)
        {
            string cad = null;
            char caracter;
            int i = 0;
            Rand = new Random();
            while (i < longitud){
                int valor = Rand.Next(0, 127);
                caracter = (char) valor;
                cad = cad + caracter;
                i++;
            }

            return (cad);
        }

        public int[] GenerarCadenaNumerica(int longitud)
        {
            int[] cad;
            cad = new int[longitud - 1];
            Rand = new Random();

            int i = 0;
            while (i < longitud)
            {
                int valor = Rand.Next(0, 9);
                cad[i] = valor;
                i++;
            }
            return (cad);
        }

        public int[] GenerarCadenaBinaria(int longitud)
        {
            int[] cad;
            cad = new int[longitud - 1];
            Rand = new Random();

            int i = 0;
            while (i < longitud)
            {
                int valor = Rand.Next(0, 1);
                cad[i] = valor;
                i++;
            }
            return (cad);
        }
    }
}
