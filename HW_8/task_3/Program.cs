// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int [,] MultiMatrix (int [,] array1, int [,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
        
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int l = 0; l < array2.GetLength(1); l++)
            {
                int sum = 0;
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    sum = sum + array1[i,j]*array2[j,l];

                }
                result[i,l] = sum;
            }         
        }
        return result;
    }
    else 
    {
        return array1;
    }    
}





Console.WriteLine ("Введите число строк в матрице1: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число столбцов в матрице1: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число строк в матрице2: ");
int m2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число столбцов в матрице2: ");
int n2 = Convert.ToInt32(Console.ReadLine());


int[,] array1 = GetArray (m1, n1, 0, 10);
int[,] array2 = GetArray (m2, n2, 0, 10);

Console.WriteLine("Сгенирирована следующая матрица1: ");
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(array1[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Сгенирирована следующая матрица2: ");
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        Console.Write(array2[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int [,] resultArray = MultiMatrix (array1, array2);

Console.WriteLine("При перемножении матриц получен следующая матрица3: ");
for (int i = 0; i < resultArray.GetLength(0); i++)
{
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        Console.Write(resultArray[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

