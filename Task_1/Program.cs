/*Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int countOfNumbers(string[] numbers)
{
    int count = 0;
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {if (Int32.TryParse(numbers[i], out result) & result > 0)
        {
            count++;
        }
    }     
    return count;
}

Console.WriteLine("Введите числа: ");
string numbers = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Вы ввели: {numbers}");

char[] numberSeparators = {',', ';', ' ', '.', '_', '/'};
string[] numbersOnly = numbers.Split(numberSeparators, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine();
Console.WriteLine ($"Введены следующие чисела: {string.Join(' ', numbersOnly)}");

int count = countOfNumbers(numbersOnly);
Console.WriteLine();
Console.WriteLine($"Введено чисел больше нуля: {count}");


//Console.WriteLine($"Введено чисел: {numbersOnly.Length}");

