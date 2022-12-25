/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
void PrintNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, ");
        PrintNumber(m + 1, n);
    }
    else
    {
        return;
    }
}
Console.Clear();
Console.Write($"m = {m}; n = {n} -> \"");
PrintNumber(m, n);
Console.Write($"{n}\"");
Console.WriteLine();
Console.ReadKey();

