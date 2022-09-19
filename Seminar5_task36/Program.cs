//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

void SummArray(int[] array)
{
    int[] sums = new int[array.Length];
    List<int> sorted = new List<int>();
    int resultSumm = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i] % 2 == 0) {
                resultSumm += array[i];
            }      
    }
    Console.Write(resultSumm); 
}

int arrLength= ReadData("Введите длину массива: ");
int[] arr = GenArray(arrLength);
PrintArray(arr);
SummArray(arr);
