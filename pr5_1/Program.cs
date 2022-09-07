//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4 
Console.WriteLine("Введите неколько чисел через заптятую:");
int num = 0;
int count = 0;
string a1 = Console.ReadLine();
if (a1 == string.Empty)
{
    Console.WriteLine("Пользователь ничего не ввёл");
}
else
{
    string[] subs = a1.Split(',');
    foreach (var sub in subs)
    {
        num = int.Parse(sub);
        //Console.WriteLine($"Substring: {sub}");
        if (num > 0)
        {
            count += 1;
        }
    }
    Console.WriteLine($"Количество положительных чисел: {count}");
}

