// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
while (count < number) {
    Console.Write($"{count}, ");
    count++;
}
Console.Write(number);
