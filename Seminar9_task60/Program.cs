// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Создание 3D массива.
int[,,] Gen3DArr(int rows, int columns, int depth)
{
    int[,,] arr = new int[rows, columns, depth];
    List<int> numbs = Enumerable.Range(10, 90).ToList();
    Random rnd = new Random();
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                index = rnd.Next(numbs.Count);
                arr[i, j, k] = numbs[index];
                numbs.RemoveAt(index);
            }
        }
    }
    return arr;
}

// Печать 3D массива.
void Print3DArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Print3DArr(Gen3DArr(3, 3, 3));