using DevelopmentChallenge.Data.Interface;
using DevelopmentChallenge.Data.Utility;
using DevelopmentChallenge.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Repository.Services
{
    public class Reporting : IReporting
    {
        public string GetFormaTraducida(ILenguaje lenguaje) => lenguaje.Forma;
        public string GetEmptyResult(ILenguaje lenguaje) => lenguaje.MsjListaVacia;
        public string GetHeader(ILenguaje lenguaje) => lenguaje.MsjHeader;
        public string GetBody(ITraductorFiguras Forma, ILenguaje lenguaje, int cantidad, decimal area, decimal perimetro)
        {
            return $"{cantidad} {Helper.GetPluralString(Forma.GetNombreFiguraTraducida(lenguaje), cantidad)} | {lenguaje.Area} {area:#.##} | {lenguaje.Perimetro} {perimetro:#.##} <br/>";
        }
        public string GetFooter(int TotalShapes, ILenguaje idioma, decimal totalPerimeters, decimal totalAreas)
        {
            return $"TOTAL:<br/>{TotalShapes} {idioma.Forma} {idioma.Perimetro} {totalPerimeters.ToString("#.##")} {idioma.Area} {totalAreas.ToString("#.##")}";
        }
    }
}
