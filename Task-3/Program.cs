// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Main()
{
    int digit = InputDigit("Введите длину массива: ");
    int digitMin = InputDigit("Введите мнимальное значение в массиве: ");
    int digitMax = InputDigit("Введите максимальное значение в массиве: ");
    int[] array = GenerateArray(digit, digitMin, digitMax);
    System.Console.WriteLine("Массив: " + string.Join(" ", array));
    PrintArray(digit - 1, array);
}

void PrintArray(int length, int[] array)
{
    if (length < 0) return;
    System.Console.Write(array[length] + " ");
    PrintArray(length - 1, array);
}

int[] GenerateArray(int length, int minDigit, int maxDigit)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(minDigit, maxDigit + 1);

    return array;
}
int InputDigit(string textPrint)
{
    System.Console.Write(textPrint);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();