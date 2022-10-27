/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
Random rnd= new Random();

double[,] array = GetArray(m, n);
Printarray(array);

double[,] GetArray(int m, int n)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int L = 0; L < n; L++)
        {
            arr[i, L] = Math.Round(rnd.NextDouble()*(100+100), 2);
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
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine("]");
    }
}