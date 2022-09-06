// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
string? inputLine = Console.ReadLine();
int inputNumber = int.Parse(inputLine);

//string str = Convert.ToString(inputNumber);

if (inputNumber > 100)
{
    string str = Convert.ToString(inputNumber);
    Console.WriteLine("Третье число = " + str[2]);
}
else
{
    Console.WriteLine("У введенного значения нет третьей цифры");
}