namespace Projeto_BankAccount
{
    class bankAccount
    {
        public double saldo { get; private set; }

        private static List<string> extrato = new List<string>();

        
        public void deposito(double deposito)
        {
            if(deposito <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("O valor depositádo não pode ser igual ou menos que 0");
                 Console.ResetColor();
            }else
            {
                saldo += deposito;
                extrato.Add($"Deposito efetuado.         R${deposito}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Depósito de {deposito} efetuado com sucesso!");
                Console.ResetColor();
            }
        }

        public void saque(double saque)
        {
            if(saque > saldo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine($"não é possivel efetuar o saque, o valor solicitado é maior que o disponivel em conta. Saldo Atual: {saldo}");
                Console.ResetColor();
            }
            else
            {
                saldo -= saque;
                Console.ForegroundColor = ConsoleColor.Green;
                extrato.Add($"Saque efetuado.             R${saque}");
                Console.WriteLine($"\nSaque de {saque} efetuado. Saldo atual: {saldo}\n");
                Console.ResetColor();
            }
        }

        public void ImprimeExtrato()
        {
            Console.WriteLine("-----Extrato-----");
            foreach (var item in extrato)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine($"\n\n\n Saldo atual:           R${saldo}");
        }
    }
    
}