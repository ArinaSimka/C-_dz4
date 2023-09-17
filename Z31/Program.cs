// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetN(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int index = 0; index < size; index++)
    {
        array[index] = rand.Next(min, max + 1);
    }
    return array;
}
void Print(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write("  ");
        Console.Write($"{arr[i]}");
    }
}
int min = GetN("Минимальное число для массива");
int max = GetN("Максимальное число для массива");
Print(GetArray(8, min, max));



