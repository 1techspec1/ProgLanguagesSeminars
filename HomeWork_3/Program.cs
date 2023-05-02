//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет, 12821 -> да, 23432 -> да

//ХОД РАССУЖДЕНИЙ
/*
//выделение 1-й цифры
int firstDigit = userNumber / 10000;
Console.WriteLine ("First digit is " + firstDigit);

//выделение 5-й цифры
int fifthDigit = userNumber % 10;
Console.WriteLine ("Fifth digit is " + fifthDigit);

//выделение 2-й цифры
int secondDigit = userNumber / 1000 % 10;

Console.WriteLine ("Second digit is " + secondDigit);

//выделение 4-й цифры
int forthDigit = userNumber % 100 / 10;
Console.WriteLine ("Forth digit is " + forthDigit);

if (firstDigit == fifthDigit || secondDigit == forthDigit)
    Console.WriteLine ($"Your number {userNumber} is a palindrome!");
else
    Console.WriteLine ($"Your number {userNumber} is not a palindrome!");
*/

//РЕШЕНИЕ
/*
void PalindromeFinder (int num)
{
    int firstDigit = num / 10000;
    int fifthDigit = num % 10;
    int secondDigit = num / 1000 % 10;
    int forthDigit = num % 100 / 10;

if (firstDigit == fifthDigit || secondDigit == forthDigit)
    Console.WriteLine ($"Your number is a palindrome!");
else
    Console.WriteLine ($"Your number is not a palindrome!");
}

Console.WriteLine ("Input your 5-digits number: ");
int userNumber = Convert.ToInt32 (Console.ReadLine());

if (userNumber > 9999 && userNumber < 99999)
    PalindromeFinder (userNumber);
else
    Console.WriteLine ("Impossible value!");
*/


//-------------------------------------------------------------


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double StraightLine (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double lenghtAB = Math.Sqrt ((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return lenghtAB;
}

Console.WriteLine ("Input X coordinate of A point: ");
int xCoordA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Y coordinate of A point: ");
int yCoordA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Z coordinate of A point: ");
int zCoordA = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input X coordinate of B point: ");
int xCoordB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Y coordinate of B point: ");
int yCoordB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Z coordinate of B point: ");
int zCoordB = Convert.ToInt32 (Console.ReadLine());

double distance = StraightLine (xCoordA, yCoordA, zCoordA, xCoordB, yCoordB, zCoordB);

Console.WriteLine ($"Distance AB is {distance:f2}");
*/


//-------------------------------------------------------------


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void QubeFinder (int numberN)
{
    if (numberN > 0)
    {
        int current_i = 1;
        while (current_i <= numberN)
            {
                double res = Math.Pow (current_i, 3);
                Console.Write ($"{res}, ");
                current_i ++;
            }
        Console.WriteLine ("\b\b.");
    }
    else
    {
        int current_i = 1;
        while (current_i >= numberN)
        {
            Console.Write (current_i * current_i + ", ");
            current_i --;
        }
        Console.WriteLine ("\b\b.");
    }
}

Console.WriteLine ("Input your number: ");
int userNumber = Convert.ToInt32 (Console.ReadLine());

QubeFinder (userNumber);