//=========================================
//Напишите программу, которая на вход принимает 
//число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//=========================================

string? inputLine = Console.ReadLine();

if (inputLine != null) 
    {
        int inputNumber = int.Parse(inputLine);
        int result = inputNumber%2;

        if (result == 0) 
        {
            Console.WriteLine("Число четное");
        }
        else 
        {
            Console.WriteLine("Число нечетное");
        }
    }