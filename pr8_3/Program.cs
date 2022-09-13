/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
int m1 = 2; //строки
int n1 = 2; //столбцы

int m2 = 2; //строки
int n2 = 2; //столбцы
int[,] NewArray1 = new int[m1, n1];
int[,] NewArray2 = new int[m2, n2];

int[,] FillArray(int[,] ArrayToFill)
{

    for (int i = 0; i < ArrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToFill.GetLength(1); j++)
        {
            ArrayToFill[i, j] = new Random().Next(0, 11);
        }

    }
    return ArrayToFill;
}

NewArray1 = FillArray(NewArray1);
NewArray2 = FillArray(NewArray2);


int[,] MatrixMultiplication(int[,] Matrix1, int[,] Matrix2)
{
    int Matrix1Columns = Matrix1.GetLength(1);
    int Matrix2Rows = Matrix2.GetLength(0);
    int[,] Matrix3 = new int[2, 2];
    if (Matrix1Columns == Matrix2Rows)
    {

        Matrix3[0, 0] = (Matrix1[0, 0] * Matrix2[0, 0]) + (Matrix1[0, 1] * Matrix2[1, 0]);
        Matrix3[0, 1] = (Matrix1[0, 0] * Matrix2[0, 1]) + (Matrix1[0, 1] * Matrix2[1, 1]);
        Matrix3[1, 0] = (Matrix1[1, 0] * Matrix2[0, 0]) + (Matrix1[1, 1] * Matrix2[1, 0]);
        Matrix3[1, 1] = (Matrix1[1, 0] * Matrix2[0, 1]) + (Matrix1[1, 1] * Matrix2[1, 1]);

    }
    else
    {
        Console.WriteLine("Матрицы не согласованы");
    }
    return Matrix3;
}

int[,] ResultMatrix = MatrixMultiplication(NewArray1, NewArray2);

void PrintArray (int[,] ArrToPrint)
{
    for (int i = 0; i < ArrToPrint.GetLength(0); i++)
    {
      for (int j = 0; j < ArrToPrint.GetLength(1); j++)
      {
        Console.Write($"{ArrToPrint[i,j]} ");
      } 
      Console.WriteLine(); 
    }
}

PrintArray (ResultMatrix);