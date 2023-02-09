Console.Clear();

int [,] myArray = new int [,]
{
    {10, 4, 5},
    {7, 4, 8},
    {4, 10, 2}
};

// foreach (var item in myArray) //цикл foreach позволяет просто и быстро вывести элемента массива в консоль.
// // задача этого цикла заключается в переборе элементов в коллекции. Этот цикл будет пробегаться по всем элементам 
// // массива и извлекать их. Пока цикл будет пробегать по всем эементам массива, внутри тела foreach
// // команда ConsoleWritLine будет выводить их по порядку в консоль. 
// {
//     Console.WriteLine(item); //WriteLine - вертикальный вывод. Write - горизонтальный. Для добавдения
//     // пробела между эементам  - (item + " ");
// }

//Console.Write(myArray.Rank); //Rank - оператор, отображающий количество измерений массива. В нашем случае это 2.
//Console.Write(myArray.Length); //Length - оператор, указывающий длину массива и как следствие количество элементов.
// В нашем случае их - 9.
//Console.Write(myArray.GetLength);

//Console.WriteLine(myArray.GetLength(1)); //GetLength позволит увидеть сколько строк и колонок в массиве, если укажем 0
// то покажет строки, в нашем случае это - 3, если 1, то покажет количество колонок, в нашем случае - это 3.

//int heigth  = myArray.GetLength(0);
//int width = myArray.GetLength(1);

for (int y = 0; y < myArray.GetLength(0); y++)
{
    Console.Write(myArray[2,y] +"\t"); // 2 указывает индекс строки
}

for (int x = myArray.GetLength(1)-2; x >= 0; x--)
{
    Console.Write(myArray[x,2] +"\t");
}

for (int y = myArray.GetLength(0)-2; y >= 0 ; y--)
{
    Console.Write(myArray[0,y] +"\t");
}

for (int y = 0; y < myArray.GetLength(0)-1; y++)
{
    Console.Write(myArray[1,y] +"\t");
}

// {
// for (int y = 0; y < myArray.GetLength(1); y++)
//     {
//          Console.Write(myArray[x,y] +"\t");
//     }
//      Console.WriteLine();
// }