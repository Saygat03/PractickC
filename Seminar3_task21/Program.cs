//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine()??"0");
    //Возвращаем значение
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

double Sqrt(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1));
}

int x1 = ReadData("Введите координату x1: ");
int y1 = ReadData("Введите координату y1: ");
int z1 = ReadData("Введите координату z1: ");
int x2 = ReadData("Введите координату x2: ");
int y2 = ReadData("Введите координату y2: ");
int z2 = ReadData("Введите координату z2: ");
PrintResult(Math.Round(Sqrt(x1,y1,z1,x2,y2,z2),2).ToString());