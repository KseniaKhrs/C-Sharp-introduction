//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumDigit(int number)
{
    int result = 0;
    int tmp = Math.Abs(number);
    int sum = 0;
    while (tmp > 0)
    {
        sum = sum + (tmp % 10);
        tmp = tmp / 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int sum = GetSumDigit(num);
Console.WriteLine(sum);



