//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1

Console.WriteLine ("Input your 3-digit number: ");
int userNumber = Convert.ToInt32 (Console.ReadLine());

/*int Digit (int number)
{
    int dec = number % 100;
    int secDigit = dec / 10;
}

if (userNumber > 99 && userNumber < 1000)
{
    Digit (userNumber);
    int res = Digit (userNumber);
    Console.WriteLine ($"Second digit is {res}");
}
else
{
    Console.WriteLine ("WRONG!");
}
*/