﻿//Задача 6: 
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int a1=int.Parse(Console.ReadLine());
if (a1%2 == 0) 
{
Console.WriteLine ("Число " + a1 + " - чётное!");    
}
else 
{
Console.WriteLine ("Число  " + a1 + " - НЕчётное!");     
}