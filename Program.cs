/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4

Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
(пользователь вводит в консоли числа через пробел и они формируют строку) */

/*Console.WriteLine("Введите числа (через пробел): ");
int [] numS = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int count = 0;

for (int i = 0; i < numS.Length; i++)
{
    if (numS[i] > 0) 
    {
        count++;
    }

}
Console.WriteLine($"[{String.Join(",", numS)}] -> Количество чисел больше нуля: {count}");*/


// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
//а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

Console.WriteLine("Введите числа (через пробел): ");
int[] numS = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int size = numS.Length;
bool included = true;

for (int k = 0; k < size; k++)
{
    if (numS[k] < 0 || numS[k] > 100)
    {
        included = false;
        break;
    }
}

if (included)
{
    if (size < 6)
    {
        Console.WriteLine("Введите более 6 элементов массива: ");
    }
    else
    {
        Console.WriteLine($"[{String.Join(",", numS)}]");

        int[] array = SortArray(numS);

        Console.WriteLine($"[{String.Join(",", array)}]");
    }
}
else Console.WriteLine("Введите диапазон от 0 до 100: ");


//-----Метод----
int[] SortArray(int[] numS)
{
    int temp = 0;
    for (int j = numS.Length - 1; j > 0; j--)
    {
        for (int i = 0; i < j; i++)
        {
            if (numS[i] > numS[i + 1])
            {
                temp = numS[i + 1];
                numS[i + 1] = numS[i];
                numS[i] = temp;
            }
        }
    }
    return numS;
}


//Console.WriteLine($"[{String.Join(",", numS)}] -> Отсортированный массив: {Array.Sort(numS)}");


