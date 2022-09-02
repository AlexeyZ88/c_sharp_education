//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Начинаем...");
Random rn = new Random();
int a1 = rn.Next(10, 9999);
Console.WriteLine("Наше число:" + a1);
string a2 = a1.ToString();
int count = 0;
char num;
for (int i = 0; i < a2.Length; i++)
{
    num = a2[i];
    //count = count + (num - '0');
    count = count + (int)Char.GetNumericValue(num);
}
Console.WriteLine("сумма цифр нашего числа = " + count);
