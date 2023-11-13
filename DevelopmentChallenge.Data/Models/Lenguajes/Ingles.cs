using DevelopmentChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models.Lenguajes
{
    public class Ingles : ILenguaje
    {
        public string Nombre => "Ingles";
        public string Forma => "shapes";
        public string Area => "Area";
        public string Perimetro => "Perimeter";
        public string MsjListaVacia => "Empty list of shapes!";
        public string MsjHeader => "Shapes report";
    }
}
