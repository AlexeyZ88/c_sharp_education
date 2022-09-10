/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.WriteLine("Начинаем");
int m = 7; //строки
int n = 7; //столбцы
int[,] NewArray = new int[m, n];

int [,] FillArray(int [,] ArrayToFill)
{
    
    for (int i = 0; i < ArrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToFill.GetLength(1); j++)
        {
            ArrayToFill[i, j] = new Random().Next(1,30) ;
        }
        
    }
    return ArrayToFill;
}


FillArray(NewArray);
Console.WriteLine("Введите целое двухзначное число:");
string Temp = Console.ReadLine();

int ItemCount = Temp.Length;
if (ItemCount !=2) 
{
    Console.WriteLine("Введено неверное число!");
}
else
{
 int RowNum = Temp [0] - '0';
 int ColNum = Temp [1] - '0';
 try
 {
    Console.WriteLine ($"Элемент по адресу {RowNum}, {ColNum} = {NewArray[RowNum-1, ColNum-1]}");
 }
 catch (System.Exception)
 {
   Console.WriteLine ($"Элемент массива по адресу {RowNum},{ColNum} отсутствует"); 
 } 
}

