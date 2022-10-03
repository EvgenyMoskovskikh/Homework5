// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных 
// [345, 897, 568, 234] -> 2

(int[], int) array = Array(5);
(int[], int count) Array(int size)
{
    int[] result = new int[size];
    var count = 0;
    Console.Write("Массив [ ");
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
        if (result[i] % 2 == 0)
        {
            count++;
        }
                Console.Write(result[i] + " ");
        
    }
    Console.Write("] - ");
    Console.WriteLine($" Количество четных элементов в массиве равно {count}");
    return (result, count);    
}