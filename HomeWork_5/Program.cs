//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int [] CreatRandomArray (int size, int min, int max)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray [i] = new Random().Next(min, max + 1);
    return newArray;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void CountOfEvenNumbers (int [] array1)
{
    int count = 0;

    for (int i = 0; i < array1.Length; i++)
        if (array1 [i] % 2 == 0)
            count ++;
    Console.WriteLine($"Count of even numbers is {count}"); 
}

int size = 12;
int min = 100;
int max = 999;

int [] createdArray = CreatRandomArray (size, min, max);
ShowArray(createdArray);
CountOfEvenNumbers(createdArray);
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int [] CreateRandomArray(int size, int min, int max)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray [i] = new Random().Next(min, max + 1);
    return newArray;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

void SummOfEvenNumbers(int [] array1)
{
    int summ = 0;

    for (int i = 0; i < array1.Length; i++)
        if (i % 2 ==0)
            summ += array1 [i];
    Console.WriteLine($"Summ numbers on even positions is {summ}");
}

int size = 5;
int min = 1;
int max = 10;

int [] createdArray = CreateRandomArray(size, min, max);
ShowArray(createdArray);
SummOfEvenNumbers(createdArray);
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int [] CreateRandomArray(int size, int min, int max)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray [i] = new Random().Next(min, max + 1);
    return newArray;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

int MinFinder (int [] array1)
{
    int minVal = array1 [0];

    for (int i = 0; i < array1.Length; i++)
        if (minVal > array1 [i])
            minVal = array1 [i];
    return minVal;
}

int MaxFinder (int [] array2)
{
    int maxVal = array2 [0];

    for (int i = 0; i < array2.Length; i++)
        if (maxVal < array2 [i])
            maxVal = array2 [i];
    return maxVal;
}

void DefferenceFinder (int min, int max)
{
    int differenceToFind = max - min;
    Console.WriteLine($"Difference is {differenceToFind}");
}

int size = 5;
int min = 1;
int max = 10;

int [] createdArray = CreateRandomArray(size, min, max);
ShowArray(createdArray);
int minRes = MinFinder(createdArray);
int maxRes = MaxFinder(createdArray);
DefferenceFinder(minRes, maxRes);