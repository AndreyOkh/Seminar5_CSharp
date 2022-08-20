// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int sizeArray = 10;
int[] numbers = new int[sizeArray];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int countEvenNumbers = 0;
foreach (int number in numbers)
{
    if(number % 2 == 0) countEvenNumbers++;
}

Console.WriteLine($"В массиве {countEvenNumbers} четных чисел.");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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