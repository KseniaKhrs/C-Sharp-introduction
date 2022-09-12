// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void IsItPalindrome(string number) 
{
    if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число НЕ является палиндромом");
}

Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
IsItPalindrome(num);

