//// Домашняя работа 1 Задача 2
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число");
int a2 = int.Parse(Console.ReadLine());
if (a1>a2) 
{
Console.WriteLine ("Первое число больше второго");
Console.WriteLine (a1 + ">" + a2);
}
else 
{
Console.WriteLine ("Второе число больше первого");
Console.WriteLine (a2 + ">" + a1);
}