using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the wind speed in mph:");
        double windSpeed = double.Parse(Console.ReadLine());

        if (windSpeed >= 157)
        {
            Console.WriteLine("Category Five Hurricane");
        }
        else if (windSpeed >= 130)
        {
            Console.WriteLine("Category Four Hurricane");
        }
        else if (windSpeed >= 111)
        {
            Console.WriteLine("Category Three Hurricane");
        }
        else if (windSpeed >= 96)
        {
            Console.WriteLine("Category Two Hurricane");
        }
        else if (windSpeed >= 74)
        {
            Console.WriteLine("Category One Hurricane");
        }
        else
        {
            Console.WriteLine("Not a Hurricane");
        }
    }
}