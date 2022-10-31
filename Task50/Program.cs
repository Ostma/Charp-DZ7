// Задача 50. Напишите программу, которая на вход принимает размерность и возвращает позицию (i, j) этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
return number;
}


int [,] InitMatrix (int m, int n)
{
    int[,] matrix = new int [m,n];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 50);
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] matrix, int find)
{
    bool temp = false; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == find)
            {
                Console.WriteLine($"Число {find} находится в {i+1} ряду на {j+1} позиции");
                temp = true;
            }
        }
    }
    if (temp = true) Console.WriteLine($"{find} --> Такого числа в массиве нет");
}


int m = GetNumber("Введите размерность m ");
int n = GetNumber("Введите размерность n ");
int p = GetNumber("Что ищем? ");

int[,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);
FindNumber(matrix, p);
