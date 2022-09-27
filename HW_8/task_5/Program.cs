// Напишите программу, которая заполнит спирально массив 4 на 4.

int [,] GetSpiralArray(int row, int column, int minNum)
{
    int[,] array = new int[row,column];
    int i = 0;
    int j = 0;
    array [i,j] = minNum;
    while (i < array.GetLength(0) && i >= 0 && j < array.GetLength(1) && j >= 0)
    {
        if ((j+1) < array.GetLength(1) && array[i,j+1] == 0 && ((i-1) < 0 || array[i-1,j] != 0 ))
        {
                    array[i,j+1] = array[i,j] + 1;
            j = j + 1;
        }
        else if ((i+1) < array.GetLength(0) && array[i+1,j] == 0) 
        {
            array[i+1,j] = array[i,j] + 1;
            i = i + 1;
        }
        else if ((j-1) >= 0 && array[i,j-1] == 0) 
        {
            array[i,j-1] = array[i,j] + 1;
            j = j - 1;
        }
        else if ((i-1) >= 0 && array[i-1,j] == 0) 
        {
            array[i-1,j] = array[i,j] + 1;
            i = i - 1;
        }
        else break;
    }
    return array;
}

Console.WriteLine ("Введите число строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = GetSpiralArray (m, n, 1);

Console.WriteLine("Сгенирирована следующая матрица: ");
for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        if (array[x,y] < 10) Console.Write(" " + array[x,y] + " ");
        else Console.Write(array[x,y] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();