using System.ComponentModel;

namespace Calculator.Lib;

public class Calculator
{

    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Substruct(int a, int b)
    {
        return a - b;
    }

    public int Multiplication(int a, int b)
    {
        return a * b;
    }

    public int Division(int a, int b)
    {
        return a / b;
    }

    public int PowerOf2(int a)
    {
        return a * a;
    }

    public int PowerOf3(int a)
    {
        return a * a * a;
    }

    public int PowerOf4(int a)
    {
        return a * a * a * a;
    }

    public int PowerOf5(int a)
    {
        return a ^ 5;
    }

}


