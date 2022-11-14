/*
Task 1
void Method1();
{
    Console.WriteLine("author ...");
}
Method1();
*/

/*
Task 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "message text");
*/

/* хуета 
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Text, 4");
*/

/*
String Method4(int count, string text)
{
    string result = String.Empty;
    for( int i = 0;i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);  
*/

/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

/*
int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

int PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

PrintArray(arr);
*/


//Pavel seminar 3

/*
void ShowRange(int quart)
{
    if(quart == 1)
        Console.WriteLine("x > 0 and y > 0");
    else if(quart == 2)
        Console.WriteLine("x > 0 and y > 0");
    else if(quart == 3)
        Console.WriteLine("x > 0 and y > 0");
    else if(quart == 4)
        Console.WriteLine("x > 0 and y > 0");
    else
        Console.WriteLine("Wrong number!");
}

Console.Write("Input a number of quart: ");
int quartNum = Convert.ToInt32(Console.ReadLine());

ShowRange(quartNum);
*/

/*
int ShowQuart(int numX, int numY)
{
    int quart = 0;
    if(numX > 0 && numY > 0)
        quart = 1;
    else if(numX < 0 && numY < 0)
        quart = 2;
    else if(numX < 0 && numY < 0)
        quart = 3;
    else if(numX > 0 && numY < 0)
        quart = 4;
    return quart;

}
Console.Write("Input x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y ");
int y = Convert.ToInt32(Console.ReadLine());
int result = ShowQuart(x, y);
if(result == 0)
{
    Console.Write("Wrong number");
}
else
{
    Console.WriteLine($"Number of quart {result}" );
}
*/

/*
double Theorem(double numX1, double numY1, double numX2, double numY2)
{
    double RollsFirst = numX1 - numX2;
    RollsFirst = Math.Pow(RollsFirst, 2);
    double RollsSecond = numY1 - numY2;
    RollsSecond = Math.Pow(RollsSecond, 2);
    double Hypotenus = RollsFirst + RollsSecond;
    Hypotenus = Math.Sqrt(Hypotenus);
    return Hypotenus;
}
*/

/*
void Square(int n)
{
    int index = 1;
    while(index <= n)
    {
        Console.Write(index*index + " ");
        index++;
    }
}
Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());
Square(n);
*/