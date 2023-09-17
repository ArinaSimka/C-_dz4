// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
string num = Console.ReadLine();
//int n = int.Parse(num);
char[] array = num.ToCharArray();

int i = 0;
int rez = 0;

while (i < array.Length)
{
    Console.WriteLine($"{array[i]}");
    rez = rez + int.Parse(char.ToString(array[i]));
    i = i + 1;
}
Console.WriteLine($"сумма цифр: {rez}");

