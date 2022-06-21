    class Program
{
    enum operacoes
    {
        soma = 1,
        subtracao = 2,
        multiplicacao = 3,
        divisao= 4,
        Sair = 5
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("-----------------DevInCalculator----------------");
        MostraMenu();
        Console.WriteLine("-----------------------------------------------");

        bool condicao = true;

        var operation = new calculadora();

        while (condicao)
        {
            Console.WriteLine("Digite a operação desejada:");
            int operacao = int.Parse(Console.ReadLine());

            var SelectedOp = (operacoes) operacao;

            switch (SelectedOp)
            {
                case operacoes.soma:
                Console.WriteLine("Digite o promeiro valor");
                int value1 =int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                int value2 =int.Parse(Console.ReadLine());
                operation.SetValue1(value1, value2);
                int result = operation.soma();
                Console.WriteLine(result);
                break;
               
            }

        }
    }
    
    public static void MostraMenu()
    {
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");
    }
    
}

    // Language: csharp
    // Path: Projeto_Calc.Console\Program.cs