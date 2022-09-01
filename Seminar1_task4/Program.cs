//=========================================
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//=========================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineС = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineС != null)
    {
        int inputNumberA = int.Parse(inputLineA);
        int inputNumberB = int.Parse(inputLineB);
        int inputNumberC = int.Parse(inputLineС);

        if (inputNumberA>inputNumberB) 
        {
           if (inputNumberA > inputNumberB)
           {
            Console.WriteLine("Максимальное число A = " + inputNumberA);
           }
           else 
           {
            Console.WriteLine("Максимальное число С = " + inputNumberC);
           }
        }
        else
        {
           if (inputNumberB>inputNumberC) 
           {
            Console.WriteLine("Максимальное число B = " + inputNumberB);
           }
           else
           {
            Console.WriteLine("Максимальное число C = " + inputNumberC);
           }
        }
    }