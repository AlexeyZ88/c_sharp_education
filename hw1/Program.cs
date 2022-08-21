
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
Console.Write ("Второе число больше первого");
Console.WriteLine (a2 + ">" + a1);
}