using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePoo
{
    public class MiClase: ImiInterface, ImiOtraInterface
    {

        public string MiPropiedad
        {
            get { return "Desde propiedad"; }
        }

        public string MiMetodo()
        {
            return "Desde metodo";
        }

        string ImiOtraInterface.MiMetodo()
        {
            return "Desde metodo explicito";
        }


        public string this[int index]
        {
            get { return "Retorno algo desde indexador"; }
        }

        public event Action evento;

    }
}
