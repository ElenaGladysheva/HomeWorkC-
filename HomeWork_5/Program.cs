//ДЗ 5

int[] CreatRandomArray(int size, int minValue, int maxValue) //Метод заполнения массива случайными числами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);
    return array;
}
void ShowArray(int[] array) // Метод вывода массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
/*
int CountPositivNumber(int[] array) // Метод подсчета количества четных чисел в одномерном массиве.
{
    int count = 0;
    for(int i = 0; i < array.Length; i ++)
        if (array[i] % 2 == 0)
            count ++;
    return count;
}

Console.Clear();

Console.Write("Input the size of array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(n, minV, maxV);

ShowArray(myArray);

Console.WriteLine($"The amount of positiv elements in array is {CountPositivNumber(myArray)}");
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int SumOddPosition (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Clear();

Console.Write("Input the size of array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(n, minV, maxV);

ShowArray(myArray);

Console.WriteLine($"The sum elemens in odd positions is {SumOddPosition(myArray)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
