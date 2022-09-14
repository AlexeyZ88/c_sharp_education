/* /* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 4 3 3 2 2 2 1 */
int[] Track = { 4, 3, 3, 2, 2, 2, 1 };
int[,] NewSpiralArray = new int[4, 4];
int Counter = 11;
int X = 0;
int Y = 0;
int SizeX = NewSpiralArray.GetLength(1);
int SizeY = NewSpiralArray.GetLength(0);
for (int i = 1; i < 17; i++)
{
    if (i < 4)
    {
        NewSpiralArray[Y, X] = Counter;
        Counter++;
        X++;
    }
    if ((4 <= i) && (i < 7))
    {
        NewSpiralArray[Y, X] = Counter;
        Counter++;
        Y++;
    }
    if ((i>=7) && (i < 10))
    {
        NewSpiralArray[Y, X] = Counter;
        Counter++;
        X--;
    }
    if ((i>=10) && (i < 12))
    {
        NewSpiralArray[Y, X] = Counter;
        Counter++;
        Y--;

    }
    if ((i>=12) && (i < 14))
    {
        NewSpiralArray[Y, X] = Counter;
        Counter++;
        X++;
    }
    if ((i>=14) && (i < 15))
    {
        NewSpiralArray[Y, X] = Counter;
        Counter++;
        Y++;
    }
    if ((i>=15) && (i < 17))
    {
        NewSpiralArray[Y, X] = Counter;
        Counter++;
        X--;
    }
}





/* int[,] NewSpiralArray = new int[4, 4];
int Counter = 1;

int[,] FillSpiralArray(int FPosX, int FPosY)
{
    int[,] Item = new int[4, 4];
    int Rows = Item.GetLength(0);
    int Columns = Item.GetLength(1);
    if ((Item[FPosX, FPosY] == 0) && (FPosX < Columns - 1))
    {
        Item[FPosX, FPosY] = Counter;
        Counter += 1;
        FillSpiralArray(FPosX + 1, FPosY);
        // FillSpiralArray(FPosX, FPosY-1);
        //FillSpiralArray(FPosX-1, FPosY);
        //FillSpiralArray(FPosX, FPosY+1);
    }
    return Item;
}
NewSpiralArray = FillSpiralArray(0, 0);*/

void PrintArray(int[,] ArrayToPrint)
{
    for (int i = 0; i < ArrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{ArrayToPrint[i, j]}");

        }
        Console.WriteLine();
    }
}

PrintArray(NewSpiralArray);