/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

static int FunctionAckerman(int n, int m)
{
    if(n == 0) return m + 1;
    if(n != 0 && m == 0) return  FunctionAckerman(n - 1, 1);
    if (n > 0 && m > 0) return FunctionAckerman(n - 1, FunctionAckerman(n , m - 1)); 
    return FunctionAckerman(n, m);
}
int result = FunctionAckerman(n, m);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {result}");
Console.ReadLine();
