/* Problem 1. Cinema
 */

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string type = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        decimal income=0;
        switch (type)
        {
            case "Premiere": income=(decimal)(row*col*12.0); break;
            case "Normal": income=(decimal)(row*col*7.5); break;
            case "Discount": income=(decimal)(row*col*5.0); break;
            default: return;
        }
        Console.WriteLine("{0:F2} leva", income);
    }
}