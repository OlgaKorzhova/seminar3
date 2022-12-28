// Программа получает на вход координаты точки (x и y), причем х и у не равны 0,
// и выдает номер четверти плоскости, в которой находится эта точка

int value = (int)Math.Sqrt(128);
double value2 = Math.Sqrt(128);
Console.WriteLine(value);
Console.WriteLine(value2);

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int getQuarterNumber(int x, int y)
{
    int quarter = 0;
    if (x > 0 && y > 0)
    {
        quarter = 1;
    }
    else if (x < 0 && y > 0)
    {
        quarter = 2;
    }
    else if (x < 0 && y < 0)
    {
        quarter = 3;
    }
    else if (x > 0 && y < 0)
    {
        quarter = 4;
    }
    return quarter;
}

int userX = getUserValue("Введите X");
int userY = getUserValue("Введите Y");
int quarter = getQuarterNumber(userX, userY);
if (quarter > 0)
{
    Console.WriteLine($"Точка [{userX}, {userY}] находятся в {quarter} четверти ");
}
else
{
    Console.WriteLine($"Точка [{userX}, {userY}] находятся на оси координат");
}
