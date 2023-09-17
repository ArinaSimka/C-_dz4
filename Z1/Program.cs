// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetN(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
bool Valid(int n1)
{
    if (n1 < 0)
    {
        Console.WriteLine("Зачение не должен быть меньше нуля");
        return false;
    }
    return true;
}
int Stepen(int n1, int n2)
{
    int rez = 1;
    while (n2 > 0)
    {
        rez = rez * n1;
        n2 = n2 - 1;
    }
    return rez;
}

int n1 = GetN("Число A");
int n2 = GetN("Число B");
if ( Valid (n1) == true && Valid(n2) == true)
{
    Console.WriteLine($"степень A в B = {Stepen(n1,n2)}");
}




