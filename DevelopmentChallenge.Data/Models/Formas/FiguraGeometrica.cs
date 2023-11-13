using DevelopmentChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models.Formas
{
    public abstract class FiguraGeometrica : IFiguraGeometrica, ITraductorFiguras
    {
        public abstract string Name { get; }
        public abstract decimal Width { get; set; }
        public abstract decimal GetArea();
        public abstract decimal GetPerimetro();
        public abstract string GetNombreFiguraTraducida(ILenguaje idioma);
    }
}
