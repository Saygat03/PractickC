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

string FibNum(int num)
{
    string result = string.Empty;
    int first = 0;
    int last = 1;
    int buf = 0;

    for (int i = 0; i < num; i++)
    {
        result = result +", "+ first;
        buf = first + last;
        first = last;
        last = buf;
    }
    return result;
}

int numFib = ReadData("Введите число Фибоначчи: ");
string line = FibNum(numFib);
PrintResult("Числа Фибоначчи " + line);