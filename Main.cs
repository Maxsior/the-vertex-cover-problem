using System;
using System.Collections.Generic;

namespace VertexCoverProblem
{
    public static class Program
    {

        public static void Print(List<int> vertexCover)
        {
            // vertexCover.Sort();
            Console.Write("Минимальное вершинное покрытие:");
            foreach (var v in vertexCover)
            {
                Console.Write((v < 10 ? "  " : " ") + v);
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {

            var graph = Reader.Read("data/new.mis");

            //// explicit ////

            var explicitSolver = new ExplicitAlgorytm(graph);
            var vertexCover = explicitSolver.Solve();
            Print(vertexCover);
            
            //// greedy ////

            var result = Greedy.Solve(graph);
            Print(result);
          
            //// lazy ////
            
            LazyAlg lazy = new LazyAlg(graph);
            List<int> res = lazy.Solve();
            Print(res);

            Console.ReadKey();
        }
    }
}
