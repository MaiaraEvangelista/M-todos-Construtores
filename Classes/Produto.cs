using System;

namespace Métodos_Construtores15.Classes
{
    public class Produto
    {
        
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
         
        public string Descricao { get; set; }
        
        public int Estoque { get; set; }
        
        public Produto(int codigo, string nome, string desc, int estoque){

            Codigo = codigo;
            Nome = nome;
            Descricao = desc;
            Estoque = estoque;

            Console.WriteLine($"Produto Cadastrado -Código: {Codigo} - Nome: {Nome}");
        }
        //fim do método construtor

        public Produto (int codigo){
            if (codigo >=0)
            {
                Codigo = codigo;
                Nome= "Itubaina";
                Console.WriteLine($"Produto Cadastrado -Código: {Codigo} - Nome: {Nome ?? "Sem nome"}");
            } else{
                Console.WriteLine("Código Inválido");
            }
        }


        
    }
}