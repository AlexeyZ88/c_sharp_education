//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Random rndm1 = new Random();
int a1 = rndm1.Next(10, 20);
int[] arr1 = new int[a1];
Console.WriteLine("Объявлен массив на " + a1 + " элементов");

int count = 0;
for (int i = 0; i < a1; i++)
{
    int a2 = rndm1.Next(100, 999);
    arr1[i] = a2;

    if (i % 2 > 0)
    {
        Console.WriteLine(i + ")" + ">>" + arr1[i]);
        count = count + arr1[i];
    }
    else
    {
        Console.WriteLine(i + ")" + arr1[i]);
    }

}
Console.WriteLine("Сумма элементов на нечетных позициях - " + count);
