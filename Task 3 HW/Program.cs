// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите количестов строк массива: ");
int n = Convert.ToInt32( Console.ReadLine());
Console.Write("Введите количестов столбцов массива: ");
int m = Convert.ToInt32( Console.ReadLine());
int [,] matrix = new int [n,m];


void InputMatrix ( int [,] matrix)
{
    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,5);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}
    
InputMatrix(matrix);   

for ( int j = 0; j < matrix.GetLength(1); j++)

    {
        double srarif = 0;
        for ( int i = 0; i < matrix.GetLength(0); i++)
        {
             srarif = srarif + matrix [i,j];
        }
        srarif = srarif/n;
        /*Console.WriteLine(srarif + "; ");*/
        Console.WriteLine($"Среднее арифметическое в столбце  {srarif} ;");
    }    

        


