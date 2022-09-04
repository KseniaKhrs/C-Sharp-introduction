// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());
int count = 2;
while (count <= number) {
    if (count % 2 == 0) {
        if (count == number || count == number - 1) {
            Console.Write($"{count}");
        }
        else {
            Console.Write($"{count}, ");
        }
        
    }
    count++;
}

