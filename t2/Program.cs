// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма нечетных элементов = {SumOddElements(array)} ");

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        if (array[i]%2==0)
        {
            sum += array[i];
        }
    }
    return sum;
}