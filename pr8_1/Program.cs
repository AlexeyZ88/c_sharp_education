/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int m = 5; //строки
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


void SortArray(int[,] ArrayToSort)
{
    for (int i = 0; i < ArrayToSort.GetLength(0); i++)
    {
        int[] temp = new int[ArrayToSort.GetLength(1)];
        for (int j = 0; j < temp.Length; j++)
        {
            temp[j] = ArrayToSort[i, j];
        }
        var result = temp.OrderByDescending(t => t);
        foreach (int t in result)
            Console.Write($"{t} ");
        Console.Write("\n");
    }
}

FillArray(NewArray);
SortArray(NewArray);