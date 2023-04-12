// Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет 
// на первом месте,
//  а первый - на последнем и т.д.)

// void ReverseArray(int[] array)
// {
//     for (int left = 0, right = array.Length - 1; left < right; left++, right--)
//     {
//         int temp = array[left];
//         array[left] = array[right];
//         array[right] = temp;
//     }
// }

// int[] myArray = {1,2,3,4,5};
// ReverseArray(myArray);
// for (int i = 0; i < myArray.Length; i++)
// {
//     System.Console.Write(myArray[i]+ " ");
// }

// Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.
/*bool CheckTriangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && c + a > b) return true;
    else return false;
}
System.Console.WriteLine("Input three numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine(CheckTriangle(a, b, c));*/

// Не используя рекурсию, выведите первые N чисел 
//Фибоначчи.Первые два числа Фибоначчи: 0 и 1.

/*void ShowFibonacciRow(int endRow, int firstNum, int secondNum)
{
    int nextNum = firstNum + secondNum;
    int count = 2;
    Console.Write(firstNum + " ");
    Console.Write(secondNum + " ");
    while (count < endRow)
    {
        firstNum = secondNum;
        secondNum = nextNum;
        nextNum = firstNum + secondNum;
        Console.Write(nextNum + " ");
        count++;
    }

}
ShowFibonacciRow(10, 0, 1);*/

// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.
int[] MakeNewArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i]+1;
    }
    return newArray;
}
int[] CreateRandomArray(int size,int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(minValue,maxValue +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}
Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size,min,max);
PrintArray(array);
int[] newArray = MakeNewArray(array);
PrintArray(newArray);
PrintArray(array);





