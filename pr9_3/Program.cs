/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
//int Akker = 0;
 int Akk(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akk(n - 1, 1);
    if (n > 0 && m > 0) return Akk(n - 1, Akk(n, m - 1));
    return Akk(n, m);
}
if (m<0)
{
Console.WriteLine ("Введено неверное число M. Введите целое положительное число");
}
else if (n<0)
{
  Console.WriteLine ("Введено неверное число N. Введите целое положительное число");  
}
else
{
  Akk(n, m);  
}
int Akker = Akk(m,n);
Console.WriteLine (Akker);

