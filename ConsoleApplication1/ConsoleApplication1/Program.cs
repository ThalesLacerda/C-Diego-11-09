using System;
using System.Threading;

namespace ConsoleApplication1
{



    class Program
    {

        static int Soma (int valor1, int valor2)
        {
            return valor1 + valor2;



        }
        
                       


        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa("123456789", "Diego Augusto");

            Console.WriteLine(pessoa2.NomeCPF());

            int Resultado = Soma(12, 15);

            Console.WriteLine("\n\n\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);






        }// Fim do método Main

    }//Fim da classe program

}//Fim namespace Objetos
