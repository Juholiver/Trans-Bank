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
    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("DIO Bank a seu dispor!!!");
        Console.WriteLine("Informe a opção desejada: ");

        Console.WriteLine("1- Listar contas");
        Console.WriteLine("2- Inserir nova conta ");
        Console.WriteLine("3- tranferir");
        Console.WriteLine("4- Sacar");
        Console.WriteLine("5- Depositar");
        Console.WriteLine("C- Limpar tela ");
        Console.WriteLine("X- Sair");
        Console.WriteLine();

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
    }
  }
    
}
