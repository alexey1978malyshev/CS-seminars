//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.
// void ShowNums(int num)
// {
//     Console.Write(num + " "); 
//     if (num > 1)   ShowNums(num-1);
//     Console.Write(num + " ");    
// }
// ShowNums(5);

/* 
Напишите программу, которая будет принимать на вход 
число и возвращать сумму его цифр.
*/

// int SumOfDigits(int num)
// {    
//     if (num != 0) return SumOfDigits(num / 10) + num % 10;

//     else return 0;
// }
// System.Console.WriteLine(SumOfDigits(1234));

/*Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке
 от M до N.*/

void ShowNums(int m, int n)
{
    if (m > n)
    {
        Console.Write(m + " ");
        if (m >= n) ShowNums(m - 1, n);
    }
    if (n > m)
        Console.Write(n + " ");
    if (m >= n) ShowNums(m, n - 1);
}
ShowNums(1, 10);
/*Напишите программу, которая на вход принимает
 два числа A и B, 
и возводит число А в целую степень B.*/

int PowDigit(int num, int exponent)
{
    if (exponent > 0) return PowDigit(exponent-1);

    if(exponent < 0) return;

    
}

