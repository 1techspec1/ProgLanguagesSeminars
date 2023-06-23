//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double [,] CreatDouble2dArray (int row, int column, int minV, int maxV)
{
    double [,] created2dArray = new double [row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            created2dArray [i,j] = Math.Round((new Random().Next(minV, maxV)) + (new Random().NextDouble()), 2);
        }
    }
    return created2dArray;
}

void ShowDouble2DArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

double [,] createdArray = CreatDouble2dArray (userRows, userColumns, userMin, userMax);
ShowDouble2DArray (createdArray);
*/





//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет
/*
int [,] Creat2dArray (int rows, int column)
{
    int [,] creat2dArray = new int [rows, column];

    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < column; j ++)
        {
            creat2dArray [i,j] = new Random().Next();
        }
    }
    return creat2dArray;
}

void Show2DArray (int [,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] ShowElement (int [,] array2)
{
    Console.WriteLine("Enter number of row: ");
    int userRowNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number of column: ");
    int userColumnNum = Convert.ToInt32(Console.ReadLine());


    
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (userRowNum > i && userColumnNum == j)
                Console.WriteLine($"Element value with index '{userRowNum} {userColumnNum}' is {array2 [i,j]}!");
            else Console.WriteLine("Number doesn't exist into array!");
        }
    }
    return array2;
}

int rows = 10;

int columns = 10;

int [,] created2DArray = Creat2dArray (rows, columns);

int [,] showElement = ShowElement(created2DArray);

Show2DArray(created2DArray);
*/





//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double [,] Create2dArray(int rows, int columns, int min, int max)
{
    double [,] create2dArray = new double [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            create2dArray [i,j] = Math.Round((new Random().Next(min, max)) + (new Random().NextDouble()), 0);
        }
    }
    return create2dArray;
}

void Show2DArray(double [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write(array[j, i] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageArray (double [,] array2)
{
    double sum = 0;
    double average = 0;

    for (int j = 0; j < array2.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            sum += array2[i,j];
        }
        average = sum / array2.GetLength(0);
        Console.Write(average + " ");
    }
}



int userRows = 3;
int userColumns = 3;
int userMin = 0;
int userMax = 9;
Console.WriteLine();

double [,] new2dArray = Create2dArray(userRows, userColumns, userMin, userMax);
Show2DArray(new2dArray);
Console.Write("Average of every column is - ");
AverageArray(new2dArray);