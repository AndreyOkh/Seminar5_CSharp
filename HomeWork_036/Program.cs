// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int sizeArray = 10;
int[] numbers = new int[sizeArray];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sum = 0;
int i = 0;
while (i < numbers.Length)
{
    sum += numbers[i];
    i += 2;
}

Console.WriteLine($"Сумма чисел стоящих на нечетных позициях равна {sum}.");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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