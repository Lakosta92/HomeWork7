// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


int m = Input("m= ");
int n = Input("n= ");

double[,] array = new double[m, n];

void FillArray(double[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((Convert.ToDouble(( new Random().Next(-100, 100)))/10),2);
        }

    }
}

void PrintArray(double[,] arr)
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
FillArray(array);
PrintArray(array);