using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbujita
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arreglo = new int[50000];
            for(int i = 0; i<50000; i++)
            {
                arreglo[i] = rnd.Next(0, 10000);
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int o = 0; o < 49999; o++)
            {
                for (int i = 0; i < 49999; i++)
                {
                    if (arreglo[i] >= arreglo[i + 1])
                    {
                        int temp = arreglo[i + 1];
                        arreglo[i + 1] = arreglo[i];
                        arreglo[i] = temp;
                    }
                }
            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            /*for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(arreglo[i]);
            }*/
            Console.ReadKey();
        }
    }
}