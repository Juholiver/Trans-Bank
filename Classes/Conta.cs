namespace Dio.Bank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Cretido { get; set; }
        private string Nome { get; set; }

       public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
       {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Cretido = credito;
            this.Nome = nome;
       } 
       public bool Sacar(double valorSaque)
       {
        //validação de saldo suficiente
            if (this.Saldo - valorSaque < (this.Cretido *-1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true
       }
    }
}