// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] GetArray (int x, int y, int z, int min, int max)
{
    int[,,] resultArray = new int[x,y,z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++) 
            {
                int count = 1;
                int randomNumber = 0;
                while (count!=0) 
                {
                    randomNumber = new Random().Next(min, max);
                    count = 0;
                    for (int l = 0; l < x; l++) 
                    {
                        for (int m = 0; m < y; m++)
                        {
                            for (int n = 0; n < z; n++)
                            {
                                if (randomNumber == resultArray[l,m,n]) count++;
                            }
                        }
                    }
                }         
                resultArray[i,j,k] = randomNumber;
            }
        }
    }
    return resultArray;
}

Console.WriteLine ("Введите измерение x матрицы: ");
int numX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите измерение y матрицы: ");
int numY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите измерение z матрицы: ");
int numZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите максимальное число в матрице (не меньше чем x*y*z): ");
int numMax = Convert.ToInt32(Console.ReadLine());

int[,,] array = GetArray (numX, numZ, numY, 0, numMax+1);


Console.WriteLine("Сгенирирована следующая матрица: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i,j,k]} ({i}, {j}, {k})   ");
        }
        Console.WriteLine();
    }
}

