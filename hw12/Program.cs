// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число от 1 до 20:");
int a1 = int.Parse(Console.ReadLine());
if ((a1>0)&&(a1<21))
{
double i=1;
double cube;
while (i<=a1)
{
cube=Math.Pow(i,3);
i++;
Console.Write(" > " + cube);
}
Console.Write("\n");
}
else
{
Console.WriteLine("Введено неверное число");    
}