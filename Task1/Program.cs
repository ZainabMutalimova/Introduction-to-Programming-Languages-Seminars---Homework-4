// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Ввведите число № 1 (основание)");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите число № 2 (степень)");
int number2 = Convert.ToInt32(Console.ReadLine());

int Power (int number1, int number2)
{
    int i=1;
    while (i < number2)
    {
        number1 *= number1;
        i++;
    }
    return number1;
}
Console.WriteLine($"Результат возведения в степень: {Power (number1, number2)}");