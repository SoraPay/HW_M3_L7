// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int m = InputDigit("Введите минимальное число: ");
    int n = InputDigit("Введите максимальное число: ");
    PrintAllNaturalDigit(m, n);
}

void PrintAllNaturalDigit(int m, int n)
{
    if (m <= n)
    {
        System.Console.Write(m + " ");
        PrintAllNaturalDigit(m + 1, n);
    }
}

int InputDigit(string textPrint)
{
    System.Console.Write(textPrint);
    return Convert.ToInt32(Console.ReadLine());
}

Main();