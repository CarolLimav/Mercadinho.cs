using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Models
{
    public class Alimentos: Produto
    {
        public double Peso { get; set; }

        public SubtipoAlimentos subtipoAlimentos { get; set; }

        public Alimentos():  base() 
        { 
           
        }
    }
}
