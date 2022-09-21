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

string BinConvert(int A)
{
    string result = string.Empty;
    while (A> 0)
    {
        result = result + A%2;
        A = A/2;
    }
    return result;
}

int inputNumber = ReadData("Введите число: ");
PrintResult($"Число {inputNumber} в двоичной системе счисления: {BinConvert(inputNumber)}");