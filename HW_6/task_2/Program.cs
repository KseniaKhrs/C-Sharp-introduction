// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

string GetIntersection(double numK1, double numB1, double numK2, double numB2)
{
    if (numK1 == numK2) 
    {
        if (numB1 == numB2) 
        {
            return $"Решением является любая пара (x,y), для которой у = {numK1} * x + {numB1}";
        }
        else 
        {
            return "Нет решения";
        }
    }
    else
    {
        double[] solution = new double[2];
        solution[0] = (numB2 - numB1) / (numK1 - numK2);
        solution[1] = numK1 * solution[0] + numB1;
        return $"Прямые пересекаются в точке ({Math.Round(solution[0], 2)},{Math.Round(solution[1], 2)}).";
    }
    
}

Console.WriteLine("Введите параметры для двух прямых (y = k*x + b). Введите k1: ");
double numberK1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b1: ");
double numberB1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2: ");
double numberK2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2: ");
double numberB2 = Convert.ToDouble(Console.ReadLine());

var intersection = GetIntersection(numberK1, numberB1, numberK2, numberB2);
Console.WriteLine(intersection);
