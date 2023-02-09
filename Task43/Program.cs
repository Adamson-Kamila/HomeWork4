// Напишите программу, которая найдет точку пересячения двух прямых заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void getPoint()
{
    Console.Clear();
    Console.WriteLine("Введите число для b1: ");
    double  b1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите число для k1: ");
    double k1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите число для b2: ");
    double b2 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите число для k2: ");
    double k2 = int.Parse(Console.ReadLine()!);


    if( k1 == k2 )
    {
        Console.WriteLine("Прямые паралельны, точки пересечения отсутствуют");
    } 

    else 
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения имеет координаты  {x} и {y}");   
    }


}

getPoint();