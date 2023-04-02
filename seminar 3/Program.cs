/*// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).


// void ShowRange (int quadrant)
// {
//     if (quadrant == 1) Console.WriteLine("x > 0, y > 0");
//         else if (quadrant == 2) Console.WriteLine("x < 0, y > 0");
//         else if (quadrant == 3) Console.WriteLine("x < 0, y < 0");
//         else if (quadrant == 4) Console.WriteLine("x > 0, y < 0");
//         else Console.WriteLine("There no that quadrant on the coordinate area..");
// }
// Console.WriteLine("Input a number of quadrant: ");
// int numQuar = Convert.ToInt32(Console.ReadLine());

// ShowRange(numQuar);*/


/*//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void QuadrantNum(double x, double y)
// {
//     if (x>0 && y>0) Console.WriteLine(1);
//     else if (x<0 && y>0) Console.WriteLine(2);
//     else if (x<0 && y<0) Console.WriteLine(3);
//     else if (x>0 && y<0) Console.WriteLine(4);
//     else Console.WriteLine("-1");
// }
// Console.WriteLine("Input x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// QuadrantNum(x,y);*/


/*// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// double findLength(double ax, double ay, double bx, double by)
// {
//     double length = Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2));
//     return length;
// }

// Console.WriteLine("Input A(x): ");
// double ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input A(y): ");
// double ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B(x): ");
// double bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B(y): ");
// double by = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(findLength(ax,ay,bx,by));*/




/*// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов
//  чисел от 1 до N.

void ShowTableQuad(int n)
{
    int currQuad = 1;
    while (currQuad <= n)
    {
       Console.WriteLine($"{currQuad} --- {Math.Pow(currQuad,2)}");
       currQuad++;
    }
}
Console.WriteLine("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowTableQuad(n);*/

/*// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool palindromCheck(int checkNumber)
{
    int n = checkNumber;
    int resultNumber = 0;
    while (n != 0)
    {
       int lastDigit = n % 10 ;
       resultNumber = resultNumber * 10 + lastDigit;
       n = n /10;
    }
    if (resultNumber == checkNumber) return true;
    else return false;
}
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(palindromCheck(number));*/


/*// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double findLength(double ax, double ay,double az, double bx, double by,double bz)
{
    double length = Math.Round(Math.Sqrt(Math.Pow((bx - ax),2) + 
                                        Math.Pow((by - ay),2) + 
                                        Math.Pow((bz - az),2)), 2);
    return length;
}

Console.WriteLine("Input A(x): ");
double ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input A(y): ");
double ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input A(z): ");
double az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B(x): ");
double bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B(y): ");
double by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B(z): ");
double bz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(findLength(ax,ay,az,bx,by,bz));*/

/*// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ShowTableCube(int n)
{
    int currNum = 1;
    while (currNum <= n)
    {
       Console.WriteLine($"{currNum} --- {Math.Pow(currNum,3)}");
       currNum++;
    }
}
Console.WriteLine("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowTableCube(n);*/