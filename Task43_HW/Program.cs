// Задача 43. Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


/************************* М Е Т О Д Ы *************************/

// Метод выводит в консоль текст на запрос ввода числа от пользователя
int EnterNumberRequest(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


// Метод проверяет, параллельны ли две прямые
// Прямые параллельны, если угловые коэффициенты уравнений равны, т.е. если k1 = k2
bool IsLinesParallel(double kk1, double kk2)
{
    return kk1 == kk2;
}


// Метод ищет координаты точки пересечения двух прямых
double[] FindCrossPoint(double kk1, double kb1, double kk2, double kb2)
{
    double coorX = (kb2 - kb1) / (kk1 - kk2);
    double coorY = 0;
    if (kk1 == 0)
    {
        coorY = kk2 * coorX + kb2;
    }
    else
    {
        coorY = kk1 * coorX + kb1;
    }
    double[] coordArray = new double[2];
    coordArray[0] = Math.Round(coorX, 2);
    coordArray[1] = Math.Round(coorY, 2);

    return coordArray;
}


// Вывод массива на печать в строку в формате [a1,a2,a3,a4,a5]
void PrintArrayDouble(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + "; ");
        else
            Console.Write(array[i]);
    }
    Console.WriteLine(")");
}


/***************************************************************/
Console.WriteLine("Найдём точку пересечения двух прямых y=k1*x+b1 и y=k2*x+b2");
double k1 = EnterNumberRequest("Введите значение коэффициента k1: ");
double b1 = EnterNumberRequest("Введите значение коэффициента b1: ");
double k2 = EnterNumberRequest("Введите значение коэффициента k2: ");
double b2 = EnterNumberRequest("Введите значение коэффициента b2: ");

Console.WriteLine(IsLinesParallel(k1, k2)
    ? "Прямые параллельны. Точек пересечения нет!"
    : "Прямые пересекаются!");

if (IsLinesParallel(k1, k2) == false)
{
    double[] crossPoint = FindCrossPoint(k1, b1, k2, b2);
    // Console.Write("Координата точки пересечения: ");
    // PrintArrayDouble(crossPoint);

    Console.Write($"Координата точки пересечения прямых y={k1}*x+{b1} и y={k2}*x+{b2} -> ");
    PrintArrayDouble(crossPoint);
}
