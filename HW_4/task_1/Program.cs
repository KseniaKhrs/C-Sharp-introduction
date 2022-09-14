// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Решить задачу с использованием методов.

int GetPower(int numA, int numB)
{
    int pow = 1;
    for (int i = 0; i < numB; i++)
    {
        pow = pow * numA;
    }
    return pow;
}

Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int result = GetPower(numberA, numberB);
Console.WriteLine(result);