//Дз 8

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

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void SortRowArray(int[,] array) // Пузырькова сортировка в строках массива по убыванию
{
    int temp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            for (int k = array.GetLength(1)-1; k > j; k--)
            {
                if (array[i,k-1] < array[i,k])
                {   
                    temp = array[i,k-1];
                    array[i,k-1] = array[i,k];
                    array[i,k] = temp;
                } 
            }
        }
    }
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
Console.WriteLine();

SortRowArray(myArray);
Show2Array(myArray);
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*

void MinSumRow(int[,] array) //Нахождение строки в массиве с наименьшей суммой элементов
{   
    
    int [] rowSum = new int [array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)  
        for (int j = 0; j < array.GetLength(1); j++)
            rowSum[i] += array[i,j];     
        
    int min = rowSum[0];
    int row = 0;
    for (int i = 1; i < array.GetLength(0); i++)
        if(rowSum[i] < min)
        {
            min = rowSum[i];
            row = i;
        }
    Console.WriteLine($"The Line with the minimum sum is {row}.");
    
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
Console.WriteLine();

MinSumRow(myArray);
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] MultArray(int[,] array1, int[,] array2)
{       
    int m = array1.GetLength(0);
    int n = array2.GetLength(1);
    int p = array1.GetLength(1);

    int[,] resultArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0 ; k < p; k++)
                resultArray[i,j] += array1[i,k] * array2[k,j];
        }
    }
        
    return resultArray;
}
// void InrutArrayData (int numberArray)
// {
//     Console.WriteLine($"Data for array_{numberArray}:------------------")
//     Console.Write("Input a number of rows: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value:");
//     int minV = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value:");
//     int maxV = Convert.ToInt32(Console.ReadLine());
//     int [,] myArray = CreateRandom2Array(m, n, minV, maxV);

//     Show2Array(myArray);
//     Console.WriteLine();
// }

// Console.Clear();
// for (int i = 0; i < 2; i++)
// {
//     InrutArrayData (i);  
// }

Console.Clear();
Console.WriteLine($"Data for array_1:------------------");
Console.Write("Input a number of rows: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int minV1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV1 = Convert.ToInt32(Console.ReadLine());
int [,] myArray1 = CreateRandom2Array(m1, n1, minV1, maxV1);

Show2Array(myArray1);
Console.WriteLine();

Console.WriteLine($"Data for array_2:------------------");
Console.Write("Input a number of rows: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int minV2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV2 = Convert.ToInt32(Console.ReadLine());
int [,] myArray2 = CreateRandom2Array(m2, n2, minV2, maxV2);

Show2Array(myArray2);
Console.WriteLine();

if(myArray1.GetLength(1) != myArray2.GetLength(0))
    Console.WriteLine("Invalid array size!");
else
    Show2Array(MultArray(myArray1, myArray2));


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07