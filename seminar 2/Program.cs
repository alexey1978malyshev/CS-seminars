//Напишите программу, которая на вход принимает случайное 3х значное число
//и удаляет вторую цифру этого числа

// int CutNumber(int num)
// {
//    int hundreds = num /100;
//    int units = num % 10;
//    return hundreds * 10 + units; 
// }

// int randNum = new Random().Next(100,1000);

// int newNum = CutNumber(randNum);
// Console.Write($"New version of {randNum} is {newNum}");

// Напишите программу, которая выводит случайное число из отрезка (10,99) 
//и показывает наибольшую цифру числа

// int MaxDigit(int num)
// {
//     int firstDigigt = num / 10;
//     int secondDigit = num % 10;
//     if (firstDigigt > secondDigit)
//     {
//         return firstDigigt;
//     }
//     else
//     {
//         return secondDigit;
//     }
// }
// int randNum1 = new Random().Next(10,100);

// int maxDigit = MaxDigit(randNum1);
// Console.Write($"Random number is {randNum1}, max digit is {maxDigit}");


//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
// bool CheckDivider(int num, int a, int b)
// {
//     if (num % a == 0 && num % b == 0)
//         return true;
//     else
//         return false;

// }
// Console.Write("Input a number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input two number:");
// int div1 = Convert.ToInt32(Console.ReadLine());
// int div2 = Convert.ToInt32(Console.ReadLine());
// bool result = CheckDivider(num, div1, div2);
// Console.WriteLine(result);

//Напините программу, которая принимает на вход два числа и проверяет,
// является ли одно число квдратом другого
// Console.Write("Input two numbers:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());

// bool CheckQuad(int num1, int num2)
// {
//     if(num1 * num1 == num2 || num2 * num2 == num1) return true;
//     else return false;
// }
// bool result = CheckQuad(number1,number2);
// Console.WriteLine(result);

//HomeWork:

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// int ShowSecondDigit(int number)
// {
//     if (99 < number && number < 1000)
//     {
//         int secondDigit = number / 10 % 10;
//         return secondDigit;
//     }
//     else 
//         return -1;
// }

// Console.WriteLine("Input a 3-digit number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The second digit of number is {ShowSecondDigit(num)}");






// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int ShowThirdDigit(int number)
// {    
//     while (number >= 1000)
//     {
//         number /= 10;
//     }
//     int thirdDigit = number % 10;
//     return thirdDigit;
// }

// Console.WriteLine("Input a number:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99)

//     Console.WriteLine($"The third digit of number is {ShowThirdDigit(num)}");

// else
//     Console.WriteLine($"There is not third digit in the number..");



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// bool FindWeekend(int day)
// {
//     if (day == 6 || day == 7)
//     {
//         return true;
//     }
//     else

//         return false;
// }
// Console.WriteLine("Input a day of the week number: ");
// int dayOfWeek = Convert.ToInt32(Console.ReadLine());
// if (FindWeekend(dayOfWeek) == true) Console.WriteLine("Yes");
// else Console.WriteLine("No");



