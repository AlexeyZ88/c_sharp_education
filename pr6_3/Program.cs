/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
int m = 15; //строки
int n = 10; //столбцы
int[,] NewArray = new int[m, n];

int[,] FillArray(int[,] ArrayToFill)
{

    for (int i = 0; i < ArrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToFill.GetLength(1); j++)
        {
            ArrayToFill[i, j] = new Random().Next(1, 30);
        }

    }
    return ArrayToFill;
}

void SumByColumns(int[,] ArrayForCount)
{
    int NumOfRows = ArrayForCount.GetLength(0);
    int NumOfColumns = ArrayForCount.GetLength(1);
    double AverageSum = 0;
    Console.Write("|");
    for (int i = 0; i < NumOfColumns; i++) //вошли в столбец
    {
        AverageSum = 0;
        for (int j = 0; j < NumOfRows; j++) //перебираем строки в столбце
        {
            AverageSum += ArrayForCount[j, i];
        }
        AverageSum = Math.Round((AverageSum / NumOfRows), 2);
        Console.Write($"{AverageSum}|");
    }
    Console.Write("\n");
}
FillArray(NewArray);
SumByColumns(NewArray);