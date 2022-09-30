// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunct(int m, int n)
{
    if (m == 0) 
    {
        return n + 1; 
    }
    else if (m > 0 && n == 0) 
    {
        return AckermannFunct((m - 1), 1); 
    }
    else
    {
        return AckermannFunct((m - 1), AckermannFunct(m, (n - 1)));
    }
}

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunct(m, n);
Console.WriteLine($"A({m},{n}) = {result}");


