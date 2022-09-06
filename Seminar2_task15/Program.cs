//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
string? inputLine = Console.ReadLine();
int inputNumber = int.Parse(inputLine);

if (inputNumber < 8)
{

    if (inputNumber > 5)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}    
else 
{
    Console.WriteLine("Введено некорректное значение");
}
