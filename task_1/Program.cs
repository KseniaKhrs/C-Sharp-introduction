//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 < number2) {
    Console.WriteLine($"Максимальое число - {number2}, минимальное число - {number1}");
    }
if (number2 < number1) {
    Console.WriteLine($"Максимальое число - {number1}, минимальное число - {number2}");
    }
else {
    Console.WriteLine("Числа равны");
    }
