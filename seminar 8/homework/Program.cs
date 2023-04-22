// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void LessOrderInRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition])
                {
                    maxPosition = k;
                }
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temp;
        }
    }
}
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
LessOrderInRows(newArray);
Show2dArray(newArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка
/*
int[,] CreateRandom2dArray()

{
    Console.WriteLine("Input a quantity of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columns other columns:");
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
int FindMinSumRow(int[,] array2d)
{
    if (array2d.GetLength(0) != array2d.GetLength(1))
    {
        int minValueRow = 1;
        int minSumElemInRow = 0;
        //проходимся по первой строке массива, чтобы сформировать  первичное значение суммы для sumElemInRow
        for (int i = 0; i < array2d.GetLength(1); i++)
        {
            minSumElemInRow += array2d[0, i];

        }
        // проходим по оставшимся строкам, после каждой сравниваем текущую сумму строки с sumElemInRow, если меньше - перезаписываем
        for (int i = 1; i < array2d.GetLength(0); i++)
        {
            int currentSum = 0;
            for (int j = 0; j < array2d.GetLength(1); j++)
            {
                currentSum += array2d[i, j];
            }
            if (currentSum < minSumElemInRow)
            {
                minSumElemInRow = currentSum;
                minValueRow = i + 1;
            }
            //System.Console.WriteLine($"minValueRow = {minValueRow} ---/--- minSumElemInRow = {minSumElemInRow}");
            currentSum = 0;
        }
        return minValueRow;
    }
    else    
        return -1;   

}

int[,] new2dArray = CreateRandom2dArray();
Show2dArray(new2dArray);
System.Console.WriteLine($"Tne minimum sum of elements has row number -<<{FindMinSumRow(new2dArray)}>>-");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int[,] CreateMatrixArray()

{
    Console.WriteLine("Input a size:");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = rows;
    Console.WriteLine("Input min value:");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value:");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(minVal, maxVal + 1);

    return matrix;
}
void ShowMatrix(int[,] array)
{
    Console.WriteLine($"********Matrix**********");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("********************************");
}

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }

    }
    return newMatrix;
}
int[,] matrix01 = CreateMatrixArray();
int[,] matrix02 = CreateMatrixArray();
ShowMatrix(matrix01);
ShowMatrix(matrix02);
int[,] newMatrix = MultMatrix(matrix01, matrix02);
ShowMatrix(newMatrix);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] Create3DArray()

{
    Console.WriteLine("Input 'x' rows:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input 'y' rows:");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input 'z' rows:");
    int z = Convert.ToInt32(Console.ReadLine());

    //Console.WriteLine("Input min value:");
    int minVal = 50;
    //Console.WriteLine("Input max value:");
    int maxVal = 99;

    int[,,] array3D = new int[x, y, z];
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
                array3D[i, j, k] = new Random().Next(minVal, maxVal + 1);
    return array3D;
}

void Show3DArray(int[,,] array)
{
    Console.WriteLine($"********3DArray**********");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
            }
            Console.Write(" *//* ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("********************************");
}

void ShowCoordinatesOfElem3DArray(int[,,] array)
{
    Console.WriteLine($"******************");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.Write(" *//* ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("**********************");
}


int[,,] new3DArr = Create3DArray();
int val = new Random().Next(11, 100);

//пытаемся найти и устранить дубликаты:
for (int i = 0, a = 1; i < new3DArr.GetLength(0) - 1; i++, a++)
{
    for (int j = 0, b = 1; j < new3DArr.GetLength(1) - 1; j++, b++)
    {
        for (int k = 0, c = 1; k < new3DArr.GetLength(2) - 1; k++, c++)
        {
            foreach (int item in new3DArr)
            {
                if (new3DArr[i, j, k] == item)
                {
                    new3DArr[i, j, k] = new Random().Next(11, 50);
                }               

            }

        }
    }
}

ShowCoordinatesOfElem3DArray(new3DArr);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
int[,] SpiralFillArray()
{
    Console.WriteLine("Input a quantity of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columns :");
    int columns = Convert.ToInt32(Console.ReadLine());


    int[,] array = new int[rows, columns];


    int startI = 0, startJ = 0, finishI = 0, finishJ = 0;
    int i = 0, j = 0;

    for (int step = 1; step <= rows * columns; step++)
    {
        array[i, j] = step;
        //пытаемся задать направления записи:
        if (i == startI && j < columns - finishJ - 1) j++;
        else if (j == columns - finishJ - 1 && i < rows - finishI - 1) i++;
        else if (i == rows - finishI - 1 && j > startJ) j--;
        else if(j == startJ && i > startI) i--;
        //сдвигаемся внутрь улитки:
        if ((i == startI + 1) && (j == startJ) && (startJ != columns - finishJ - 1))
        {
            startI++;
            startJ++;
            finishI++;
            finishJ++;
        }
    }

    return array; //это ппц...
}
void Show2dArray(int[,] array)
{
    Console.WriteLine("********2dArray**********");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else
                Console.Write(array[i, j] + " ");
        }

        Console.WriteLine();
    }
    Console.WriteLine("**************************");
}
int[,] newArray = SpiralFillArray();
Show2dArray(newArray);
*/


