//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ThirdDigit () {
    Console.WriteLine("Введите число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()));
if (number >= 100) {
    int count = 1;
    int tmp = number;
    while (tmp >= 1000) {
        tmp = tmp/10;
        count = count * 10;
    }
    Console.WriteLine((number/count%10));
    }
else Console.WriteLine("Третьей цифры нет");
}
ThirdDigit();
