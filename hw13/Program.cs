//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.WriteLine("Идёт загрузка программы");
for (int j = 0; j < 30; j++)
{
 System.Threading.Thread.Sleep(50);;
 Console.Write("||| ");
}
Console.WriteLine("\n Поехалиии....");
Random rn = new Random();
for (int i = 0; i < 10; i++)
{
    int a1 = rn.Next(1, 10);
    int a2 = rn.Next(1, 10);
    Console.WriteLine(">>> " + Math.Pow(a1, a2));
}





