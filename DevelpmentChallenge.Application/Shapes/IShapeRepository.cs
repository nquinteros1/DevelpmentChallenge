using DevelopmentChallenge.Data.Models.Formas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelpmentChallenge.Application.Shapes
{
    public interface IShapeRepository
    {
        ICollection<FiguraGeometrica> GetAll();
    }
}
