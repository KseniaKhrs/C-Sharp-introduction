//Напишите программу, которая принимает на вход число 
//(N) и выдаёт таблицу кубов чисел от 1 до N.

int[] GetCubesSequence(int num) {
   int[] cubes = new int [num];
   for (int i = 0; i < num; i++) {
    cubes[i] = (i+1)*(i+1)*(i+1);
   }
   return cubes;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int [] cubesList = GetCubesSequence(number);
for (int i = 0; i < number; i++) Console.Write($"{cubesList[i]} ");