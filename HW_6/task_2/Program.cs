// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double[] GetIntersection(double numK1, double numB1, double numK2, double numB2)
{
    double[] solution = new double[2];
    solution[0] = (numB2 - numB1) / (numK1 - numK2);
    solution[1] = numK1 * solution[0] + numB1;
    return solution;
}

Console.WriteLine("Введите параметры для двух прямых (y = k*x + b). Введите k1: ");
double numberK1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b1: ");
double numberB1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2: ");
double numberK2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2: ");
double numberB2 = Convert.ToDouble(Console.ReadLine());

double[] intersection = GetIntersection(numberK1, numberB1, numberK2, numberB2);
Console.WriteLine($"Прямые пересекаются в точке ({intersection[0]},{intersection[1]}).");