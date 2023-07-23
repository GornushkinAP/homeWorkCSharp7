// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
try
{
    Console.WriteLine("Здравствуйте! Введите размерность двумерного массива:");
    Console.Write("Количество строк: ");
    int rows = GetValidNumberFromUser();
    Console.Write("Количество столбцов: ");
    int cols = GetValidNumberFromUser();

    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(0, 1000);
        }
    }

    Console.WriteLine("Введите координаты элемента для поиска:");
    Console.Write("Индекс строки: ");
    int rowIndex = GetValidNumberFromUser();
    Console.Write("Индекс столбца: ");
    int columnIndex = GetValidNumberFromUser();

    if (IsValidIndex(rowIndex, rows) && IsValidIndex(columnIndex, cols))
    {
        int element = array[rowIndex, columnIndex];
        Console.WriteLine($"Значение элемента [{rowIndex}, {columnIndex}]: {element} Досвидания.");
    }
    else
    {
        Console.WriteLine("Некорректные координаты элемента.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: Некорректный ввод числа.");
}


static int GetValidNumberFromUser()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Ошибка: Некорректный ввод. Пожалуйста, введите число: ");
    }
    return number;
}

static bool IsValidIndex(int index, int length)
{
    return index >= 0 && index < length;
}
