/* Problem 4. Crossing sequences
 */

using System;
using System.Numerics;

class Program
{
    static ulong t1;
    static ulong t2;
    static ulong t3;
    static ulong s1;
    static ulong step;
    static ulong nextT;
    static int indexT;
    
    static void Main()
    {
        t1 = (ulong.Parse(Console.ReadLine()));
        t2 = (ulong.Parse(Console.ReadLine()));
        t3 = (ulong.Parse(Console.ReadLine()));
        s1 = (ulong.Parse(Console.ReadLine()));
        step = (ulong.Parse(Console.ReadLine()));
        nextT = 0;
        indexT = 1;
        uint count = 0;
        int iter = 0;
        ulong tri = 0;
        bool calcTri = true;
        while (true)
        {
            if (calcTri) { tri = tribonacci(indexT); calcTri = false; }
            if (s1 == tri) { Console.WriteLine(s1); return; }
            if (tri > 1000000 || s1 > 1000000) { Console.WriteLine("No"); return; }
            else
            if (s1 > tri)
            {
                indexT++;
                calcTri = true;
                continue;
            }
            else
            {
                if (iter % 2 == 0) count++;
                s1 += count * step;
                iter++;
                continue;
            }
            
        }
    }

    static ulong tribonacci(int index)
    {
        switch (index)
        {
            case 1: return t1;
            case 2: return t2;
            case 3: return t3;
            default:
                nextT = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = nextT;
                break;
        }
        return nextT;
    }
}