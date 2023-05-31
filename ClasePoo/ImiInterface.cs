using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePoo
{
    internal interface ImiInterface
    {
        string MiPropiedad { get; }

        string MiMetodo();

        event Action evento;

        string this[int index]
        {
            get;
        }
    }
}
