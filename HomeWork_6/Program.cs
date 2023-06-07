//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int [] UserArray (int size)
{
    int [] userArray = new int [size];

    for (int i = 0; i < size; i++)
        {Console.Write("Input number: ");
        int tempNum = Convert.ToInt32(Console.ReadLine());
        userArray[i] = tempNum;
        }
    return userArray;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

void CountPositivNumbers (int [] array1)
{
    int count = 0;

    for (int i = 0; i < array1.Length; i++)
            if (array1[i] > 0)
                count ++;
   Console.WriteLine($"Positive numbers count is {count}");
}

Console.WriteLine("Input array size: ");
int arrayUserSize = Convert.ToInt32(Console.ReadLine());

int [] userArr = UserArray(arrayUserSize);
ShowArray(userArr);
CountPositivNumbers(userArr);
*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)