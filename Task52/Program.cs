// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


int m = Input("m= ");
int n = Input("n= ");
double arifmeticMean = 0;
double allColumn = 0;
int[,] array = new int[m, n];


FillRandomArray(array);
PrintArray(array);




void FillRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 100);
        }
    }

}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

    for (int i = 0; i < array.GetLength(0); i++)
    {  
        allColumn = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            allColumn += array[j, i];
        }
        arifmeticMean = allColumn / n;
        System.Console.Write (Math.Round(arifmeticMean,2) + "  ");

    }




