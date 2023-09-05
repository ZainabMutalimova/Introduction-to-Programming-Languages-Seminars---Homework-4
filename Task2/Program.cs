// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Ввведите число");
string stringNumber = Console.ReadLine();
Console.WriteLine($"Сумма цифр введенного числа равна {SumOfDegree(stringNumber)}");
int SumOfDegree(string? stringNumber)
{
    int count = 0;
    int SumOfDegree = 0;
    int number = int.Parse(stringNumber);
    while (count < stringNumber.Length)
    {
        int degree = number % 10;
        SumOfDegree += degree;
        number /= 10;
        count++;
    }
    return SumOfDegree;
}