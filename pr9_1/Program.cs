/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"
 */

/*  int M = new Random().Next(1,10);
 int N = new Random().Next (11,30);
string ResultStr = String.Empty;
 Console.WriteLine($"Число М={M}");
 Console.WriteLine($"Число N={N}");
 for (int i = M; i < N; i++)
 {
  int Temp = i;
ResultStr += Temp.ToString() + ", ";
 
 }
 
 Console.WriteLine($"{ResultStr}{N}");  */


int M = new Random().Next(1, 10);
int N = new Random().Next(11, 30);
string ResultStr = String.Empty;
string PrintStr(int ArgM, int ArgN, string ResultString)
{
if  (ArgM<ArgN)
{
ResultString +=ArgM.ToString() + ",";   
ResultString = PrintStr(ArgM+1,ArgN,ResultString);
return ResultString;
}
else {
return ResultString;
}
}
ResultStr = PrintStr(M, N, ResultStr);
Console.WriteLine($"Число М={M}");
Console.WriteLine($"Число N={N}");
Console.WriteLine($"{ResultStr}{N}");