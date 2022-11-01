// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}    ");
        }
        Console.WriteLine();
    }
}

void CalcAverageColumn(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = 0;
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp = temp + matrix[i, j];
        }
        average = Math.Round((Convert.ToDouble(temp) / matrix.GetLength(0)), 1);
        Console.Write($"{average}  ");
    }
}


int n = GetNumber("Введите ширину массива n ");
int m = GetNumber("Введите высоту массива m ");

int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
CalcAverageColumn(matrix);