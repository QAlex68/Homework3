// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void NumberOutput (int n)
{
Console.WriteLine($"Кубы чисел в промежутке от 1 до {n}:", n);

for (int i = 1; i < n; i++)
{
    Console.Write(Math.Pow(i, 3)+", ");
}
Console.Write(Math.Pow(n, 3));
}

int n = Math.Abs(GetInput("Введите число N: "));

NumberOutput(n);