/* // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */
Console.WriteLine("Введите число от 1 до 7:");
int NumOfDay = int.Parse(Console.ReadLine());
string[] newArray1 = { "первый", "второй", "третий", "четвёртый", "пятый", "шестой", "седьмой" };
string[] newArray2 = { "понедельник", "вторник", "среда", "четвёрг", "пятница", "суббота", "воскресенье" };
string isHoly = "";
if (NumOfDay == 6 || NumOfDay == 7)
{
    isHoly = "выходной";
}
else
{
    isHoly = "рабочий";
}
Console.WriteLine(newArray1[NumOfDay-1] + " день недели - " + newArray2[NumOfDay-1] + " - " + isHoly);