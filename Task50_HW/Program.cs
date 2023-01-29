// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


/************************* М Е Т О Д Ы *************************/

// Создание двумерного массива, заполненного псевдослучайными числами
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


// Вывод двумерного числового массива в консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}  ");
        }
        Console.WriteLine("|");
    }
}


// Запрос ввода позиции элемента в двумерном массиве от пользователя
int[] EnterIndexElement(string text)
{
    Console.WriteLine(text);
    int i = Convert.ToInt32(Console.ReadLine());
    int j = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[]{i,j};
    return array;
}


// Вывод массива на печать в строку в формате (a1,a2)
void PrintArray(int[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + ",");
        else
            Console.Write(array[i]);
    }
    Console.Write(")");
}


// Проверка, что такая позиция в двумерном массиве есть
bool CheckCorrectPosition(int[,] matrix, int[] array)
{
    return (matrix.GetLength(0) > array[0] && matrix.GetLength(1) > array[1]) && array[0] >= 0 && array[1] >= 0;
}


// Метод получает по заданной позиции элемента значение в двумерном массиве
int GetValueFromMatrix(int[,] matrix, int[] array)
{
    int value = matrix[array[0], array[1]];
    return value;
}


/***************************************************************/
Console.Clear();
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);

int[] arrElem = EnterIndexElement("Введите позицию элемента в двумерном массиве (i и j через Enter): ");

if (!CheckCorrectPosition(array2D, arrElem))
{
    PrintArray(arrElem);
    Console.Write(" -> такого элемента в массиве нет");
}
else
{
    int elementValue = GetValueFromMatrix(array2D, arrElem);
    Console.Write("Значение элемента на позиции ");
    PrintArray(arrElem);
    Console.Write($" -> {elementValue}");
}
