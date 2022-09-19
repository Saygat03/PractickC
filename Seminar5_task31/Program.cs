int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

//Универсальный метод генерации и заполнения массива
int[] FillArray(int arrLength, int downBorder, int topBorder)
{
    //Создаем массив
    int[] array = new int[arrLength];
    //Генератор случайных чисел
    Random numSintezator = new Random();

    //Тест границ
    if (downBorder < topBorder)
    {
        //Заполняем массив
        for (int i = 0; i < arrLength; i++)
        {
            array[i] = numSintezator.Next(downBorder, topBorder+1);
        }
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

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] NegotivPositivSums(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            sums[0]+=arr[i];
        }
        else
        {
            sums[1]+=arr[i];
        }
    }
    return sums;
}

int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу массива: ");
int topBorder = ReadData("Введите верхнюю границу массива: ");
int[] inputArray = FillArray(arrayLength,downBorder,topBorder);
PrintArray(inputArray);
int[] sumArray = NegotivPositivSums(inputArray);
PrintResult("Сумма >0: " + sumArray[0] + " , сумма <0: " + sumArray[1]);
PrintArray(sumArray);