// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double getDistanseCoordinate(int userAx, int userAy, int userAz, int userBx, int userBy, int userBz)
{
    double result = Math.Sqrt(Math.Pow(((byte)(userAx - userBx)), 2) + Math.Pow(((byte)(userAy - userBy)), 2) + Math.Pow(((byte)(userAz - userBz)), 2));
    return result;
}
int userAx = getUserValue("Введите x");
int userAy = getUserValue("Введите y");
int userAz = getUserValue("Введите z");

int userBx = getUserValue("Введите x");
int userBy = getUserValue("Введите y");
int userBz = getUserValue("Введите z");

double distance = getDistanseCoordinate(userAx, userAy, userAz, userBx, userBy, userBz);
Console.WriteLine($"Расстояние между точками {distance}");
