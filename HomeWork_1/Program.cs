//Задача 2.
//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*Console.WriteLine ("Input 1st number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input 2nd number: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine ($"Your numbers are {num1} and {num2}. Min is {num2}. Max is {num1}");
}
else
{
    Console.WriteLine ($"Your numbers are {num1} and {num2}. Min is {num1}. Max is {num2}");
}
*/





//Задача 4.
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*Console.Write ("Input 1st number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Input 2nd number: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Input 3nd number: ");
int num3 = Convert.ToInt32 (Console.ReadLine());

int max = num1;

if (max < num2)
{
    max = num2;
}
else
{
    max = num1;
}

if (max < num3)
{
    max = num3;
    Console.WriteLine ($"Max number is {max}");
}
else
{
    Console.WriteLine ($"Max number is {max}");
}
*/



//Задача 6.
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

/*Console.Write ("Input your number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());

int dev = num1;

if (dev % 2 == 0)
{
    Console.WriteLine ($"Number {num1} is even number");
}
else
{
    Console.WriteLine ($"Number {num1} is not even number");
}
*/



//Задача 8.
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write ("Input your number: ");
int num_N = Convert.ToInt32 (Console.ReadLine());

for (int i = 0; i <= num_N; i++)
    if (i % 2 == 0)
    Console.Write(i + " ");
    