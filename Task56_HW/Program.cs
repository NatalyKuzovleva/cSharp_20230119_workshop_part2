// Задача 56. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine("|");
    }
}


// Метод вычисляет сумму элементов в каждой строке и выдаёт одномерный массив, заполненный этими суммами 
int[] CountSumForEachRow(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumArray[i] += matrix[i, j];
        }
    }
    return sumArray;
}


// Метод выводит на печать одномернный массив
void PrintArray(int[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine(")");
}


// Метод принимает на вход одномерный массив и находит наименьшее число среди значений элементов
int FindLessNumber(int[] array)
{
    int min = array[0];
    int numberRow = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            numberRow = i;
        }
    }
    return numberRow;
}

/***************************************************************/
Console.Clear();
int[,] array2D = CreateMatrixRndInt(5, 6, 0, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] sumArr = CountSumForEachRow(array2D);
PrintArray(sumArr);
Console.WriteLine($"Строка с наименьшей суммой элементов: {FindLessNumber(sumArr)+1} строка");
