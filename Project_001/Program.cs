// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] numbers = new int[12];
int sumPositive = 0;
int sumNegative = 0;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

foreach (int i in numbers)
{
    if (i > 0)
    {
        sumPositive += i;
    }
    else
    {
        sumNegative += i;
    }
}

Console.WriteLine($"Сумма положительных чисел = {sumPositive}\nСумма отрицательных чисел = {sumNegative}");

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