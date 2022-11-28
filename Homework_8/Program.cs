﻿//Дз 8

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

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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