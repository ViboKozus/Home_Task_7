#pragma warning disable
Console.Clear();
Console.WriteLine("Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");

double[,] arr = new double[3, 4];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = Convert.ToDouble (new Random().Next(-10, 10))/10;
        Console.Write($"{arr[i, j], -2} ");
    }
    Console.WriteLine();
}
