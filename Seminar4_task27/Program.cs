// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

int SumDigit (int num)
{
    int sum = 0;
    while (num>0)
    {
        sum+= num%10;
        num = num / 10;
    }
    return sum;
}

int numberA = ReadData("Введите число: ");
int summ = SumDigit(numberA);
PrintResult("Сумма цифр в числе = " + summ);

