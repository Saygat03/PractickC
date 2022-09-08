//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine()??"0");
    //Возвращаем значение
    return number;
}

bool TestPalindrom(int num)
{
    if ((num / 10000 == num%10 && (num / 1000)%10 == (num / 10) % 10)) 
    {
    return true;
    }
    else 
    {
        return false;
    }
}

void PrintResult(int num)
{
    if (TestPalindrom(num)) {
        Console.WriteLine("Ваше число палиндром");
    }
    else
    {
        Console.WriteLine("Ваше число не палиндром");
    }
    
}
int checkedLine = ReadData("Введите число: ");
PrintResult(checkedLine);
