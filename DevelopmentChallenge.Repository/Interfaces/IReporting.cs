using DevelopmentChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Repository.Interfaces
{
    public interface IReporting
    {
        string GetFormaTraducida(ILenguaje lenguaje);
        string GetEmptyResult(ILenguaje lenguaje);
        string GetHeader(ILenguaje lenguaje);
        string GetBody(ITraductorFiguras Forma, ILenguaje lenguaje, int cantidad, decimal area, decimal perimetro);
        string GetFooter(int TotalShapes, ILenguaje idioma, decimal totalPerimeters, decimal totalAreas);

    }
}
