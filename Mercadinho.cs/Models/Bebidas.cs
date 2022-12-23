using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Models
{
    public class Bebidas: Produto
    {
        public double Volume { get; set; }  
        public SubtipoBebidas subtipoBebidas { get; set; }  


        public Bebidas(): base()
        {

        }

    }
}
