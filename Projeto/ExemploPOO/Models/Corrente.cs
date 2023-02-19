namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor )
        {
            base.saldo = valor; //this = isso  base = pegar do elemento base (pai)
        }
    }
}