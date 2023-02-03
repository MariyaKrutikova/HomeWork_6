/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double GetNumber(string message)
{
    double result = 0;
    Console.WriteLine(message);
    while(true)
    {if (double.TryParse(Console.ReadLine(), out result))
        break;
    else
        Console.WriteLine("Данные введены не корректно. Повторите ввод: ");
    }
    return result;
}

(double, double) GetIntersectionPoint(double k1, double k2, double b1, double b2)
{
    double x = 0;
    double y = 0; 
    if (k1 == k2 & b1 != b2)
    {
        Console.WriteLine("Прямые параллельны.");
    }
    if (b1 == b2 & k1 != k2)
    {
        x = 0;
        y = b1;
    }
    else 
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
    }
    return (x, y);
}

double k1 = GetNumber("Введите k1 для первой прямой: ");
double b1 = GetNumber("Введите b1 для первой прямой: ");
double k2 = GetNumber("Введите k2 для второй прямой: ");
double b2 = GetNumber("Введите b2 для второй прямой: ");

(double x, double y) = GetIntersectionPoint(k1, k2, b1, b2);

if (k1 != k2)
    Console.WriteLine($"Пересечением прямых y={k1}*x+{b1} и y={k2}*x+{b2} явялется точка ({Math.Round(x,1)}, {Math.Round(y,1)})");