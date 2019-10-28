using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturacaso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Autor:Bruna Ribeiro
             Funcionalidade: Exibir um menu ao usuario e 
                             conforme sua escolha direcionar para
                             um local diferente.
              Data: 01/08/2018
             */
            int i;
            do
            { //faça

                Console.Clear();
                Console.WriteLine("selecione uma opção: ");
                Console.Write("1-solteiro\n2-casado\n3-separado\n4-viuvo \n5-sair\n\n");
                Console.Write("Opção: ");
                i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.Write("Destino: Balada \nTome um engov \nTenha JUIZO");

                        break;
                    case 2:
                        Console.Write("Destino: Casa \nFaça um jantar romantico");
                        break;
                    case 3:
                        Console.Write("Destino: Advogado \nFaça um processin");
                        break;
                    case 4:
                        Console.Write("Destino: Cemiterio \nLeve flores");
                        
                        break;
                    case 5:
                        break;

                    default:
                        Console.Write("Opção Invalida");
                        break;
                }
                Console.ReadKey();

            } while (i != 5); //enquanto
        }
    }
}
