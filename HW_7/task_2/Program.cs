// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

 string GerArrayElement(int[,] array, int index1, int index2)
 {
    if (index1 >= 0 && index1 < array.GetLength(0) && index2 >= 0 && index2 < array.GetLength(1))
    {
        return $"Элемент массива на позиции ({index1}, {index2}) равен {array[index1, index2]}";
    }
    else 
    {
        return "В массиве отсутствует число с заданными индексами";
    }
 }

Console.WriteLine ("Введите число строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = GetArray (m, n, -1000, 1000);

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

Console.WriteLine ("Введите индекс строки нужного элемента массива: ");
int index1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите индекс столбца нужного элемента массива: ");
int index2 = Convert.ToInt32(Console.ReadLine());

var result = GerArrayElement(array, index1, index2);
Console.WriteLine (result);