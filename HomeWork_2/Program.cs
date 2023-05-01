//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1

/*
Console.WriteLine ("Input your 3-digit number: ");
int userNumber = Convert.ToInt32 (Console.ReadLine());

int Digit (int number)
{
    int dec = number % 100;
    int secDigit = dec / 10;
    return secDigit;
}

if (userNumber > 99 && userNumber < 1000)
{
    Digit (userNumber);
    int res = Digit (userNumber);
    Console.WriteLine ($"Second digit is {res}");
}
else
{
    Console.WriteLine ("Your number is not 3-digit!");
}
*/





//Задача Задача 13.
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*
void ItsTherdDigit (int number)
{
    if (number > -100 && number < 100)
{
 Console.WriteLine ("The Number " + number + " hasnt 3-d digit");
}
else if (number > 99 && number < 1000)
{
    int therdNumber = number % 10;
    Console.WriteLine ("3-d digit is " + therdNumber);
}
else if (number > 1000 && number < 10000)
{
    int therdNumber = number % 100;
    int res = therdNumber / 10;
    Console.WriteLine ("3-d digit is " + res);
}
else if (number > 10000 && number < 100000)
{
    int therdNumber = number % 1000;
    int res = therdNumber / 100;
    Console.WriteLine ("3-d digit is " + res);
}
else if (number < -99 && number > -1000)
{
    int therdNumber = number % 10;
    Console.WriteLine ("3-d digit is " + therdNumber * -1);
}
else if (number < -1000 && number > -10000)
{
    int therdNumber = number % 100;
    int res = therdNumber / 10;
    Console.WriteLine ("3-d digit is " + res * -1);
}
else if (number < -10000 && number > -100000)
{
    int therdNumber = number % 1000;
    int res = therdNumber / 100;
    Console.WriteLine ("3-d digit is " + res * -1);
}
}

Console.WriteLine ("Input your number: ");
int userNumber = Convert.ToInt32 (Console.ReadLine());

ItsTherdDigit (userNumber);
*/



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да, 7 -> да, 1 -> нет

void Weekend (int number)
{
    if (number > 5 && number < 8)
    {
    
        Console.WriteLine ("Yes! Digit " + number + " means weekend!");
    }
    else
    {
        Console.WriteLine ("Your digit " + number + " isnt weekend!");
    }
}

Console.WriteLine ("Input your number from 1 to 7: ");
int userNumber = Convert.ToInt32 (Console.ReadLine());

Weekend (userNumber);