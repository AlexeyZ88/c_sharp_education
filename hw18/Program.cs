// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Random rndm2 = new Random();
int a1 = rndm2.Next(10, 20);
int[] arr1 = new int[a1];
Console.WriteLine("Объявлен массив на " + a1 + " элементов");
for (int i = 0; i < a1; i++)
{
    arr1[i] = rndm2.Next(10, 99);
    Console.WriteLine(arr1[i]);
}
int min = 100;
int max = 0;
for (int j = 0; j < arr1.Length; j++)
{
    if (arr1[j] > max)
    {
        max = arr1[j];
    }
    if (arr1[j] < min)
    {
        min = arr1[j];
    }

}
Console.WriteLine("Максимальный>>" + max);
Console.WriteLine("Минимальный>>" + min);
Console.WriteLine ("Разница между минимальным и максимальным составляет:" + (max-min));