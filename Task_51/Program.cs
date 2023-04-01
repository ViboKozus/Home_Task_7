#pragma warning disable
Console.Clear();
Console.WriteLine("**Задача 50.** Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

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
        arr[i, j] = new Random().Next(1, 20);
        Console.Write($"{arr[i, j], -2} ");
    }
    Console.WriteLine();
}

Console.Write("Введите номер элемента по строке: ");
int k;
int.TryParse(Console.ReadLine()!, out k);
Console.Write("Введите номер элемента по столбцу: ");
int t;
int.TryParse(Console.ReadLine()!, out t);

if (k > arr.GetLength(0) || t > arr.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    object c = arr.GetValue(k - 1, t - 1);
    Console.WriteLine($"Значение равно = {c}");
}
