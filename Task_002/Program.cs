//Задача 2: 
//Задайте двумерный массив. Напишите
//программу, которая поменяет местами первую и
//последнюю строку массива.

int row = 0, cols = 0, i = 0, j = 0, rev = 0;
int[,] n;

Random rand = new Random();

string reading;

System.Console.WriteLine("Программа принимает позиции элемента в двумерном массиве,");
System.Console.WriteLine("возвращает значение этого элемента или говорит, что такого нет");
Console.WriteLine();
GenerateArray();

void GenerateArray()
{
    row = rand.Next(1,10);
    cols = rand.Next(1,10);
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
            ReversFirstLast();     
        }
        else if (reading == "n" || reading == "N")
        {
            GenerateArray();
        }
        else
            Proverka();
    }
}

void ReversFirstLast()
{
    for (j = 0; j < cols; j++)
    {
        rev = n[0, j];
        n[0, j] = n[row - 1, j]; 
        n[row - 1, j] = rev;
    }

    System.Console.WriteLine("Новый массив чисел");

    for (i = 0; i < row; i++)
    {
        for (j = 0; j < cols; j++)
        {
            System.Console.Write($" {n[i, j]}");
        }
        Console.WriteLine();
    }
}

/*
void Revers()
{
    for (i = 0; i < lenght / 2; i++)
    {
        num = n[i];
        n[i] = n[lenght - (1 + i)];
        n[lenght - (1 + i)] = num;  
    }

    Console.WriteLine();
    System.Console.Write("Перевёрнутый массив чисел: ");

    for (i = 0; i < lenght; i++)
    {
        if (i != lenght - 1)
        {
            System.Console.Write($" {n[i]},");
        }
        else
        {
            System.Console.Write($" {n[i]}");
        }
    }
}
*/