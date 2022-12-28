// Программа принимает на вход 2 числа и проверяет,
// является ли одно число квадратом другого

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == num1 * num1 || num1 == num2 * num2)
{
    Console.WriteLine("Является квадратом");
}
else 
{
    Console.WriteLine("Не является квадратом");
}