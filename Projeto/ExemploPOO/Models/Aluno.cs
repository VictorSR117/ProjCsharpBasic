using System;
namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.Write($"olá, meu nome é {Nome} e tenho {Idade} anos e minha nota é {Nota}");
        }
    }
}