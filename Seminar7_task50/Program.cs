//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

//Метод генерации и создания двумерного массива
long[,] Fill2DArray(int countRow, int countColumn, int start, int stop)
{
    Random rand = new Random();
    long[,] array2D = new long[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = rand.Next(start, stop + 1);
        }
    }
    return array2D;
}

// // Печать 2D массива с выделенным элементом.
void ShowElemInArray(long[,] arr, int row, int column)
{
    if (FindElem(row, column, arr))
    {   
        // Вывод до искомого элемента
        int i, j;
        for (i = 0; i < row; i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]}\t");
            }
            Console.WriteLine();
        }
        for (j = 0; j < column; j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }

        // Вывод искомого элемента
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{arr[i, j]}\t");
        Console.ForegroundColor = ConsoleColor.White;

        // Вывод после завершения поиска
        for (j = column + 1; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();

        for (i = row+1; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
    else
    PrintData("Такого элемента нет");
}

// Вывод строки
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Проверка на наличие искомого элемента в массиве
bool FindElem(int row, int column, long[,] arr)
{
    return (row < arr.GetLength(0) && column < arr.GetLength(1));
}


long[,] arr = Fill2DArray(5, 5,2,100);

int row = ReadData("Укажите строку массива: ");
int column = ReadData("Укажите столбец массива: ");
ShowElemInArray(arr, row, column);
