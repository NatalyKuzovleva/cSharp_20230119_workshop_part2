// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Чтобы десятичная точка была вместо десятичной запятой
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

/************************* М Е Т О Д Ы *************************/

// Создание двумерного массива, заполненного псевдослучайными вещественными числами
double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];   // создаём двумерный массив
    Random rnd = new Random();                      // создаём экземпляр класса Рандом

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - нулевое измерение это строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) - первое измерение это столбцы
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 2, MidpointRounding.AwayFromZero);
            // Округляем до 2 знаков после запятой
            // MidpointRounding.ToZero - Стратегия направленного округления к нулю
            /* MidpointRounding.AwayFromZero - Стратегия округления до ближайшего числа, и когда число находится 
            на полпути между двумя другими, оно округляется в сторону ближайшего числа, которое от нуля.*/
        }
    }
     return matrix;
}


// Вывод двумерного числового массива на печать в консоль
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6}");
            else Console.Write($"{matrix[i, j],6}  ");
        }
        Console.WriteLine("|");
    }
}


/***************************************************************/
Console.Clear();
double[,] array2D = CreateMatrixRndDouble(3, 4, -10, 10);
PrintMatrix(array2D);


