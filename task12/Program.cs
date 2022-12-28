// Программа принимает на вход 2 числа и проверяет, является ли оно кратным и выводит остаток

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("Число кратно");
}
else 
{
    int ostatok = num1 % num2;
    Console.WriteLine($"Число не кратно, остаток {ostatok}");
}