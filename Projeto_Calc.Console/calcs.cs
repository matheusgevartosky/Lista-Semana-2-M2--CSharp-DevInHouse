class calculadora
{
    public int value1 { get; private set; }
    public int value2 { get; private set; }

    public void SetValue1(int a, int b)
    {
        value1 = a;
        value2 = b;
    }



    public int soma()
    {   
        return value1 + value2;  
    }
    public int subtracao(int a, int b)
    {
        return a - b;
    }
    public int multiplicacao(int a, int b)
    {
        return a * b;
    }
    public int divisao(int a, int b)
    {
        return a / b;
    }


}

