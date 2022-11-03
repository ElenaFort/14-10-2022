/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] RandomArray()
{
    int[] array = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < 10; i++)
        array[i] = rnd.Next(1, 100);
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int HonestyPosition(int[] array)
{
    int summ = 0;
    for (int i = 0; i < 10; i++)
    {
        if (i % 2 == 0)
            summ = summ + array[i];
    }
    return summ;
}
int[] arr = RandomArray();
PrintArray(arr);
int summa = HonestyPosition(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {summa}");
