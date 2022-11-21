// ДЗ 7.

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreatRandom2ArrayD(int rows, int columns, int minValue, int maxValue) //Метод заполнения двумерного вещественного массива случайными числами
{
    double [,] array = new double [rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)

            array[i,j] = new Random().Next(minValue,maxValue) + new Random().NextDouble();
        
    return array;
}

void Show2ArrayD(double[,] array) // Метод вывода вещественного двумерного массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j],2) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Clear();

Console.Write("Input a count of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a count of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreatRandom2ArrayD(m, n, minV, maxV);

Show2ArrayD(myArray);

*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> числа с такими индексами в массиве нет

int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue) //Метод заполнения 2d массива случайными числами. 
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue + 1);
        
    return array;
}


void Show2Array(int[,] array) //Метод выводв 2D массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
     
}

/*
void PositionValue(int[,] array, int row, int column)
{
    if(row > array.GetLength(0) || column > array.GetLength(1))
        Console.WriteLine("No element!");
    else
        Console.WriteLine(array[row,column]);

}
Console.Clear();

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n, minV, maxV);
Show2Array(myArray);

Console.Write("Input position of row: ");
int posRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position of column: ");
int posColumn = Convert.ToInt32(Console.ReadLine());
PositionValue(myArray, posRow, posColumn);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ShowArray(double[] array) // Метод вывода массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double[] AvarageColumns(int[,] array)
{
    double[] avArray = new double[array.GetLength(1)];
    
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
           avArray[j] += array[i,j];

        avArray[j] = Math.Round(avArray[j]/array.GetLength(0),1);
    }
    return avArray;
}
Console.Clear();

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n, minV, maxV);

Show2Array(myArray);

ShowArray(AvarageColumns(myArray));