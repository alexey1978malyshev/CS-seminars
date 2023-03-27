// int number1 = 5;
// // double number2 = 12.65;

// /*string word = "my word";
// char symbol = '@';

// bool check = true;*/


// int num = 5;
// int num2 = 7;

// //Console.WriteLine(num);

// Console.WriteLine("My numbers are " + num + " and " + num2 + " and it is good!");
// Console.WriteLine($"My numbers are {num} and {num2} and it is good!");
// Console.Write("Input a number: ");

// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your number is " + num1);

// Homework 1
// Task 1. Напишите программу, которая навход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad2 = num2 * num2;

// if (num1 == quad2)
// {
//     Console.WriteLine("Да!");
// }
// else
// {
//     Console.WriteLine("Нет!");
// }


// Task2. Напишите програму, которая на вход принимает одно число(N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Input a positive number: ");
// try
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     int current = -num;

//     while(current <= num)
//     {
//         Console.Write(current + " ");
//         current++;
//     }
// }
// catch (System.Exception)
// {
//    Console.WriteLine("Wrong...");
// }


// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

// Console.WriteLine("Please, enter two number: ");

// try
// {
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     int num2 = Convert.ToInt32(Console.ReadLine());
//     if (num1 > num2)
//     {
//     Console.WriteLine($"{num1} bigger than {num2}");  
//     }
//     if (num1 < num2)
//     {
//        Console.WriteLine($"{num2} bigger than {num1}"); 
//     }
//     if (num1 == num2)
//     {
//         Console.WriteLine("Numbers are equal..");
//     }
// }
// catch (System.Exception)
// {
//     Console.WriteLine("Something wrong... seeming not numbers..");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Please, enter three numbers: ");

// int max = 0;
// try
// {
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     int num2 = Convert.ToInt32(Console.ReadLine());
//     int num3 = Convert.ToInt32(Console.ReadLine());
//     if (num1 > num2 && num1 > num3)
//         max = num1;
//     if (num2 > num1 && num2 > num3)
//         max = num2;
//     if (num3 > num1 && num3 > num2)
//         max = num3;

// Console.WriteLine("max = " + max);  

// }
// catch (System.Exception)
// {
//    Console.WriteLine("Something wrong... it is not a number..");

// }

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Please, enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 2 == 0)
// Console.WriteLine("Yes");
// else
// Console.WriteLine("No");

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine("Please, enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= num; i++)
// {
//     if (i % 2 == 0)
//         Console.Write(i + " ");      
// }






