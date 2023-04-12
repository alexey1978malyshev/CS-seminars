// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*int CountPosNumbers(int[] numbersArray)
{
    int count = 0;
    for (int i = 0; i < numbersArray.Length; i++)
    {
        if (numbersArray[i] > 0) count++;
    }
    return count;
}
Console.WriteLine("How many numbers would you want to input?");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayNum = new int[size];
Console.WriteLine("Input a numbers: ");
for (int i = 0; i < size; i++)
{
    arrayNum[i] = Convert.ToInt32(Console.ReadLine());
}
int posNum = CountPosNumbers(arrayNum);

Console.WriteLine($"The count of positive numbers is: {posNum}");*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*double[] CrossPointTwoLines(double k1, double b1, double k2, double b2)
{
    double[] coordinatePointArray = new double[2];
    if (k1 != k2 && b1 != b2)
    {
        coordinatePointArray[0] = (b1 - b2) / -(k1 - k2);
        coordinatePointArray[1] = k2 * coordinatePointArray[0] + b2;
    }
    else System.Console.WriteLine("Lines have not a crosspoint..");

    return coordinatePointArray;
}
 
Console.WriteLine("Input k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
double[] CrossPointArr = CrossPointTwoLines(k1,b1,k2,b2);
Console.WriteLine($"Coordinates of lines crosspoint: x = {CrossPointArr[0]}, y = {CrossPointArr[1]}");

*/