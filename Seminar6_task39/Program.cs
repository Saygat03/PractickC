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
            array[i] = numSintezator.Next(start,stop+1);
        }
    //Возвращаем результат
    return array;
}

//Печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}
//Метод разворота массива и создание нового массива
int[] SwapNewArray(int[] array)
{
    int[] outArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        outArray[i] = array[array.Length-1-i];
    }

    return outArray;
}

//Метод разворота массива
int[] SwapArray(int[] array)
{
    int bufElement = 0;
    for (int i = 0; i < array.Length/2; i++)
    {
        bufElement = array[array.Length-1-i];
        array[array.Length-1-i] = array[i];
        array[i] = bufElement;
    }
    return array;
}

int[] arr = GenArray(20,1,100);
Console.WriteLine("Исходный массив: ");
PrintArray(arr);
int[] copyArr = SwapNewArray(arr);
Console.WriteLine("Новый, перевернутый массив: ");

PrintArray(copyArr);
Console.WriteLine("Исходный массив: ");

PrintArray(arr);
arr = SwapArray(arr);
Console.WriteLine("Перевернутый исходный массив: ");
PrintArray(arr);

