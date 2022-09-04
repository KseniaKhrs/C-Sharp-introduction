// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void IsItWeekend () {
    Console.WriteLine("Введите номер дня недели: ");
    int weekDayNumber = int.Parse(Console.ReadLine());
    if (weekDayNumber < 6 && weekDayNumber > 0) {
        Console.WriteLine("будний день");
    }
    else if (weekDayNumber == 6 || weekDayNumber == 7) {
        Console.WriteLine("выходной день");
    }
    else Console.WriteLine("введен неверный номер");
} 
IsItWeekend ();