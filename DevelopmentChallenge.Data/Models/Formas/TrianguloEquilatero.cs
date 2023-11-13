using DevelopmentChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models.Formas
{
    public class TrianguloEquilatero : FiguraGeometrica
    {
        public override string Name => "Triángulo";
        public override decimal Width { get; set; }
        public override decimal GetArea() => ((decimal)Math.Sqrt(3) / 4) * (Width * Width);
        public override decimal GetPerimetro() => Width * 3;
        public override string GetNombreFiguraTraducida(ILenguaje idioma)
        {
            switch (idioma.Nombre)
            {
                case "Ingles":
                    return "Triangle";
                case "Frances":
                    return "Triangle";
            }
            return Name;
        }
    }
}
