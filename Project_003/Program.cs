// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] numbers = new int[10];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int number = ReadLine();

bool findNumber = false;

foreach (int i in numbers)
{
    if (i == number)
    {
        findNumber = true;
    }
}

if(findNumber)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

 
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

int ReadLine()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine()!);
    return number;
}