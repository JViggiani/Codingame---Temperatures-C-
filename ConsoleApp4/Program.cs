using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        int currentClosest = 5526;
        if (n == 0)
        {
            currentClosest = 0;
        }
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
            if (Math.Abs(t) < Math.Abs(currentClosest) || (Math.Abs(t) == Math.Abs(currentClosest) && t > currentClosest))
            {
                currentClosest = t;
            }
            else continue;
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(currentClosest);
    }
}
