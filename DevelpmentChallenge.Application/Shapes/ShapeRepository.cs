using DevelopmentChallenge.Data.DataMock;
using DevelopmentChallenge.Data.Models.Formas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelpmentChallenge.Application.Shapes
{
    public class ShapeRepository : IShapeRepository
    {
        public ICollection<FiguraGeometrica> GetAll() => ShapesReportDataMock.GetDistintasFormasCompleta();

    }
}
