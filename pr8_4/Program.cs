/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
int m1 = 3; //строки
int n1 = 3; //столбцы
int o1 = 3;
int[,,] NewArray1 = new int[m1, n1, o1];

int[,,] FillArray(int[,,] ArrayToFill)
{

    for (int i = 0; i < ArrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToFill.GetLength(1); j++)
        {
            for (int k = 0; k < ArrayToFill.GetLength(2); k++)
            {
                ArrayToFill[i, j, k] = new Random().Next(11, 100);
            }

        }

    }
    return ArrayToFill;
}
NewArray1 = FillArray(NewArray1);

void PrintArray(int[,,] ArrayToPrint)
{
    for (int i = 0; i < ArrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < ArrayToPrint.GetLength(2); k++)
            {
                Console.Write($"{ArrayToPrint[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
}
PrintArray(NewArray1);