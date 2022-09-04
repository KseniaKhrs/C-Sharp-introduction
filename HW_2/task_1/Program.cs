//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void SecondDigit () {
    Console.WriteLine("Введите трехзначное число: ");
    int number = int.Parse(Console.ReadLine());
    int result = Math.Abs(number / 10 % 10);
    Console.WriteLine(result);
}
SecondDigit();
