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
        bool condicao = true;

        var operation = new calculadora();

        while (condicao)
        {
            Console.WriteLine("\n\n-----------------DevInCalculator----------------\n");
            MostraMenu();
            Console.WriteLine("Digite a operação desejada:");
            var operacao = int.Parse(Console.ReadLine());

            var SelectedOp = (operacoes) operacao;

            switch (SelectedOp)
            {
                case operacoes.soma:
                    MostraOpcao(1);
                break;
                case operacoes.subtracao:
                    MostraOpcao(2);
                break;

                case operacoes.multiplicacao:
                    MostraOpcao(3);
                break;
                case operacoes.divisao:
                    MostraOpcao(4);
                break;
                case operacoes.Sair:
                    default:
                    Console.WriteLine("Logout");
                    Console.WriteLine("Obrigado, nos vemos em breve!");
                    condicao = false;
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
        Console.WriteLine("5 - Sair\n");
    }

    public static void MostraOpcao(int op)
    {
        var operation = new calculadora();
        Console.Write("Digite o primeiro valor:  ");
            int value1 =int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor:  ");
            int value2 =int.Parse(Console.ReadLine());
        operation.SetValue1(value1, value2);
        
        if(op == 1)
        {
            int result = operation.soma();
            Console.Write($"O Resultado é: {result}");
        }
        if(op == 2)
        {
            int result = operation.subtracao();
            Console.WriteLine($"O Resultado é: {result}");
        }
        if(op == 3)
        {
            int result = operation.multiplicacao();
            Console.WriteLine($"O Resultado é: {result}");
        }
        if(op == 4)
        {
            int result = operation.divisao();
            Console.WriteLine($"O Resultado é: {result}");
        }
        
    }
    
}

    // Language: csharp
    // Path: Projeto_Calc.Console\Program.cs