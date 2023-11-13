using DevelopmentChallenge.Data.Interface;
using DevelopmentChallenge.Data.Models.Formas;
using DevelopmentChallenge.Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Repository.Interfaces
{
    public interface IReporteFigurasService
    {
        IEnumerable<ReporteFigura> GetReportes(ILenguaje idioma);
        ICollection<FiguraGeometrica> GetAll();
        string GetReporteImprimible(ILenguaje idioma);
        string Imprimir(List<FiguraGeometrica> formas, ILenguaje idioma);

    }
}
