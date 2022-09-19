//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Вывод массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}
// Генерация массива
int[] GenerateArr(int arrLength, int min, int max)
{
    int[] array = new int[arrLength];
    Random rnd = new Random();

    if (min > max)
    {
        int temp = max;
        max = min;
        min = temp;
    }

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int[] arr = GenerateArr(10, 0, 100);
PrintArray(arr);
Console.WriteLine($"Минимальный элемент массива: {arr.Min()}");
Console.WriteLine($"Максимальный элемент массива: {arr.Max()}");