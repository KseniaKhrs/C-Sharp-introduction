// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

string GetSequence(int num)
{
    if (num == 1) 
    {
        return "1"; 
    }
    else
    {
        return GetSequence(num - 1) + " " + num;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string sequence = GetSequence(number);
Console.WriteLine(sequence);