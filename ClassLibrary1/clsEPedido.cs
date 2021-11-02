using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class clsEPedido
    {
        public int idPedido { get; set; }
        public string FechaInicial { get; set; }
        public string FechaLimite { get; set; }
        public int cantSoli { get; set; }
        public int cantAsig { get; set; }
        public int idCliente { get; set; }

        public clsEPedido()
        {

        }
    }
}
