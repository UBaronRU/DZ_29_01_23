/*
## primer04
В матрице чисел найти сумму элементов главной диагонали
*/

void printmas(int[,] arr)
{
int rows = arr.GetUpperBound(0) + 1;    // количество строк
int columns = arr.Length / rows;        // количество столбцов
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}
}
void fillmas(int[,] arr)
{
int rows = arr.GetUpperBound(0) + 1;    // количество строк
int columns = arr.Length / rows;        // количество столбцов
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = new Random().Next(1,9);
    }
   }
}

int rows = new Random().Next(5,10);    // количество строк
int[,] numbers = new int [rows,rows];
int main_diag = 0;
fillmas(numbers);
printmas(numbers);
Console.WriteLine();
for (int i = 0; i < rows; i++)
{
    main_diag = main_diag + numbers[i,i];
}
Console.Write("Сумма элементов главной диагонали: "+main_diag);
