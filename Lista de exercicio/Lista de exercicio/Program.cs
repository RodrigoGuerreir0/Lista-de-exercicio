using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exercicio 1
            string nome = "Rodrigo";

            // exercicio 2
            double soma = 12+8;

            // exercicio 3
            int numero = 8;

            // exercicio 4
            Console.WriteLine("Digite qualquer nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("O nome digitado " + nome + " é bonito ");

            // exercicio 5
            double n1 = 0;
            double n2 = 0;
            Console.WriteLine("Digite o primeiro numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O primeiro numero é maior que o segundo!");
            }
            else if (n2 > n1)
            {
                Console.WriteLine("O segundo numero é maior que o primeiro!");
            }
            else
                Console.WriteLine("Os numeros escolhidos são iguais! ");

            // exercicio 6
            double valor;
            Console.WriteLine("Digite qualquer numero: ");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O dobro do valor escolhido é de: "+ valor *2);
            Console.WriteLine("A metade do valor escolhido é de: "+ valor /2);



        }
    }
}
