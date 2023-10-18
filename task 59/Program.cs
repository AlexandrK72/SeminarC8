// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на 
// пересечении которых расположен наименьший элемент 
// массива.


int[,] CreatMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums]; // rows = 3, coiums = 4
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
int[] GetIndexessMinElem(int[,] matrix)
{

    int rowMin = 0;
    int columnMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rowMin, columnMin])
            {
                rowMin = i;
                columnMin = j;
            }
        }
    }
    return new int[] { rowMin, columnMin };
}
int[,] DeleteRowColumMinElem(int[,] matrix, int delRow, int delColumn)
{
    int[,] newmatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0, m = 0; i < newmatrix.GetLength(0); i++, m++)
    {
        if (i == delRow) m++;
        for (int j = 0, n = 0; j < newmatrix.GetLength(1); j++, n++)

        {
            if (j == delColumn) n++;
            newmatrix[i, j] = matrix[m, n];
        }
    }
    return newmatrix;
}
int[,] matr = CreatMatrixRndInt(5, 5, 1, 10);
PrintMatrix(matr);

int[] indMinelem = GetIndexessMinElem(matr);
int[,] deleteRowColumMinElem = DeleteRowColumMinElem(matr, indMinelem[0], indMinelem[1]);
Console.WriteLine();
PrintMatrix(deleteRowColumMinElem);