/*
## primer02
Задать двумерный массив следующим правилом: Aₘₙ = m+n
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
        arr[i, j] = i+j;
    }
   }
}
void copymas(int[,] arr,int[,] arr1)
{
int rows = arr.GetUpperBound(0) + 1;    // количество строк
int columns = arr.Length / rows;        // количество столбцов
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr1[i, j] = arr[i, j];
    }
   }
}

int rows = new Random().Next(5,10);    // количество строк
int columns = new Random().Next(5,10); 
int[,] numbers = new int [rows,columns];
int[,] numbers2 = new int [rows,columns];
fillmas(numbers);
copymas(numbers,numbers2);
printmas(numbers2);