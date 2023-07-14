// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool CheckPal(int numberw)
{
    int originalN = numberw;
    int reverseN = 0;

    while (numberw > 0)
    {
        int digit = numberw % 10;
        reverseN = reverseN * 10 + digit;
        numberw /= 10;
    }
    return originalN == reverseN;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите проверяемое число N: ");
int numberw = Math.Abs(number);

bool isPal = CheckPal(numberw);

if (isPal) Console.WriteLine($"Введенное число {number} является палиндромом!");
else Console.WriteLine($"Введенное число {number} НЕ является палиндромом!");