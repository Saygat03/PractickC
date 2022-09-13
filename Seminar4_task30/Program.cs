int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine()??"0");
    //Возвращаем значение
    return number;
}


int[] GenArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random random = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = random.Next(0,2);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length-1]);
}

int arrLen = ReadData("Введите длину массива: ");
int[] array = GenArray(arrLen);
PrintArray(array);