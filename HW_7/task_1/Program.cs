// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray (int m, int n, int min, int max)
{
    double[,] resultArray = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = Math.Round((new Random().NextDouble()*(max - min) + min), 2);
        }
    }
    return resultArray;
}
int m = 3;
int n = 4;
int min = -1000;
int max = 1000;

double[,] array = GetArray(m, n, min, max);
for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }