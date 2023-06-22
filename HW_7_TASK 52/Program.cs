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
    double count = 0;
    double average = 0;

    for (int j = 0; j < array2.GetLength(1); j++)
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            if (j < array2.GetLength(0))
            {
                sum += array2[i,j];
                count ++;
            }
            else
            {
                average = sum / count;
                Console.Write(average + " ");
                sum = 0;
                count = 0;
            }

        }
        
}



int userRows = 3;
int userColumns = 3;
int userMin = 0;
int userMax = 9;
Console.WriteLine();

double [,] new2dArray = Create2dArray(userRows, userColumns, userMin, userMax);
Show2DArray(new2dArray);
AverageArray(new2dArray);