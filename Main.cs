using System;
using System.Collections.Generic;

namespace VertexCoverProblem
{
    public static class Program
    {

        public static void Print(List<int> vertexCover, DateTime start)
        {
            // vertexCover.Sort();
            Console.Write("Минимальное вершинное покрытие:");
            foreach (var v in vertexCover)
            {
                Console.Write((v < 10 ? "  " : " ") + v);
            }
            Console.WriteLine();
            Console.WriteLine(DateTime.Now - start);
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {

            var graph = Reader.Read("data/nn.mis");

            //// explicit ////
            var start = DateTime.Now;
            if (graph.GetLength(0) < 23)
            {
                var explicitSolver = new ExplicitAlgorytm(graph);
                var vertexCover = explicitSolver.Solve();
                Print(vertexCover, start);
            }
            else
            {
                Console.WriteLine("Точный алгортм упал\n");
            }
            

            //// greedy ////
            start = DateTime.Now;
            var result = Greedy.Solve(graph);
            Print(result, start);

            //// lazy ////
            start = DateTime.Now;
            LazyAlg lazy = new LazyAlg(graph);
            List<int> res = lazy.Solve();
            Print(res, start);

            Console.ReadKey();
        }
    }
}
