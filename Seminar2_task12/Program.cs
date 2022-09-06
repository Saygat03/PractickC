int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

ReadData();
CalculateData();
PrintData();

void ReadData()
{
    Console.WriteLine("Введите первое число");
    string? inputLineA = Console.ReadLine();
    Console.WriteLine("Введите второе число");
    string? inputLineB = Console.ReadLine();

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);
}

void CalculateData()
{
    result = (inputNumberB % inputNumberA == 0);

}

void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Второе число НЕ кратно первому, остаток от деления " + inputNumberB % inputNumberA);
    }
}