//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Считывание данных с консоли.
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

//Печать двумерного массива
void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}\t ");
        }
        Console.WriteLine();
    }
}


// Генерация случайного 2D массива.
double[,] Gen2DArr(int rows, int columns, int arrayMin, int arrayMax)
{
    double[,] arr = new double[rows, columns];
    Random rnd = new Random();
    if (arrayMin > arrayMax)
    {
        int temp = arrayMax;
        arrayMax = arrayMin;
        arrayMin = temp;
    }
    int range = arrayMax - arrayMin;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = arrayMin + rnd.NextDouble() * range;
        }
    }
    return arr;
}

int rows = ReadData("Введите количество строк: ");
int columns = ReadData("Введите количество столбцов: ");
Print2DArray(Gen2DArr(rows, columns, 5, 100));