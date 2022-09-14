// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Элементы массива вводятся пользователем.

void PrintArray(int num)
{
    int[] array = new int[num];
    Console.WriteLine("\nПоочередно введите элементы массива': ");
    for (int i = 0; i < num; i++)
    {
        int tmp = int.Parse(Console.ReadLine());
        array[i] = tmp;
    }
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("\nВведите число элементов в массиве: ");
int number = int.Parse(Console.ReadLine());
PrintArray(number);