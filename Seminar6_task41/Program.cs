//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    //Возвращаем значение
    return numbers;
}

//Перебираем массив и выводим на печать количество введенных символов
void CalculateArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) { count++; }
    }
    Console.WriteLine($"Количество введенных элементов в массиве > 0  =  {count}");
}

int[] enterNumbers = ReadData("Введите числа для заполнения массива через пробел: ");
CalculateArray(enterNumbers);