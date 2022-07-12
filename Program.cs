using System;

namespace Dio.Bank
{
  
  class Program
  {
    static List<Conta> listContas = new List<Conta>();
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
                    InserirConta();
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

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta ");
            Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();
            
            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Credito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                                    saldo: entradaSaldo,
                                                    credito: entradaCredito,
                                                    nome: entradaNome);

            listContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");
            if(listContas.Count == 0)
            {
                Console.WriteLine("Nhuma Conta cadastrada. ");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);

            }
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
