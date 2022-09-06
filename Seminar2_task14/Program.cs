Console.WriteLine("Введите число");
string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);

if (inputNumberA%7 == 0 && inputNumberA%23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23 ");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}