// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел Вы хотите ввести? Укажите цифру:");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] ArrayNumber(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write("Введите любое натуральное число ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int PositiveArrayQuantity(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}


int[] array = ArrayNumber(arrayLength);
PrintArray(array);
Console.Write($"Количество введенных положительных чисел = {PositiveArrayQuantity(array)}");
Console.WriteLine();