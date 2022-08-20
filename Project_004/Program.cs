// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int size = 123;
int[] numbers = new int[size];
int minNumber = 10;
int maxNumber = 99;

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int countOverlap = 0;

foreach (int i in numbers)
{
    if (i >= minNumber && i <= maxNumber)
    {
        countOverlap++;
    }
}

Console.WriteLine($"Количество чисел в диапазоне от {minNumber} до {maxNumber} = {countOverlap}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 124);
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