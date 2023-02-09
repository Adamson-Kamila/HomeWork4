// Пользователь вводит с клавиатуры М чисе. Посчитать сколько чисел больше 0 ввел пользователь.
//Например: 0, 7, 8, -2, -2 -> 2 или 1, -7, 567, 89, 223 -> 4


int[] youarray ()
{
    Console.Clear();
    Console.Write("Введите элементы массива\t");
    int[]myArray = new int [5];

    for(int i = 0; i < myArray.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом {i}:\t ");
    myArray[i] = int.Parse(Console.ReadLine()!);
    
}
    return myArray;
}


int quantity(int [] myArray)
{
    int quantity = 0;
    for(int i = 0; i < myArray.Length; i++)
{
    if (myArray [i] > 0)
    quantity +=1;

}
    return quantity;
    //Console.WriteLine(quantity);
}

int [] array = youarray();
int num = quantity(array);
Console.Write("[{0}]", string.Join(",", array ));
Console.Write("->" );
Console.Write(num );

