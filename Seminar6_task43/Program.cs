// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

//Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


//Точка пересечения
(double, double) PointFind(int b1, int k1, int b2, int k2)
{
    double x = ((double)b2 - (double)b1) / ((double)k1 - (double)k2);
    double y = (double)k1 * x + (double)b1;
    return (x, y);
}

int b1 = ReadData("Введите b1: ");
int k1 = ReadData("Введите k1: ");
int b2 = ReadData("Введите b2: ");
int k2 = ReadData("Введите k2: ");

(double,double) point = PointFind(b1, k1, b2, k2);

PrintResult("Точка пересечения = " + point);