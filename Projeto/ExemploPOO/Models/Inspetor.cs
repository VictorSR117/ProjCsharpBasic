using System;
namespace ExemploPOO.Models
{
    public class Inspetor : Professor
    {
        public override void DarNota()
        {
            Console.Write($"Eu sou Inspetor");
        }
        public void QQcoisa()
        {
            Console.Write($"não posso receber o método DarNota do professor :(")
        }
    }
}