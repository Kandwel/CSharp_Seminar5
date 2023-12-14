//Задача 1: 
//Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.

int row = 0, cols = 0, i = 0, j = 0, rowFound, colsFound;
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
            InputNumbers();       
        }
        else if (reading == "n" || reading == "N")
        {
            GenerateArray();
        }
        else
            Proverka();
    }
}

void InputNumbers()
{
    System.Console.WriteLine("Чтобы выйти введите '0'");
    System.Console.WriteLine();

    System.Console.Write("Введите номер строки:");
    rowFound = Convert.ToInt32(Console.ReadLine());    
    System.Console.Write("Введите номер колонки:");
    colsFound = Convert.ToInt32(Console.ReadLine());

        if (rowFound <= row && colsFound <= cols && rowFound > 0 && colsFound > 0)
        {
            System.Console.WriteLine($"В указаных строке и колонке находится число '{n[rowFound - 1, colsFound - 1]}'");
        }
        else if (rowFound > row && colsFound <= cols && colsFound > 0)
        {
            System.Console.WriteLine("Строк в массиве меньше, измените число");
            InputNumbers();
        }
        else if (rowFound <= row && colsFound > cols && rowFound > 0)
        {
            System.Console.WriteLine("Колонок в массиве меньше, измените число");
            InputNumbers();
        }
        else if(rowFound == 0 || colsFound == 0)
        {
            System.Console.WriteLine("Вы решили выйти из игры");
        }
        else
        {
            System.Console.WriteLine("Введено некорректное значение, повторите попытку");
            InputNumbers();
        }

}

