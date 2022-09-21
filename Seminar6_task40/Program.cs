int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

//Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

bool TriangleTest(int a, int b, int c)
{
    bool result = false;
    if ((a+b>c) && (b+c>a) && (c+b>a))
    {
        result = true;
    }
    return result;
    //return (a+b>c) && (b+c>a) && (c+b>a);
}

int a = ReadData("Введите длину стороны А: ");
int b = ReadData("Введите длину стороны Б: ");
int c = ReadData("Введите длину стороны С: ");

PrintResult(TriangleTest(a,b,c) ? "Такой треугольник может быть" : "Такого треугольника не может быть");