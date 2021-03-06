/* Problem 2. Illuminati
 */

using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();
        ulong sum = 0;
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'A': sum += 65; count++; break;
                case 'E': sum += 69; count++; break;
                case 'I': sum += 73; count++; break;
                case 'O': sum += 79; count++; break;
                case 'U': sum += 85; count++; break;
            }
        }
        Console.WriteLine(count);
        Console.WriteLine(sum);
    }
}