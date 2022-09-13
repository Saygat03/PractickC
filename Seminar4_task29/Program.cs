//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random random = new Random();

    for (int i = 0; i < arrLength; i++)
    {

        array[i] = random.Next(start, stop);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int arrLen = ReadData("Введите длину массива: ");
int arrStart = ReadData("Введите начало массива");
int arrStop = ReadData("Введите конец массива");
int[] array = GenArray(arrLen, arrStart, arrStop);
PrintArray(array);