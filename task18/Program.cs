// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double getDistanseCoordinate(int userAx, int userAy, int userBx, int userBy)
{
    double result = Math.Sqrt(Math.Pow(((byte)(userAx - userBx)), 2) + Math.Pow(((byte)(userAy - userBy)), 2));
    return result;
}
int userAx = getUserValue("Введите x");
int userAy = getUserValue("Введите y");

int userBx = getUserValue("Введите x");
int userBy = getUserValue("Введите y");

double distance = getDistanseCoordinate(userAx, userAy, userBx,userBy);
Console.WriteLine($"Расстояние между точками {distance}");