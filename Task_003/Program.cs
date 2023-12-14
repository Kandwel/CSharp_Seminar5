//Задача 3: 
//Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с
//наименьшей суммой элементов.

int row = 0, cols = 0, i = 0, j = 0, rev = 0, min = 10000, sum, index = -1;
int[,] n;

Random rand = new Random();

string reading;

System.Console.WriteLine("Программа переставляет первую и последнюю строку двумерного массива");
Console.WriteLine();
GenerateArray();

void GenerateArray()
{
    row = rand.Next(1,10);
    cols = row;
    n = new int[row, cols];
    i = 0;    
    System.Console.WriteLine($"Масив состоит из {row} строки(ок) и {cols} колонки(ок)");
    System.Console.WriteLine("   Массив чисел");
    for (i = 0; i < row; i++)
    {
        for (j = 0; j < cols; j++)
        {
            n[i, j] = rand.Next(1,9);
            System.Console.Write($" {n[i, j]}");
        }
        Console.WriteLine();
    }

    Proverka();
}

void Proverka()
{
    Console.WriteLine();
    System.Console.Write("Вас устраивает массив? (Y/N) ");
    reading = Console.ReadLine();
    Console.WriteLine();
    if (reading != null)
    {
        if (reading == "Y" || reading == "y")
        {
            SumRow();
        }
        else if (reading == "n" || reading == "N")
        {
            GenerateArray();
        }
        else
            Proverka();
    }
}

void SumRow()
{
    for (i = 0; i < row; i++)
    {
        sum = 0;
        for (j = 0; j < cols; j++)
        {
            sum = sum + n[i, j];
        }

        if (min > sum)
        {
            index = i;
            min = sum;
        }
    }
    System.Console.WriteLine($"Мнимальная сумма строки = {min}; Строка: {index + 1}; Индекс: {index}");
}