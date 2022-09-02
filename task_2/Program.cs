//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введи первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введи второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введи третье число: ");
int numberC = int.Parse(Console.ReadLine());
int maxNumber = 0;
if (numberA > numberB) {
    maxNumber = numberA;
}
else {
    maxNumber = numberB;
}
if (maxNumber < numberC) {
    maxNumber = numberC;
    }
Console.WriteLine($"Максимальное число - {maxNumber}");
