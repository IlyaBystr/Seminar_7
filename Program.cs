Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(m, n, 1, 10);
Printarray(array);

double[,] GetArray(int m, int n, int maxValue, int minValue)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int L = 0; L < n; L++)
        {
            arr[i, L] = Convert.ToInt32(new Random().Next(-100000,100000)); ;
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