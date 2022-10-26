/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4  */
Console.Write("Массив 6*6! Введите позицию элемента, строка (от 0 до 5): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Массив 6*6! Введите позицию элемента, столбец (от 0 до 5): ");
int m = Convert.ToInt32(Console.ReadLine());

void InputMatrix( int  [,] matrix )
{
    for ( int i=0; i<matrix.GetLength(0); i++ )
    {
        for ( int j=0; j<matrix.GetLength(1); j++ )
        {
            matrix[i,j] = new Random().Next(1,10);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}
int FindMatrix(int[,] matrix)
{
    int find = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)       
   {
    for (int j = 0; j < matrix.GetLength(1); j++)   
       
       if ( i == n && j == m ) 
        {
          find = matrix[i, j];
        }  
     }
         return (find);
                
}

 int [,] matrix = new int [6,6];
  if ( n > matrix.GetLength(0)-1 && m > matrix.GetLength (1)-1 )
        {
            Console.WriteLine(" Такого элемента нет!");
        }
InputMatrix(matrix);
FindMatrix(matrix);
Console.Write($"Вывод: {FindMatrix(matrix)}");

