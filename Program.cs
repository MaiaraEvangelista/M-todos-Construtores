using System;
using Métodos_Construtores15.Classes;

namespace Métodos_Construtores15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Produto produto = new Produto(9, "X-Bacon", "Lanche com Bacon", 10);

            Produto produto2 = new Produto(9);
           
        }
    }
}
