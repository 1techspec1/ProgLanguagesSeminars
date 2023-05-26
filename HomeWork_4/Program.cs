//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
void ExponentFinder (int a, int b)
{
    int exponentToFind = 1;
    for (int i = 1; i <= b; i = i + 1)
    {
        exponentToFind = exponentToFind * a;
        
    }
    Console.WriteLine($"Exponent {a} to {b} is {exponentToFind}");
}

Console.Write("Enter 1st number: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 2nd number: ");
int numB = Convert.ToInt32(Console.ReadLine());

ExponentFinder(numA, numB);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
void SumOfDigits(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    
    Console.WriteLine($"Sum digits is {sum}");
}

Console.Write("Input number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

SumOfDigits(userNumber);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] CreatNewArray (int size)   //метод создания массива
{
    int [] array = new int[size];                   //int(1) тип данных массива, [] - массив, array - имя массива, new - выделение памяти, int[размер массива]
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next();     //array[i] - значение элемента в массиве array на позиции i
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)      // .Lenght - считает количество элементов в массиве
        Console.WriteLine(array[i] + " ");
}
Console.WriteLine("Enter massive count of elements: ");
int countOfElem = Convert.ToInt32(Console.ReadLine());

int [] array1 = CreatNewArray(countOfElem);

ShowArray(array1);