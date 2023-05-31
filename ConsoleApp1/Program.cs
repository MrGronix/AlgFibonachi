using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int a = 10;
        Console.WriteLine($"Число Фібоначчі для числа {a} = {Fibonacci(a)}");
    }
