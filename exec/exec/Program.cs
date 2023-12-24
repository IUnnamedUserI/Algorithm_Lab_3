using System;
using System.Diagnostics;

class HelloWorld
{
    static void Main()
    {
        var Timer = Stopwatch.StartNew();
        int N = 100;
        Console.WriteLine($@"[Program] Количество элементов массива: {N}");
        int[] Array = new int[N];
        Random _rnd = new Random();

        Console.WriteLine("[Program] Введите искомое число в диапазоне [-1000; 1000]: ");
        int SearchN = int.Parse(Console.ReadLine());

        Timer.Start();
        for (int i = 0; i < Array.Length; i++) Array[i] = _rnd.Next(-1000, 1000); // Заполнение массива
        int Result = SearchNumber(Array, SearchN); // Поиск элемента с указанным значением
        if (Result == -1) Console.WriteLine("[Program] Такого значения нет в массиве."); // Случай, если элемента нет в массиве
        else Console.WriteLine($"[Program] Искомое число находится под индексом {Result}"); // Случай, если элемент нашёлся
        Console.WriteLine($"[Program] Время выполнения программы: {Timer.Elapsed}"); // Вывод
        Timer.Stop();
        Console.ReadKey();
    }

    static int SearchNumber(int[] NumberArray, int Number)
    {
        for (int i = 0; i < NumberArray.Length; i++) if (Number == NumberArray[i]) return i;
        return -1;
    }
}