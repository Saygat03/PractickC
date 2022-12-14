//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

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
int[] GenArray(int arrLength)
{
    //Создаем массив
    int[] array = new int[arrLength];
    //Генератор случайных чисел
    Random numSintezator = new Random();

    //Заполняем массив
    for (int i = 0; i < arrLength; i++)
        {
            array[i] = numSintezator.Next(100,1000);
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

int[] ChangeArr(int[] array)
{
    List<int> sorted = new List<int>();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sorted.Add(array[i]);
        }
    }
    return sorted.ToArray();
}

int arrLength= ReadData("Введите длину массива: ");
int[] arr = GenArray(arrLength);
PrintArray(arr);
PrintArray(ChangeArr(arr));
