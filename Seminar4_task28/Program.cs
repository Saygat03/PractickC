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

long MultA(int numA)
{
    long sum = 1;
    int i = 1;
    
    while (i <= numA)
    {
        sum = sum * i;
        i++;
    }
    return sum;
}

int numberA = ReadData("Введите число: ");
long sum = MultA(numberA);
PrintResult("Факториал числа = " + sum);