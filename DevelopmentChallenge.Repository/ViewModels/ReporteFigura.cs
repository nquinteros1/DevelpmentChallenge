using DevelopmentChallenge.Data.Interface;
using DevelopmentChallenge.Data.Models.Formas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Repository.ViewModels
{
    public class ReporteFigura
    {
        public ILenguaje Lenguaje { get; set; }
        public FiguraGeometrica Figura { get; set; }
        public int CantidadDeFormas { get; set; }
        public decimal SumaAreaForma { get; set; }
        public decimal SumaPerimetroForma { get; set; }
    }
}
