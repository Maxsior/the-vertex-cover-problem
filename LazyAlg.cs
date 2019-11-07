using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VertexCoverProblem
{
    class LazyAlg
    {
        int[,] graph;
        int len;

        public LazyAlg(int[,] graph)
        {
            this.graph = graph;
            len = graph.GetLength(0);
        }



        // Chose first vertex, connected to this one
        // if no edges found returns -1
        private int ChoseFirstEdge(int k)
        {
            for(int i = 1; i < len; i++)
            {
                if (graph[i, k] == 1)
                    return i;
            }

            return -1;
        }

        private void RemoveIncident(int i, int j)
        {
            for(int k = 0; k < len; k++)
            {
                graph[i, k] = 0;
                graph[k, i] = 0;
                graph[j, k] = 0;
                graph[k, j] = 0;
            }
        }

        public List<int> Solve()
        {
            // Output graph with MVC
            List<int> VertexCover = new List<int>();

            // Go through all verteses add implement Lazy alg
            for(int i = 0; i < len; i++)
            {
                // Chose first edge
                int k = ChoseFirstEdge(i);

                if (k == -1)
                    continue;

                // Add vertex in MVC
                VertexCover.Add(i);
                VertexCover.Add(k);

                // Remove enges incident to this verteses
                RemoveIncident(i, k);
               
            }

            return VertexCover;
        }

    }
}
