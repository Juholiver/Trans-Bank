using System;

namespace Dio.Bank
{
  
  class Program
  {
    static void Main(string[]args )
    {
        string opcaoUsuario = ObterOpcaoUsuario();
        while (opcaoUsuario.ToUpper() !="X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                    //ListarContas();
                    break;
                case "2":
                   // InserirConta();
                    break;
                case "3":
                   // Tranferir();
                    break;
                case "4":
                   // Sacar();
                    break;
                case "5":
                   // Depositar();
                    break;
                case "C":
                    Console.Clear();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();    
                
            }
            opcaoUsuario = ObterOpcaoUsuario();
        }
        System.Console.WriteLine("Obrigado por utilizar nossos serviços.");
        Console.ReadLine();
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
