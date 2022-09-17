/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

 int M = new Random().Next(1,10);
 int N = new Random().Next (11,30);
int ResultSum = 0;
 Console.WriteLine($"Число М={M}");
 Console.WriteLine($"Число N={N}");
 for (int i = M; i <= N; i++)
 {
  ResultSum += i;
 }
 Console.WriteLine($"M={M}, N={N} =>> {ResultSum}");
 
