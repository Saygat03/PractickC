int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

//Метод генерации и создания двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int start, int stop)
{
    Random rand = new Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = rand.Next(start, stop + 1);
        }
    }
    return array2D;
}

//Печать двумерного массива
void Print2DArray(int[,] matr)
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

int row = ReadData("Введите количество строк в массиве: ");
int column = ReadData("Введите количество столбцов в массиве: ");

int[,] arr2D = Fill2DArray(row, column, 1, 100);
Print2DArray(arr2D);