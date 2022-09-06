// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число");
string? inputLine = Console.ReadLine();
int inputNumber = int.Parse(inputLine);

if (inputNumber > 100 && inputNumber < 1000)
{
    string str = Convert.ToString(inputNumber);
    Console.WriteLine("Вторая цифра числа = " + str[1]);
}
else
{
    Console.WriteLine("Введено некорректное значение");
}