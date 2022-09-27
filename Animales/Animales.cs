using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Animales
    {
        private double tamanio;
        private double peso;
        private string genero;
        private string nombre;

        public double Tamanio { get => tamanio; set => tamanio = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
