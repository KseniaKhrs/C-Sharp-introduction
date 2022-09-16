// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int GetRange (int[] array)
{
    int minNum = array[0];
    int maxNum = array[0];
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
    int range = maxNum - minNum;
    return range;
}

int [] array = {300, 50, 24, -6, 78};
var rangeArray = GetRange(array);
Console.WriteLine ($"Разница максимального и минимального значений равна {rangeArray}");