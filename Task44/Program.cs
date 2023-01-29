// Задача 44. Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


/************************* М Е Т О Д Ы *************************/

// Метод выводит в консоль текст на запрос ввода числа от пользователя
int EnterNumberRequest(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


// Вывод числового массива на печать в строку в формате [a1 a2 a3 a4 a5]
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + " ");
        else
            Console.Write(array[i]);
    }
}

int[] FibonachiArray(int num)
{
    int[] array = new int[num];
    // array[0] = 0; // новый массив заполнен нулями по умолчанию, нет необходимости присваивать ещё раз 0
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

/***************************************************************/

int numN = EnterNumberRequest("Какое количество первых чисел Фибоначчи вывести на экран? Введите число: ");
int[] FibArray = FibonachiArray(numN);
Console.Write($"Если N = {numN} -> ");
PrintArray(FibArray);
