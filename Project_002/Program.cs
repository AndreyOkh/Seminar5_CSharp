// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] numbers = new int[10];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Convert(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

void Convert(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}