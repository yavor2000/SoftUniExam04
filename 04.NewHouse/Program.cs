/* Problem 3. New house
 */

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int start = 1;
        //Console.WriteLine(new string('-', (n - start) / 2) + "*" + new string('-', (n - start) / 2));
        //start = start + 2;
        while (start<=n)
        {
            Console.WriteLine(new string('-', (n - start) / 2) + new string('*',start) + new string('-', (n - start) / 2));
            start = start + 2;
        }
        for (int i = 0; i < n; i++) Console.WriteLine("|"+new string('*',n-2)+"|");
    }
}