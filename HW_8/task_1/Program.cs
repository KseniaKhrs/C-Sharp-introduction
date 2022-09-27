// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

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

int [,] ChangeArrayMaxToMin (int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
     {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j; k < array.GetLength(1); k++)
            {
                int tmp = 0;
                if (array [i,j] < array [i,k])
                {
                    tmp = array [i,j];
                    array [i,j] = array [i,k];
                    array [i,k] = tmp;
                }
            }
        }
     }
     return array;
}

Console.WriteLine ("Введите число строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray (m, n, -100, 100);

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

int [,] newArray = ChangeArrayMaxToMin (array);
Console.WriteLine("Измененный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        Console.Write(newArray[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();