using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Models
{
    public class Estoque
    {
        public List<Bebidas> ListaBebidas= new List<Bebidas>();
        public List<Alimentos> ListaAlimentos = new List<Alimentos>();
        public List<Limpeza> ListaLimpeza = new List<Limpeza>();

        //metodos: Cadastrar, listar, solicitar 

        public void Cadastrar()
        {
            int op;
            int opvolume= int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Digite qual produto deseja cadastrar:");
                Console.WriteLine("1- Alimentos\n 2- Bebidas\n 3- Limpeza");
                op= int.Parse(Console.ReadLine());


                //switch para o tipo de alimento 

                switch (op)
                {
                    case 1:
                    //criaçao de um objeto para pegar os atributos
                    Alimentos novoAlimento= new Alimentos();

                        Console.WriteLine("Qual o codigo do produto?");
                        novoAlimento.Codigo = Console.ReadLine();
                        Console.WriteLine("Qual a data de entrada?");
                        novoAlimento.DataEntrada = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade:");
                        novoAlimento.Quantidade= int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o peso:");
                        novoAlimento.Peso= double.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o tipo de alimento:\n 1- Carnes\n 2- Hortaliças\n 3- Biscoitos\n 4- Laticionios\n 5- Paes\n ");
                        int opcao= int.Parse(Console.ReadLine());
                        //switch para os subtipos de alimentos
                        switch (opcao)
                        {
                            case 1:
                                novoAlimento.subtipoAlimentos = Produto.SubtipoAlimentos.Carnes;
                                break;
                            case 2:
                                novoAlimento.subtipoAlimentos= Produto.SubtipoAlimentos.Hortaliças; 
                                break;
                            case 3:
                                novoAlimento.subtipoAlimentos = Produto.SubtipoAlimentos.Biscoitos;
                                break;
                            case 4:
                                novoAlimento.subtipoAlimentos = Produto.SubtipoAlimentos.Laticinios;
                                break;
                           case 5:
                                novoAlimento.subtipoAlimentos = Produto.SubtipoAlimentos.Pães;
                                break;
                        }

                        ListaAlimentos.Add(novoAlimento);
                        break;
                    case 2: 
                         Bebidas novaBebidas= new Bebidas();
                        Console.WriteLine("Qual o codigo do produto:");
                        novaBebidas.Codigo = Console.ReadLine();
                        Console.WriteLine("Qual a data de entrada?");
                        novaBebidas.DataEntrada = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade:");
                        novaBebidas.Quantidade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o volume:");
                        novaBebidas.Volume= double.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o tipo de bebida:\n 1- Alcoolicas\n 2- Condensadas\n 3- Naturais\n");
                        int opcao2= int.Parse(Console.ReadLine());

                        //switch para os subtipos de bebidas 
                        switch (opcao2)
                        {
                            case 1:
                                novaBebidas.subtipoBebidas=Produto.SubtipoBebidas.Alcoolicas; 
                                break;
                            case 2:
                                novaBebidas.subtipoBebidas = Produto.SubtipoBebidas.Condensadas;
                                break;
                            case 3:
                                novaBebidas.subtipoBebidas= Produto.SubtipoBebidas.Naturais; 
                                break;
                        }
                        ListaBebidas.Add(novaBebidas);
                        break;
                    case 3:
                    //Limpeza 
                        Limpeza novaLimpeza= new Limpeza();
                        Console.WriteLine("Qual o codigo do produto:");
                        novaLimpeza.Codigo = Console.ReadLine();
                        novaLimpeza.Codigo = Console.ReadLine();

                        Console.WriteLine("Qual a data de entrada?");
                        novaLimpeza.DataEntrada= DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("digite a quantidade:");
                        novaLimpeza.Quantidade= int.Parse(Console.ReadLine());
                        Console.WriteLine("O produto é liquido ou solido?\n Digite 1 para liquido\n Digite 2 para solido");
                        opvolume= int.Parse(Console.ReadLine());
                        if (opvolume == 1)
                        {
                            Console.WriteLine("Digite o peso:");
                            novaLimpeza.Peso= double.Parse(Console.ReadLine());
                        }
                        else if(opvolume == 2)
                        {
                            Console.WriteLine("Digite o volume:");
                            novaLimpeza.Volume= double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Qual o tipo de produto :\n 1- Embarra\n 2- Agua sanitaria\n 3- Em pó\n");
                        int opcao3 = int.Parse(Console.ReadLine());

                        switch(opcao3)
                        {
                            case 1:
                                novaLimpeza.subtipoLimpeza = Produto.SubtipoLimpeza.EmBarra;
                                break;
                            case 2:
                                novaLimpeza.subtipoLimpeza= Produto.SubtipoLimpeza.AguaSanitaria; 
                                break;
                            case 3:
                                novaLimpeza.subtipoLimpeza = Produto.SubtipoLimpeza.EmPo;
                                break;
                        }
                        ListaLimpeza.Add(novaLimpeza);
                        break;
                }
            } while (op <= 1 || op >= 3);


        }

        public void Listar()
        {
            Console.WriteLine("Qual o tipo de produto você deseja listar?\n 1- Alimentos\n 2- Bebidas\n 3- Limpeza\n");
            int opTipo= int.Parse(Console.ReadLine());
            switch(opTipo)
            {
                case 1:
                    foreach(var Alimentos in ListaAlimentos)
                    {
                       // Console.WriteLine("Data de Entrada:" + Alimentos.DataEntrada);
                        Console.WriteLine("Quantidade:" + Alimentos.Quantidade);
                        Console.WriteLine("Peso:"+Alimentos.Peso);
                        Console.WriteLine("Codigo:" + Alimentos.Codigo);
                        Console.WriteLine("Subtipos de alimentos:" + Alimentos.SubtipoAlimentos.Biscoitos, Alimentos.SubtipoAlimentos.Hortaliças, Alimentos.SubtipoAlimentos.Laticinios, Alimentos.SubtipoAlimentos.Carnes, Alimentos.SubtipoAlimentos.Pães);

                    }
                    break;
                case 2:
                    foreach (var Bebidas in ListaBebidas)
                    {
                        //Console.WriteLine("Data de Entrada:" + Bebidas.DataEntrada);
                        Console.WriteLine("Quantidade:" + Bebidas.Quantidade);
                        Console.WriteLine("Codigo:" +  Bebidas.Codigo);
                        Console.WriteLine("Subtipos de bebidas:" + Bebidas.SubtipoBebidas.Alcoolicas, Bebidas.SubtipoBebidas.Condensadas, Bebidas.SubtipoBebidas.Naturais);

                    }
                    break;
                    case 3:
                    foreach (var Limpeza in ListaLimpeza)
                    {
                        //Console.WriteLine("Data de Entrada:" + Limpeza.DataEntrada);
                        Console.WriteLine("Quantidade:" + Limpeza.Quantidade);
                        Console.WriteLine("Peso:" + Limpeza.Peso);
                        Console.WriteLine("Codigo:" + Limpeza.Codigo);
                        Console.WriteLine("Volume:" + Limpeza.Volume);
                        Console.WriteLine("Subtipos de prdutos d limpeza:" + Limpeza.SubtipoLimpeza.AguaSanitaria, Limpeza.SubtipoLimpeza.EmBarra,Limpeza.SubtipoLimpeza.EmPo); 

                    }
                    break;
            }
        }

        public void Solicitar()
        {
            //instaciando o objeto

            Alimentos novoAlimento= new Alimentos();
            Limpeza novaLimpeza= new Limpeza();
            Bebidas novaBebidas= new Bebidas();

            Console.WriteLine("Qual o tipo de produto voce deseja solicitar:\n 1- Alimentos\n 2- Bebidas\n 3- Limpeza\n");
            int Tipo= int.Parse(Console.ReadLine());

            switch (Tipo)
            {
                case 1:
                    Console.WriteLine("Digite o codigo do produto:");
                    novoAlimento.Codigo = Console.ReadLine();

                    // Estou entrando na lista e achando (find) um alimento (a) que tenha o codigo ao que o meu usuario digitou
                    var existe = ListaAlimentos.Find(a => a.Codigo == novoAlimento.Codigo);
                    if(existe != null)
                    {
                        Console.WriteLine("Solicitando produto,aguarde...");
                        ListaAlimentos.Remove(existe);

                    }
                    else
                    {
                        Console.WriteLine("Nao foi possivel encontrar o produto...");
                    }
                    break;
                    case 2:
                    Console.WriteLine("Digite o codigo do produto:");
                    novaBebidas.Codigo = Console.ReadLine();

                    // Estou entrando na lista e achando (find) um alimento (a) que tenha o codigo ao que o meu usuario digitou
                    var existe2 = ListaBebidas.Find(a => a.Codigo == novaBebidas.Codigo);
                    if (existe2 != null)
                    {
                        Console.WriteLine("Solicitando produto,aguarde...");
                        ListaBebidas.Remove(existe2);

                    }
                    else
                    {
                        Console.WriteLine("Nao foi possivel encontrar o produto...");
                    }
                    break;

                    case 3:
                    Console.WriteLine("Digite o codigo do produto:");
                    novaLimpeza.Codigo = Console.ReadLine();

                    // Estou entrando na lista e achando (find) um alimento (a) que tenha o codigo ao que o meu usuario digitou
                    var existe3 = ListaLimpeza.Find(a => a.Codigo == novaLimpeza.Codigo);
                    if (existe3 != null)
                    {
                        Console.WriteLine("Solicitando produto,aguarde...");
                        ListaLimpeza.Remove(existe3);

                    }
                    else
                    {
                        Console.WriteLine("Nao foi possivel encontrar o produto...");
                    }
                    break;
            }
        }





    }
}
