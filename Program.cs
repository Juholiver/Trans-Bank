using System;

namespace Dio.Bank
{
  
  class Program
  {
    static void Main(string[]args )
    {
        Conta minhaConta= new Conta(TipoConta.PessoaFisica,0,0,"José");
        System.Console.WriteLine(minhaConta.ToString());
        
    }
  }
    
}
