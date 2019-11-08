using System;

namespace VertexCoverProblem {
    public static class Program
    {
        public static void Main(string[] args)
        {
            var graph = Reader.Read("data/1.mis");
            var explicitSolver = new ExplicitAlgorytm(graph);
            var vertexCover = explicitSolver.Solve();
            Console.Write("Минимальное вершинное покрытие: ");
            foreach (var v in vertexCover)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();
        }
    }
}
