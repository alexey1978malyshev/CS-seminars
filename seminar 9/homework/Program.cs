// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowArrayFromNTo1(int n)
{
    Console.WriteLine(n + " ");
    if(n>1) ShowArrayFromNTo1(n-1);   
}
ShowArrayFromNTo1(15);
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int ShowSumFromMToN(int m, int n)
{

    if (n > m)
    {
        return ShowSumFromMToN(m, n - 1) + n;
    }
    else if (n == m) return n;
    if (m > n)
    {
        return ShowSumFromMToN(m - 1, n) + m;
    }
    else if (n == m) return m;
    else return 0;
}
Console.WriteLine(ShowSumFromMToN(15, 1));

*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29 воссоздать ф-ию аккермана не вдаваяcь в подробности

int Ackerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ackerman(n - 1, 1);
    else return Ackerman(n - 1, Ackerman(n, m - 1));
}
Console.WriteLine(Ackerman(3, 2));