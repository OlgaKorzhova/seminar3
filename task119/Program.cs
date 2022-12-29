// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int palindrom = 0, num = number;
while (number > 0) 
{
    palindrom = palindrom * 10 + number % 10; number /= 10;
}
    Console.WriteLine(num == palindrom ? "Палиндром" : "Не палиндром");