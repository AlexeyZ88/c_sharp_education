// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//Console.WriteLine("Начало");
Random rndm = new Random();
int a1 = rndm.Next(10, 20);
int[] arr1 = new int[a1];
Console.WriteLine("Объявлен массив на " + a1 + " элементов");

int count = 0;
for (int i = 0; i < a1; i++)
{
    int a2 = rndm.Next(100, 999);
    arr1[i] = a2;
    Console.WriteLine(arr1[i]);
    if (a2 % 2 == 0)
    {
        count++;
    }

}
Console.WriteLine("Четных элементов массива - " + count);