#pragma warning disable
Console.Clear();
Console.WriteLine("**Задача 52.** Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

Console.Write("Введите кол-во строк: ");
int n;
int.TryParse(Console.ReadLine()!, out n);
Console.Write("Введите кол-во столбцов: ");
int m;
int.TryParse(Console.ReadLine()!, out m);

int[,] arr = new int[n, m];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
        Console.Write($"{arr[i, j], -2} ");
    }
    Console.WriteLine();
}

for (int j = 0; j < arr.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        avarage = (avarage + arr[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}

