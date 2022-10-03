// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = GetArray(5, 4, 777);
Console.Write(String.Join(" ", array));
Console.WriteLine($"Разница между максимальным и минимальным равна {GetDifference(array)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetDifference(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($" Максимальный элемент = {max}, минимальный элемент = {min}");
    return max - min;
}