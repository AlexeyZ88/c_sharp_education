
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4 
int num = 0;
int count = 0;
Console.WriteLine("Введите неколько чисел через запятую:");
Char[] ArrayOfSep = { ',', '.', ':', ';' };
string a1 = Console.ReadLine();

if (a1 == string.Empty)
{
    Console.WriteLine("Пользователь ничего не ввёл");
}
else
{
    foreach (char item in ArrayOfSep)
    {
        a1 = a1.Replace(item, '|');
    }
string[] subs = a1.Split('|');

    foreach (var sub in subs)
    {
        //string temp;
        //temp= String.Concat(sub.Where(Char.IsDigit));
        num = int.Parse(sub);
        Console.WriteLine(num);
        if (num > 0)
        {
            count += 1;
        }
    }
}
Console.WriteLine($"Количество положительных чисел: {count}"); 