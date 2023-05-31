using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int a = 10;
        Console.WriteLine($"Число Фібоначчі для числа {a} = {Fibonacci(a)}");
    }

    static int Fibonacci(int a)
    {
        if (a <= 0)
            return 0;
        else if (a == 1)
            return 1;
        else
            return Fibonacci(a - 1) + Fibonacci(a - 2);
    }
}