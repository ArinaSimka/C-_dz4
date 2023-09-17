// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetN(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int Summa(int n)
{
    int rez = 0;
    while (n > 0)
    {
        rez = rez + (n % 10);
        n = n / 10;
    }
    return rez;
}
// int number = GetN("число");
// int rezult = Summa(number);
// Console.WriteLine($"Сумма цифр в числе {rezult}");
Console.WriteLine($"Сумма цифр в числе {Summa(GetN("число"))}");


