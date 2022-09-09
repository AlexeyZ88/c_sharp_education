// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = int.Parse(Console.ReadLine());
double x1=0;
double y1=0;
if (k1==k2) 
{
    Console.WriteLine("Прямые параллельны и не имеют точки пересечения. введите другие аргументы");
}
else 
{
    x1 =(double)(b2-b1)/(k1-k2);
    y1 = k1*x1+b1;
    Console.WriteLine ($"Точка пересечения прямых имеет координаты x={x1}, y={y1}");
}

