using System;
using System.Collections.Generic;
using System.Linq;

namespace Krasimira
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = { 1, 1, 0, 1, 1, 1, 0, 0, 1 };

            List<int> currentCounter = new List<int>();

            int counter = 0;

            for (int i = 0; i < numbs.Length; i++)
            {
                if(numbs[i] == 1)
                {
                    counter++;
                }
                else
                {
                    currentCounter.Add(counter);
                    counter = 0;
                }
            }

            currentCounter.Sort();
            int lastElement = currentCounter[currentCounter.Count - 1];
           

            Console.WriteLine(lastElement);

        }
    }
}
