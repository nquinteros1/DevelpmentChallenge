using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interface
{
    public interface ILenguaje
    {
        string Nombre { get; }
        string Forma { get; }
        string Area { get; }
        string Perimetro { get; }
        string MsjListaVacia { get; }
        string MsjHeader { get; }
    }
}
