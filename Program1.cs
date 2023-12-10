using System;

class Program
{
    public static void Main()
    {
        Console.Write("Введите число M = ");
        int M = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите число  на котором надо остановить функцию: ");
        int N = int.Parse(Console.ReadLine()!);
    

        if (M <= N)
        {
            Console.WriteLine($"Натуральные числа в промежутке от {M} до {N}:");
            GetRec(M,N);
        }
        else
        {
            Console.WriteLine("Ошибка: M должно быть меньше или равно N.");
        }
    }

    public static void GetRec(int M, int N)
    {
        if(M <= N)
        {
            Console.WriteLine(M);
            GetRec(M + 1,N);
        }
        
    }
}