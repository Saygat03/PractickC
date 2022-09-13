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

int DigitCount (int num)
{
    return (int)(Math.Log10(num) + 1);
}

int numberA = ReadData("Введите число: ");
int sum = DigitCount(numberA);
PrintResult("Длина цифр в числе = " + sum);