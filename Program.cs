double rd()
{
    Random rnd = new Random();
    double a = rnd.Next(1, 9);
    return a;
}

void Arr(double[,] arr)//заполняет массив
{ 
    for (int indexX = 0; indexX < arr.GetLength(0); indexX++)
    {
        Console.WriteLine();
        for (int indexY = 0; indexY < arr.GetLength(1); indexY++)
        {
            arr[indexX, indexY] = rd();
            Console.Write( arr[indexX,indexY]);
            Console.Write(" ");
        }
    }

}
//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
///в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void viev(double[,] arr, int indexX, int indexY)
{
    if (indexX < arr.GetLength(0) && indexY < arr.GetLength(1))
    {
        Console.WriteLine(arr[indexX, indexY]);
    }
    else
    {
        Console.WriteLine("нет такого элемента");
    }

}
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
void ArithmeticMeanOfColumns(double[,] arr)
{
    int IndexArri = arr.GetLength(1);
    double[] arri = new double[IndexArri];
    for (int indexX = 0; indexX < arr.GetLength(0); indexX++)
    {
       
        for (int indexY = 0; indexY < arr.GetLength(1); indexY++)
        {
            double a = arr[indexX, indexY];
            arri[indexY] = arri[indexY] + a;
        }
    }
    for (int indexY = 0; indexY < arri.GetLength(0); indexY++)
    {
        arri[indexY] = arri[indexY] / arri.GetLength(0);
        Console.Write("столбец № ");
        Console.Write(indexY + 1);
        Console.Write(": ");
        Console.WriteLine(arri[indexY]);
    }
}
Console.WriteLine("задайте длинну и ширену двумерного массива");
Console.WriteLine("в ведите значение X ");
int IndexX = int.Parse(Console.ReadLine());
Console.WriteLine("в ведите значение Y ");
int IndexY = int.Parse(Console.ReadLine());
double[,] arr = new double[IndexX, IndexY];
Arr(arr);
Console.WriteLine("среднее арефметическое в каждом столбце");
ArithmeticMeanOfColumns(arr);
while (true)
{
    Console.WriteLine("программа вывода каждого элемента массива по индексу");
    Console.WriteLine("в ведите первый индекс массива");
    int indexX = int.Parse(Console.ReadLine());
    Console.WriteLine("в ведите второй индекс массива");
    int indexY = int.Parse(Console.ReadLine());
    Console.Write("элемент массива равен:");
    viev(arr, indexX, indexY);
}


