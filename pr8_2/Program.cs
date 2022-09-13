/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
8 4 4 2 */
int m = 7; //строки
int n = 5; //столбцы
int[,] NewArray = new int[m, n];

int[,] FillArray(int[,] ArrayToFill)
{

    for (int i = 0; i < ArrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToFill.GetLength(1); j++)
        {
            ArrayToFill[i, j] = new Random().Next(10, 70);
        }

    }
    return ArrayToFill;
}

int[] Result = new int[m];

int[] SumByRows(int[,] ArrayToSum) 
{
    for (int i = 0; i < ArrayToSum.GetLength(0); i++) //вошли в строку
    {
        int[] temp = new int[ArrayToSum.GetLength(1)];
        for (int j = 0; j < temp.Length; j++)
        {
            temp[j] = ArrayToSum[i, j];
        }
        int Sum = 0;
        foreach (int Item in temp)
        {
            Sum += Item;
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки: {Sum}");
        Result[i] = Sum;
    }
    return Result;
}

void FindMinItem (int[] ArrayToFind)
{
 int IndexOfMinValue = ((ArrayToFind.Length)-1); // назначаем минимальным последний элемент массива
  for (int i = 0; i < ArrayToFind.Length; i++)
  {
    if (ArrayToFind[i]<ArrayToFind[IndexOfMinValue]) 
    {
IndexOfMinValue = i;
    }
  }
  Console.WriteLine($"трока с наименьшей суммой элементов №:{IndexOfMinValue+1}");
}
FillArray(NewArray);
SumByRows(NewArray);
FindMinItem(Result);
