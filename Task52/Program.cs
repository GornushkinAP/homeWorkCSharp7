// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Задаем двумерный массив из целых чисел

Console.WriteLine("И снова Здравствуйте!");
Console.Write("Введите количество строк: ");
int rows;
while (!int.TryParse(Console.ReadLine(), out rows))
{
    Console.WriteLine("Ошибка ввода. Введите корректное количество строк: ");
}

Console.Write("Введите количество столбцов: ");
int columns;
while (!int.TryParse(Console.ReadLine(), out columns))
{
    Console.WriteLine("Ошибка ввода. Введите корректное количество столбцов: ");
}

int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(0, 100);
    }
}

int[] columnSums = new int[columns];

for (int col = 0; col < columns; col++)
{
    for (int row = 0; row < rows; row++)
    {
        columnSums[col] += array[row, col];
    }
}

double[] columnAverages = new double[columns];

for (int col = 0; col < columns; col++)
{
    columnAverages[col] = (double)columnSums[col] / rows;
}

Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
for (int col = 0; col < columns; col++)
{
    Console.WriteLine($"Столбец {col + 1}: {columnAverages[col]}");
}
Console.WriteLine("Досвидания.");