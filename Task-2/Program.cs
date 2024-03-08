// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Main()
{
    int m = InputDigit("Введите перове число: ");
    int n = InputDigit("Введите второе число: ");
    System.Console.WriteLine($"Рузультат: {funcionAkkerman(m, n)}");

}

int funcionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return funcionAkkerman(m - 1, 1);
    else return funcionAkkerman(m - 1, funcionAkkerman(m, n - 1));
}
int InputDigit(string textPrint)
{
    System.Console.Write(textPrint);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();