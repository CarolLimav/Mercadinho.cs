using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Models
{
    public abstract class Produto
    {
        //classe base
        //atributos

        public string Codigo { get; set; }
        public DateTime DataEntrada { get; set; }
        public int Quantidade { get; set; }
        public enum SubtipoAlimentos
        {
            Carnes=0,
            Hortaliças,
            Laticinios, 
            Pães,
            Biscoitos,
        }

        public enum SubtipoBebidas
        {
            Alcoolicas=0,
            Condensadas,
            Naturais,
        }

        public enum SubtipoLimpeza
        {
            EmBarra=0,
            AguaSanitaria,
            EmPo,
        }

        //Construtor
        public Produto(string Codigo, DateTime DataEntrada, int Quantidade)
        {
            this.Codigo = Codigo;
            this.Quantidade = Quantidade;
            this.DataEntrada = DataEntrada;
        }

        protected Produto()
        {
        }
    }
}
