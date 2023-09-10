using System;
using System.Collections.Generic;

namespace LabCSharp.Programacion.Class
{
    class claseListas
    {
        private List<int> listaEnteros;
        private List<string> listaCadenas;
        private List<char> listaCaracteres;

        public claseListas() {
            this.listaEnteros = new List<int>();
            this.listaCadenas = new List<string>();
            this.listaCaracteres = new List<char>();
        }

        public void genListaEnterosRandom() {
            Random miRand = new Random();
            int num;

            for (int i=0; i < 100; i++) {
                num = miRand.Next(0, 1000);
                listaEnteros.Add(num);
            }
        }

        public void genListaCadenasRandom() {

        }

        public void genListaCaracteresRandom() {

        }

        public void ordenarListaEnteros() {
            listaEnteros.Sort();
        }

        public void buscarRepetidosListaEnteros() {
            
        }

        public void eliminarRepetidosListaEnteros() {

        }
        
    }
}
