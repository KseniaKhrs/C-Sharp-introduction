// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int GetPositiveQuantity(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите количество вводимых чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
Console.WriteLine($"Введите числа поочередно, каждое число с новой строки: ");
for (int i = 0; i < m; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int quantity = GetPositiveQuantity(array);
Console.WriteLine($"Количество положительных чисел равно {quantity}.");