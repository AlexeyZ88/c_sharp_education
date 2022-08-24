/* Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
Console.WriteLine("Введите число:");
string a1 = Console.ReadLine();
int countStr = a1.Length;
if (countStr < 3)
{
    Console.WriteLine(">>>>> Третьей цифры нет");
}
else
{
    Console.WriteLine(a1[2]);
}