//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1


/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
*/


//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
//Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i+j;   // заполнение массива 
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
*/

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//и замените эти элементы на их квадраты.
/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void MatrixPows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //   или i+=2 можно неделать проверку
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if((i%2)==0 && j%2==0) array[i,j] = array[i,j]*array[i,j];
        }
        Console.WriteLine();
    }
}
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
MatrixPows(matrix);
PrintMatrix(matrix);
*/

//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
//(с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12


/*
int[,] FillMatrixWithRandom(int row, int column)
{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} \t");
}
Console.WriteLine();
}
}

int SumMainDiagonal(int[,] matrix)
{
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if(i == j)
{
sum+=matrix[i,j];
}
}
}
return sum;
}

int SumDiag(int[,] array)
{
int summDiag = 0;
int iMin = array.GetLength(0);
if (iMin > array.GetLength(1)) iMin = array.GetLength(1);

for (int i = 0; i < iMin; i++)
{
    summDiag += array[i,i];
}
return summDiag;
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine(SumMainDiagonal(matrix));
System.Console.WriteLine(SumDiag(matrix));
*/


/* 3-й вариант
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, m];
            Console.WriteLine("Вводите числа:");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Сумма диагонали:");
            int sum = 0;
            for (int i = n-1; i >= 0; --i)
            {
                for (int j = m-1; j >= 0; --j)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
*/