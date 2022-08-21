// Домашняя работа 1 Задача 4
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 3 числа по порядку");
Console.WriteLine("Введите первое число:");
int a1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int a2=int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int a3=int.Parse(Console.ReadLine());
int max=a1;
    if ((a2>a1) && (a2>a3)) 
    {
    max = a2;
    }     
    else if ((a3>a1) && (a3>a2))
    {
    max = a3;    
    }
   Console.WriteLine("Наибольшее число - " + max);