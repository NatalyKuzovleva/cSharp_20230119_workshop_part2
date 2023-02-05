// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


/************************* М Е Т О Д Ы *************************/

// Метод выводит в консоль текст на запрос ввода числа от пользователя
int EnterNumberRequest(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// Метод вычисляет функцию Аккермана с помощью рекурсии
int CalculateAckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0)
    {
        return CalculateAckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
    }
    else return n + 1;
}


/***************************************************************/
Console.Clear();
int numM = EnterNumberRequest("Введите первое неотрицательное число m: ");
int numN = EnterNumberRequest("Введите второе неотрицательное число n: ");

if (numM < 0 || numN < 0) Console.WriteLine("Введены некорректные данные!");
else
{
    int ackFunc = CalculateAckermannFunction(numM, numN);
    Console.Write($"m = {numM}, n = {numN} -> A(m,n) = {ackFunc}");
}
