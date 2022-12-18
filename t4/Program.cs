
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[N];
FillArray(array1);
PrintArray(array1);
Console.WriteLine($"Разница между максимальным и минимальным значением массива = {DifMaxMin(array1)}");



int DifMaxMin(int[] array)
{
    int dif = 0, max = array[0], min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    dif = max - min;
    return dif;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}
void PrintArray(int[] array)
{

    Console.Write("[");
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}