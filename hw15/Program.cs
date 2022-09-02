// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Начало");
int[] array1 = new int[8];
Random rn = new Random();
for (int i = 0; i < 8; i++)
{
 array1[i] = rn.Next(10, 9999);
 Console.WriteLine( i+1 + ")"  +array1[i]);   
}