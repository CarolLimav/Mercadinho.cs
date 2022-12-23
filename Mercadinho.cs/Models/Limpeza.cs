using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Models
{
    public class Limpeza:Produto
    {
        //atributos diferentes que a classe limpeza tem da classe produto 
        public double? Peso { get; set; }
        public double? Volume { get; set; }
        public SubtipoLimpeza subtipoLimpeza { get; set; }

        public Limpeza(): base()
        {

        }

    }
}
