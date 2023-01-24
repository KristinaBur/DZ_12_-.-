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

//Вариант 1:
/*Console.WriteLine("Введите числа (через пробел): ");
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
}  */

//Вариант 2 (для себя):
Console.WriteLine("Введите числа через запятую и нажмите Enter");
string[] nums = Console.ReadLine()!.Split(new char[] { ',' });
int[] intArray = new int[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
    intArray[i] = int.Parse(nums[i]);
}

int indx; //переменная для хранения индекса минимального элемента массива
for (int i = 0; i < intArray.Length; i++) //проходим по массиву с начала и до конца
{
    indx = i; //считаем, что минимальный элемент имеет текущий индекс 
    for (int j = i; j < intArray.Length; j++) //ищем минимальный элемент в неотсортированной части
    {
        if (intArray[j] < intArray[indx])
        {
            indx = j; //нашли в массиве число меньше, чем intArray[indx] - запоминаем его индекс в массиве
        }
    }
    if (intArray[indx] == intArray[i]) //если минимальный элемент равен текущему значению - ничего не меняем
        continue;
    //меняем местами минимальный элемент и первый в неотсортированной части
    int temp = intArray[i]; //временная переменная, чтобы не потерять значение intArray[i]
    intArray[i] = intArray[indx];
    intArray[indx] = temp;
}
Console.WriteLine("\r\nОтсортированный массив:");
foreach (int value in intArray)
{
    Console.Write($"{value} ");
}






