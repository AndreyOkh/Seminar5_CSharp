// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

int sizeArray = 5;
double[] numbers = new double[sizeArray];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int minNumberIndex = 0;
int maxNumberIndex = 1;

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < numbers[minNumberIndex]) minNumberIndex = i;
    else if (numbers[i] > numbers[maxNumberIndex]) maxNumberIndex = i;
}

Console.WriteLine(@$"Минимальное число в массиве {numbers[minNumberIndex]}
Максимальное число в массиве {numbers[maxNumberIndex]}
Разница между максимальным и минимальным {Math.Round(numbers[maxNumberIndex] - numbers[minNumberIndex], 2)}");

void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        // array[i] = Convert.ToDouble(new Random().Next(1, 100) / 10.0);   // Как вариант
        array[i] = Math.Round(new Random().NextDouble() * 10, 2);
    }
}

void PrintArray(double[] array)
{
    foreach (double i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}