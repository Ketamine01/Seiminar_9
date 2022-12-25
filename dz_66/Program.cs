/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

 Console.Clear();
 Console.Write("Введите m: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите n: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int temporary = m;
 if (m > n)
 {
    m = n;
    n = temporary;
 }
 SumOfNumbres(m, n, temporary = 0);
 void SumOfNumbres(int m, int n, int summ)
 {
    summ = summ + n;
    if (n <= m)
    {
        Console.WriteLine($"Сумма элемнов от m до n = {summ} ");
        return;
    }
    SumOfNumbres(m, n - 1, summ);
 }
 Console.ReadKey();


