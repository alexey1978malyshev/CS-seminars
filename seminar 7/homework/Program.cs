/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*double[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a quantity of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min value:");
    double minVal = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input max value:");
    double maxVal = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round(new Random().Next(Convert.ToInt32(minVal), Convert.ToInt32(maxVal) + 1) //ЦЕЛАЯ ЧАСТЬ
                            + new Random().NextDouble(), 2);                                                //ВЕЩЕСТВЕННАЯ ЧАСТЬ

    return array;
}

void Show2dArray(double[,] array)
{
    Console.WriteLine("**************************");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine("**************************");
}

Show2dArray(CreateRandom2dArray());
*/




/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
(void)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет*/

/*int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a quantity of rows:"); //включение строк запроса позволяет избавиться от аргументов в большом количестве
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min value:");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value:");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minVal, maxVal + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("**************************");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine("**************************");
}

void ChekElemByPosition(int[,] array, int stroka, int stolbets)
{
    if (stroka >+ array.GetLength(0) || stolbets >= array.GetLength(1))
        Console.WriteLine("There no this element in array..");

    else Console.WriteLine($"The {array[stroka, stolbets]} on position -<{stroka}, {stolbets}>-");
}

int[,] newArray = CreateRandom2dArray();
System.Console.WriteLine("Inpot coordinates x...y...: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
ChekElemByPosition(newArray, x, y);
Console.WriteLine();
Show2dArray(newArray);
*/


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
пройтись по столбцам, сложить и поделить..(рез-т - одномереный массив)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] CreateRandom2dArray()

{
    Console.WriteLine("Input a quantity of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min value:");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value:");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minVal, maxVal + 1);

    return array;
}
void Show2dArray(int[,] array)
{
    Console.WriteLine("********2dArray**********");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine("**************************");
}
void ShowArray(double[] array)
{
    Console.WriteLine("********Array********");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
Console.WriteLine("*********************");
}

double[] CountAverageOfArrayColumns(int[,] array2d)
{
    double[] array = new double[array2d.GetLength(1)];
    double countSumElem = 0;    
    for (int i = 0; i < array2d.GetLength(1); i++)
    {
        for (int j = 0; j < array2d.GetLength(0); j++)
        {
            countSumElem += array2d[j,i];
        }
        array[i] = Math.Round(countSumElem / array2d.GetLength(0),1);
        countSumElem = 0;        
    } 
    return array;
}
int[,] new2dArray = CreateRandom2dArray();
Show2dArray(new2dArray);
double[] newArray = CountAverageOfArrayColumns(new2dArray);
ShowArray(newArray);