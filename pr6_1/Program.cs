/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */

Console.WriteLine("Начинаем");
int m = 5; //строки
int n = 6; //столбцы
double[,] NewArray = new double[m, n];

double[,] FillArray(double [,] ArrayToFill)
{
    
    for (int i = 0; i < ArrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToFill.GetLength(1); j++)
        {
            ArrayToFill[i, j] =Math.Round(new Random().NextDouble()*20,1) ;
        }
        
    }
    return ArrayToFill;
}




void PrintArray (double[,] ArrToPrint)
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
FillArray(NewArray);
PrintArray(NewArray);