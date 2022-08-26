//Задача 19
/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.Clear();
Console.WriteLine("Введите значение:");
string s = Console.ReadLine();
char[] a = s.ToCharArray();
char[] b = s.ToCharArray();
Array.Reverse(b);
bool isAqual=Enumerable.SequenceEqual(a, b);

if (isAqual) 
{
    Console.WriteLine ("Выражение является палиндромом");
}
else 
{
    Console.WriteLine ("Выражение НЕ является палиндромом");
}