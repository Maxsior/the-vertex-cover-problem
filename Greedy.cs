using System;
using System.Collections.Generic;

namespace VertexCoverProblem
{
    public static class Greedy
    {
        //возвращает индекс вершины с наибольшей степенью
        private static int GetMaxDeg(int[] vertex)
        {
            int I = 0;
            int max = 0;
            for (int i = 0; i < vertex.GetLength(0); i++)
            {
                if (vertex[i] > max)
                {
                    max = vertex[i];
                    I = i;
                }
            }
            return I;
        }

        //меняет значения в массиве степеней у вершин
        private static int[] CountVertexDegs(int[,] graph)
        {
            int n = graph.GetLength(0);
            int[] vertex_deg = new int[n];

            for (int i = 0; i < n; i++)
            {
                vertex_deg[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    if (graph[i, j] == 1)
                    {
                        vertex_deg[i] += 1;
                        if (i == j) vertex_deg[i] += 1;
                    }
                }
            }
            return vertex_deg;
        }

        //в графе все нули или нет?
        private static bool IsEmpty(int[] vertex)
        {
            for (int i = 0; i < vertex.GetLength(0); i++)
                if (vertex[i] != 0) return false;
            return true;
        }

        //решение
        public static List<int> Solve(int [,] igraph)
        {
            var graph = (int[,])igraph.Clone();
            List<int> result = new List<int>();

            int n = graph.GetLength(0);

            //считаем степени у вершин
            int[] vertex_deg = CountVertexDegs(graph);

            int vertex;

            for (; result.Count < n && !IsEmpty(vertex_deg);)
            {
                //жадно берем вершину с наибольшей степенью
                vertex = GetMaxDeg(vertex_deg);
                result.Add(vertex);

               //удаляем эту вершину из графа и из массива степеней
                for (int i = 0; i < n; i++)
                {
                    graph[vertex, i] = graph[i, vertex] = 0;
                }
                vertex_deg = CountVertexDegs(graph);
        }

        return result;
        }
    }
}
