// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для 
// пользователя


int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;

}

int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // rows = 3, coiums = 4
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void ReplaceRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;

        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // .GetLength(0) - функционал для определения количества строк 0 - 3 стороки

    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++) // .GetLength(0) - функционал для определения количества столбцов 0 - 4 столбца
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("  ]");
    }
}


int rows = Prompt("Введите количество строк ");
int columns = Prompt("Введите количество столбцов ");
int min = Prompt("Введите минимальное значение в случайном массиве ");
int max = Prompt("Введите максимальное значение в случайном массиве ");
// if (rows != columns)
// {
//      Console.WriteLine("Ошибка. Количество строк должно быть равно количеству столбцов");
//      return;
// }


int[,] matr = CreatMatrixRndInt(rows, columns, min, max);

PrintMatrix(matr);
Console.WriteLine();
if (rows != columns)
{
     Console.WriteLine("Ошибка. Невозможно заменить строки на столбцы");
     return;
}

ReplaceRowsColumns(matr);
PrintMatrix(matr);