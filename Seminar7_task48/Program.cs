int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
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

//Метод генерации и создания двумерного массива
int[,] Fill2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i +j;
        }
    }
    return matr;
}

int m = ReadData("Введите количество столбцов");
int n = ReadData("Введите количество строк");
int[,] matrix = new int[m,n];

Fill2DArray(matrix);
Print2DArray(matrix);