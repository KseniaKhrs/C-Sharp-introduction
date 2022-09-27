// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] GetArray (int m, int n, int min, int max)
{
    int[,] resultArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = new Random().Next(min, max);
        }
    }
    return resultArray;
}

int FindMinSumLine (int[,] array)
{
     int sum = 0;
     int indexMin = 0;
     int minSum = 0;
     for (int i = 0; i < array.GetLength(0); i++)
     {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (i == 0 || sum < minSum) 
        {
            minSum = sum;
            indexMin = i;
        }
     }
     return (indexMin+1);
}

Console.WriteLine ("Введите число строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray (m, n, 0, 10);

Console.WriteLine("Сгенирирован следующий массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int indexMinSum = FindMinSumLine (array);
Console.WriteLine(indexMinSum + " - номер строки с наименьшей суммой элементов");

