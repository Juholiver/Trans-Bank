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
    }
}