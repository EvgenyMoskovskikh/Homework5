// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int size = 5;
int[] array = new int[size];
int result = 0;
void Shaurma(int[] array)
{
for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 1)
    {
        result = result + array[i];
    }
}
void SuperMegaMassif(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    int leng = array.Length;
    for (int i = 0; i < leng; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    }
    Console.WriteLine("]");
}
SuperMegaMassif(array);
PrintArray(array);
Shaurma(array);
Console.Write($"Сумма нечетных элементов: {result}");
