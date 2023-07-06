//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNumbers (int n)
{
    if (n > 1) ShowNumbers (n - 1);
    Console.Write (" " + n); 
}

ShowNumbers(3);
Console.WriteLine();
*/




//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int ShowSum(int m, int n)
{
    if (m < n)  return ShowSum(m + 1, n) + m;
    else return 0;
}

int res = ShowSum (4, 8);
Console.WriteLine(res);
*/






//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int FindAkkermanFunction(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FindAkkermanFunction (n - 1, 1);
    else
      return FindAkkermanFunction (n - 1, FindAkkermanFunction(n, m - 1));
}

int res = FindAkkermanFunction(1, 3);
Console.WriteLine(res);