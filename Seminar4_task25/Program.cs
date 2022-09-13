//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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

int Calculate(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}


int numberA = ReadData("Введите число А: ");
int numberB = ReadData("Введите число B: ");
int sum = Calculate(numberA, numberB);
PrintResult("Число А в степени числа Б = " + sum);
