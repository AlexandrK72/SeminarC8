// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,4}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] PullMatrix(int[,] matrix)
{
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 15);
        }
    }
    return matrix;
}

int[] MatrixToArray(int[,] matrix)
{
    int k = 0;
    int[] array = new int[matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

// 1 1 5 5 6 6 9 9
void PrintFrequencyDictionary(int[] array)
{
    int count = 1;
    int currentNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNum)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{currentNum} -> {count}");
            currentNum = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{currentNum} -> {count}");
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0,4}", array[i]);
    }
}

int[,] matrix = new int[4, 4];
PullMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int[] arr = MatrixToArray(matrix);
Array.Sort(arr);
PrintArray(arr);
Console.WriteLine();
PrintFrequencyDictionary(arr);