/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/
/*
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
Random rnd = new Random();

double[,] array = GetArray(m, n);
Printarray(array);

double[,] GetArray(int m, int n)
{
    double a = 1000;
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int L = 0; L < n; L++)
        {
            arr[i, L] = Math.Round(a - rnd.NextDouble() * (1000 + 1000), 2);
        }
    }
    return arr;
}

void Printarray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine("]");
    }
}
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[5, 5];
GetArray(arr);
Printarray(arr);

void GetArray(int[,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void Printarray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}  ");
        }
        Console.WriteLine("]");
    }
}

if (n > arr.GetLength(0) || m > arr.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"строке {n} и столбцу {m} принадлежит значение {arr[n - 1, m - 1]}");
}