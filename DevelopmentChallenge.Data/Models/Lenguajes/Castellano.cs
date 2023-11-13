using DevelopmentChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models.Lenguajes
{
    public class Castellano : ILenguaje
    {
        public string Nombre => "Castellano";
        public string Forma => "formas";
        public string Area => "Area";
        public string Perimetro => "Perimetro";
        public string MsjListaVacia => "Lista vacía de formas!";
        public string MsjHeader => "Reporte de Formas";
    }
}
