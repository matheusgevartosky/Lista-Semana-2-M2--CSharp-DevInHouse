namespace Projeto_BankAccount
{
    public class BankMenu
    {
        public enum OpcaoMenu { saldo = 1, extrato = 2, deposito = 3, saque = 4, sair = 5 }
        static void Main(string[] args)
        {
            bool condicao = true;

            var account = new bankAccount();

            while (condicao)
            {
                MostraMenu();

                var operacao = int.Parse(Console.ReadLine());
                var SelectedOp = (OpcaoMenu)operacao;

                switch (SelectedOp)
                {
                    case OpcaoMenu.saldo:
                        var saldo = account.saldo;
                        Console.WriteLine($"Seu salde é de R${saldo}");
                        break;

                    case OpcaoMenu.extrato:
                        account.ImprimeExtrato();
                        break;

                    case OpcaoMenu.deposito:
                        Console.Write("Insira o valor que será depositado: ");
                        var deposito =double.Parse(Console.ReadLine());
                        account.deposito(deposito);
                        break;

                    case OpcaoMenu.saque:
                        Console.Write("Insira o valor que será sacado: ");
                        var saque =double.Parse(Console.ReadLine());
                        account.saque(saque);
                        break;

                    case OpcaoMenu.sair:
                    default:
                        Console.WriteLine("Logout");
                        Console.WriteLine("Obrigado, nos vemos em breve!");
                        condicao = false;
                        break;
                }
            }

            static void MostraMenu()
            {
                Console.WriteLine("\n----------------DevInBank-----------------\n");
                Console.WriteLine("Digite a operação desejada:");
                Console.WriteLine("1 - Saldo");
                Console.WriteLine("2 - Extrato");
                Console.WriteLine("3 - Deposito");
                Console.WriteLine("4 - Saque");
                Console.WriteLine("5 - Sair\n");
            }
        }
    }
}