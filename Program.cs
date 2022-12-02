//Задайте двумерный массив размером mxn, заполненный случайными числами.

/*
int [,] Create2dArray(int row, int column, int minVal, int maxVal)  // создание двумерного массива
{
    int [,] createdArray = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            createdArray [i,j] = new Random().Next(minVal, maxVal + 1);
    return createdArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");  //вывод значений
        }
        Console.WriteLine();   // переход на новую строку
    }
    Console.WriteLine();   // отступ от массива
}

Console.WriteLine("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Create2dArray(rows, columns, min, max);
Show2dArray(newArray);
*/

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
//Aₘₙ = m+n. Выведите полученный массив на экран.
// 2x3
// 0 0+1 0+2 |
// 0 1 2 <----
// 1 2 3

/*
int [,] Create2dArray(int row, int column)  // создание двумерного массива
{
    int [,] createdArray = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            createdArray [i,j] = i + j;
    return createdArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");  //вывод значений
        }
        Console.WriteLine();   // переход на новую строку
    }
    Console.WriteLine();   // отступ от массива
}

Show2dArray(Create2dArray(2, 3));
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

