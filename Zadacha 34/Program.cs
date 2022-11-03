/*Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] InitArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(100, 999);
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int GetTheNumberOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count = count + 1;
    }
    return count;
}
int length = GetNumber("Введите размер массива");
int[] arr = InitArray(length);
PrintArray(arr);
int quantity = GetTheNumberOfEvenNumbers(arr);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
