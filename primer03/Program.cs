/*
## primer03
В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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
void modymas(int[,] arr)
{
int rows = arr.GetUpperBound(0) + 1;    // количество строк
int columns = arr.Length / rows;        // количество столбцов
 
for (int i = 0; i < rows; i=i+2)
{
    for (int j = 0; j < columns; j=j+2)
    {
         arr[i, j] = arr[i, j] * arr[i, j];
    }
   }
}

int rows = new Random().Next(5,10);    // количество строк
int columns = new Random().Next(5,10); 
int[,] numbers = new int [rows,columns];

fillmas(numbers);
printmas(numbers);
modymas(numbers);
Console.WriteLine();
printmas(numbers);