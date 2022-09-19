// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double GetRange (double[] array)
{
    double minNum = array[0];
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
        else if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    double range = maxNum - minNum;
    return range;
}

double [] array = {300.7, 50.5, 24, -6.5, 78};
var rangeArray = GetRange(array);
Console.WriteLine ($"Разница максимального и минимального значений равна {rangeArray}");