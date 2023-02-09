// Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего элемента 
// против часовой стрелки.

Console.Clear();

int [,] getArray()
{
  int [,] myArray = new int[3,3];
  
  for (int i = 0; i < myArray.GetLength(0); i++)
  {
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
      //Console.Write(myArray[i, j]);
    }
    //Console.WriteLine();
  }
  
  return myArray;
}



int [,] getRandom(int [,] array)
{

 Random random = new Random();

 for(int i = 0; i < array.GetLength(0); i++)
 {
  for(int j = 0; j < array.GetLength(1); j++)
  {
    array[i, j] = random.Next (0, 11);
    Console.Write(array[i, j] + "\t");
  }
      Console.WriteLine();
 }
  

    return array;
}

int [,] counterclockwise(int [,]array)
{
  for (int y = 0; y < array.GetLength(0); y++)
{
    Console.Write(array[2,y] +"\t"); // 2 указывает индекс строки
}

for (int x = array.GetLength(1)-2; x >= 0; x--)
{
    Console.Write(array[x,2] +"\t");
}

for (int y = array.GetLength(0)-2; y >= 0 ; y--)
{
    Console.Write(array[0,y] +"\t");
}

for (int y = 0; y < array.GetLength(0)-1; y++)
{
    Console.Write(array[1,y] +"\t");
}
  return array;

}

int [,] array = getArray(); // дефолтное значение = по умолчанию
int [,] randomArray = getRandom(array);
Console.WriteLine();
int [,] clockarray = counterclockwise(array);

