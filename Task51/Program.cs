// Задача 51. Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


/************************* М Е Т О Д Ы *************************/

// Создание двумерного массива, заполненного псевдослучайными целыми числами
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];     // создаём двумерный массив
    Random rnd = new Random();                  // создаём экземпляр класса Рандом

    for (int i = 0; i < matrix.GetLength(0); i++)       // matrix.GetLength(0) - нулевое измерение это строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // matrix.GetLength(1) - первое измерение это столбцы
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


// Вывод двумерного числового массива на печать в консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},"); // в интерполяцию добавили форматирование
            // без разделительной запятой между элементами if-else не нужен! 
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("|");
    }
}


// Метод находит сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
int GetSumMainDiagonalElements(int[,] matrix)
{
    int sum = 0;
    int size = matrix.GetLength(0) < matrix.GetLength(1)
        ? matrix.GetLength(0)
        : matrix.GetLength(1);
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}


// Вариант 2. Метод находит сумму элементов, находящихся на главной диагонали
// int GetSumMainDiagonalElements(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j) sum += matrix[i, j];
//         }
//     }
//     return sum;
// }

/***************************************************************/
Console.Clear();
int[,] array2D = CreateMatrixRndInt(4, 3, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();

int sumDiagonalElements = GetSumMainDiagonalElements(array2D);
Console.WriteLine($"Сумма элементов главной диагонали: {sumDiagonalElements}");