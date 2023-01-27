// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


/************************* М Е Т О Д Ы *************************/

// Метод выводит в консоль текст на запрос ввода последовательности М чисел от пользователя
// Отделяет числа и сохраняет в массив строк
// Возвращает строковый массив
string[] EnterNumbersSequence()
{
    Console.Write("Введите последовательность чисел через запятую: ");
    string str = Console.ReadLine();

    // Метод Split разбивает текст на слова, используя разделитель. 
    // string[] strArr = str.Split(); // если в скобках ничего не указываем, Split() делит числа по пробелу
    string[] strArr = str.Split(","); // если в скобках "," - разделитель запятая
    return strArr;
}


// Вывод строкового массива на печать в строку в формате [a1,a2,a3,a4,a5]
void PrintArrayStr(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + ",");
        else
            Console.Write(array[i]);
    }
    Console.WriteLine("]");
}


// Вывод числового массива на печать в строку в формате [a1,a2,a3,a4,a5]
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + ",");
        else
            Console.Write(array[i]);
    }
    Console.WriteLine("]");
}


// Метод преобразует строковый массив в числовой
int[] ConvertArrayStrToInt(string[] arrStr)
{
    int[] arrNums = new int[arrStr.Length];
    for (int i = 0; i < arrNums.Length; i++)
    {
        arrNums[i] = Convert.ToInt32(arrStr[i]);
    }
    return arrNums;
}


// Метод вычисляет количество положительных чисел в массиве
int CountNumbersAmount(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) amount++;
    }
    return amount;
}

/***************************************************************/

string[] strArray = EnterNumbersSequence();
Console.Write("Массив строк -> ");
PrintArrayStr(strArray);

int[] numArray = ConvertArrayStrToInt(strArray);
Console.Write("Массив чисел -> ");
PrintArray(numArray);

int amnt = CountNumbersAmount(numArray);
Console.WriteLine($"Количество чисел в массиве больше 0 = {amnt}");

