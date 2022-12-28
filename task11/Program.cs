// напишите программу, которая выводит случайное трехзначное число и удаляет его вторую цифру

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}
int DeleteSecondDigit(int number)
{
    int digit3 = number % 10;
    int digit1 = number / 100;
    int result = digit1 * 10 + digit3;
    return result;
}
int randomNumber = GetNumberFromRange(100,999);
int numberWithSecond = DeleteSecondDigit(randomNumber);
Console.WriteLine($"Число {randomNumber} без второй цифры {numberWithSecond}");

