
Console.WriteLine("Введите трёхзначное число:");
int num = int.Parse(Console.ReadLine());
int ed = num%10;
int dec = (num/10)%10;
int hund = num/100;
Console.WriteLine("\n");
Console.WriteLine(hund);
Console.WriteLine(ed);
Console.WriteLine(dec);
