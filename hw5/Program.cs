// // Домашняя работа 1 Задача 4 Вариант решения 2
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int MAX (int a1, int a2, int a3) 
{
int result=a1;
if (a2>result) result=a2;
if (a3>result) result=a3;
return result;
}


int [] array = new int[3];
Console.WriteLine("Введите первое число:");

array [0] = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите второе число:");
array [1] = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите третье число:");
array [2] = int.Parse(Console.ReadLine()); 

int max = MAX(array[0],array [1],array[2]);
Console.WriteLine("Максимальное число - " + max);
