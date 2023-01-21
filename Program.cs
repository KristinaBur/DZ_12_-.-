/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4

Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
(пользователь вводит в консоли числа через пробел и они формируют строку) */

Console.WriteLine("Введите числа (через пробел): ");
int [] numS = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

//string stringArray = Console.ReadLine()!;
//string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int count = 0;

for (int i = 0; i < numS.Length; i++)
{
    if (numS[i] > 0) 
    {
        count++;
    }

}
Console.WriteLine($"[{String.Join(",", numS)}] -> Количество чисел больше нуля: {count}");