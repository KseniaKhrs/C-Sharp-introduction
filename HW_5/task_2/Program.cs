// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int GetOddSum (int[] array)
{    
    int oddSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            oddSum = oddSum + array[i];
        }
    }
    return oddSum;
}
int num = new Random().Next(1,100);
int[] array = new int[num];

for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(-1000,1000);
}

int sum = GetOddSum(array);
Console.WriteLine($"Сумма чисел на нечетных позициях в массиве равна {sum}");