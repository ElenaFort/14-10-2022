/*Задача 38: Задайте массив вещественных чисел. Найдите разницу
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] RandomArray()
{
    double[] array = new double[4];
    Random rnd = new Random();

    for (int i = 0; i < 4; i++)
        array[i] = rnd.NextDouble();

    return array;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double GetDifference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < 4; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    return (max - min);
}

double[] arr = RandomArray();
PrintArray(arr);
double difference = GetDifference(arr);
Console.WriteLine(
    $"Разница между максимальным и минимальным элементами массива равна: {difference}"
);
