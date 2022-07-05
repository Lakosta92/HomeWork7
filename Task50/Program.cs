// Задача 50: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


int m = Input("m= ");
int n = Input("n= ");
int[,] array = new int[m, n];
int number = Input("Введите позицию элемента: ");

if (number / 10 > m || number % 10 > n)
{
    Input("Такого числа в массиве нет");
    return;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(array[number/ 10, number % 10]);


void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-100, 100);
        }

    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}