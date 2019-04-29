using System;
using Graph.DFS;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            DfsTest();

        }

        private static void DfsTest()
        {
            var test = new FindAllLockBreakingSolutions();
            var list = test.GetSolutions();
            
            foreach (var str in list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Count is {0}", list.Count);
        }
    }
}
