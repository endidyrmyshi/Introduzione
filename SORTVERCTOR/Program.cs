using System;

namespace SORTVERCTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vett = new int[10] { -4,1,100,-85,4,6,77,-35,2,0};
            Array.Sort(vett);
            for(int i = 0; i < 10; i++)
            {
                Console.Write(vett[i] + "|");

                
            }
            

            Console.ReadKey();
        }

    }
}
