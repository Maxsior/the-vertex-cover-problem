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
        }
    }
}
