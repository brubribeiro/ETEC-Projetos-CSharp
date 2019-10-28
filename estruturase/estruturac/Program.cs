using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturac
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Autor: Bruna Ribeiro
             Funcionalidade: receber a idade de uma pessoa 
             e informar maioridade para valores acima de 17
             Data: 01/08/2018
             */

            int idade;

            Console.Write("Informe a sua idade: ");
            idade = int.Parse(Console.ReadLine()); 

            if(idade<=17){
                Console.Write("Você é menor de idade");
            }
            else {
                Console.Write("Você é maior de idade");
            }
            Console.ReadKey();
            /*
             
             Operador aritmetico:
             != (diferente)
             
             */

        }
    }
}
