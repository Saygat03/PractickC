int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Универсальный метод генерации и заполнения массива
int[] GenArray(int arrLength, int start, int stop)
{
    //Создаем массив
    int[] array = new int[arrLength];
    //Генератор случайных чисел
    Random numSintezator = new Random();

    //Заполняем массив
    for (int i = 0; i < arrLength; i++)
        {
            array[i] = numSintezator.Next(start, stop+1);
        }
    //Возвращаем результат
    return array;
}

//Печатаем одномерный массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

bool FindElementInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }
    }
    return false;
}

int arrLength= ReadData("Введите длину массива: ");
int start = ReadData("Введите начало массива: ");
int stop = ReadData("Введите конец массива: ");
int[] arr = GenArray(arrLength,start,stop);
PrintArray(arr);
int num = ReadData("Введите число, которое хотите найти: ");
PrintResult(num + " = " + FindElementInArray(arr,num));