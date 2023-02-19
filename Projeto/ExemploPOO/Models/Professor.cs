namespace ExemploPOO.Models
{
    public sealed class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.Write($"olá, meu nome é {Nome} e tenho {Idade} anos e deveria ganhar {Salario}");
        }

        public sealed override void DarNota()
        {
            Console.Write($"a nota do aluno é x");
        }
    }
}