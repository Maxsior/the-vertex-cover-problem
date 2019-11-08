using System;
using System.Collections.Generic;

namespace VertexCoverProblem
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int n = 20;
            for (int i = 1; i <= n; i++)
            {
                var graph = Reader.Read("data/" + i + ".mis");
                var result = Greedy.Solve(graph);
                Console.WriteLine(i + ": " + result.Count);
            }
            Console.ReadKey();
          
            var graph = Reader.Read("data/LazySampleEasy.mis");

            LazyAlg lazy = new LazyAlg(graph);

            List<int> res = lazy.Solve();

            foreach(int x in res)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Console.WriteLine(res.Count);
        }
    }
}
