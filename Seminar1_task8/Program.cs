//=========================================
//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//=========================================

string? inputLine = Console.ReadLine();

if (inputLine != null) 
    {
        int inputNumber = int.Parse(inputLine);
        int checkNumber = 2;

        while (checkNumber < inputNumber)
        {
            if (checkNumber%2 == 0)
            {
                Console.Write(checkNumber + " ");
            }
            checkNumber++;
        }
    }