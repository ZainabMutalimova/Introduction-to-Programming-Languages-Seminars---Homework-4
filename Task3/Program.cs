// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Решение с рандомайзером

// Console.WriteLine("Ввведите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("[" + String.Join(", ", FillArray(number)) + "]");
// int[] FillArray(int number)
// {
//     int[] array = new int[number];
//     for (int i= 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     return array;
// }


// Решение с ручным вводом элементов массива через запятую

Console.Write("Введите ряд чисел, разделенных запятой: ");
string? array = Console.ReadLine();
array = array + ",";
string ArrayCheck(string array) // функция удаления пробелов из строки
{
    string arrayCopy = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != ' ')
        {
            if (array[i] != '0' | array[i] != '1' | array[i] != '2' | array[i] != '3' | array[i] != '4' |  array[i] != '5' | array[i] != '6' | array[i] != '7' | array[i] != '8' | array[i] != '9' | array[i] != ',')
            {
                return "Ошибка ввода  символа: в строке введены не циферные символы и запятые. Попробуйте снова.";
            }
            arrayCopy += array[i];
        }
    }
    return arrayCopy;
}
int[] ArrayOfNumbers(string array) // функция  создания и заполнения массива из строки
{
    ArrayCheck(array);
    int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string arrayCopy = "";
        while (array[i] != ',' && i < array.Length)
        {
            arrayCopy += array[i];
            i++;
        }

        arrayOfNumbers[j] = Convert.ToInt32(arrayCopy);    // заполняем массив значениями из строки
        if (i < array.Length-1) // добавляем новый элемент в конец массива
        {
        arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();
        }
        j++;
    }
    return arrayOfNumbers;
}

Console.Write("[" + String.Join(", ", ArrayOfNumbers(array)) + "]");