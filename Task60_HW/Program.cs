// *Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.

// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


/**********************  МЕТОДЫ  **********************/

// Метод на запрос ввода числа от пользователя
int EnterNumberRequest(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


// Создание трёхмерного массива, заполненного случайными числами
// int[,,] CreateCubeRndInt(int rows, int columns, int depth, int min, int max)
// {
//     int[,,] cube = new int[rows, columns, depth];     // создаём трёхмерный массив
//     Random rnd = new Random();          	            // создаём экземпляр класса Рандом

//     for (int i = 0; i < cube.GetLength(0); i++)
//     {
//         for (int j = 0; j < cube.GetLength(1); j++)
//         {
//             for (int k = 0; k < cube.GetLength(2); k++)
//             {
//                 cube[i, j, k] = rnd.Next(min, max + 1);
//             }
//         }
//     }
//     return cube;
// }


// Создание трёхмерного массива, заполненного неповторяющимися двузначными числами
int[,,] CreateCubeInt(int rows, int columns, int depth)
{
    int[,,] cube = new int[rows, columns, depth];     // создаём трёхмерный массив
    int num = 10;
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                cube[i, j, k] = num++;
            }
        }
    }
    return cube;
}


// Вывод трёхмерного массива в консоль построчно

void PrintArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}

/*********************************************************************************/
Console.Clear();
int rowsCube = EnterNumberRequest("Введите количество строк в трёхмерном массиве: ");
int columnsCube = EnterNumberRequest("Введите количество столбцов в трёхмерном массиве: ");
int depthCube = EnterNumberRequest("Введите глубину трёхмерного массива: ");

if (rowsCube <= 0 || columnsCube <= 0 || depthCube <= 0)
{
    Console.WriteLine("Неправильно введены параметры! Невозможно создать трёхмерный массив!");
}
else if (rowsCube * columnsCube * depthCube > 99)
{
    Console.WriteLine("Количество ячеек трёхмерного массива превышает количество неповторяющихся двузначных чисел!");
}
else
{ //int[,,] arr3D = CreateArray3DRndInt(4, 3, 3, 10, 99);
    int[,,] arr3D = CreateCubeInt(rowsCube, columnsCube, depthCube);
    PrintArray3D(arr3D);
}
