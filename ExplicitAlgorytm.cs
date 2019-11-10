using System;
using System.Collections.Generic;

namespace VertexCoverProblem
{
    class ExplicitAlgorytm
    {
        private int[,] graph;
        public ExplicitAlgorytm(int[,] graph) {
            this.graph = graph;
        }

        bool Check(List<int> verts)
        {
            var n = graph.GetLength(1);
            var tmp = (int[,]) graph.Clone();

            foreach (var v in verts)
            {
                for (var i = 0; i < n; i++)
                {
                    tmp[v, i] = tmp[i, v] = 0;
                }
            }

            foreach (var e in tmp)
            {
                if (e != 0) return false;
            }
            return true;
        }
        



        List<int> CheckSubsets() {
            var n = graph.GetLength(0);
            var subsets = new List<List<int>>();
            subsets.Add(new List<int>());

            var minLength = n;
            List<int> mvc = null;

            for (var v = 0; v < n; v++) {
                var sl = subsets.Count;
                for (var i = 0; i < sl; i++) {
                    var ssl = subsets[i].Count;
                    List<int> ss = subsets[i].GetRange(0, ssl);
                    ss.Add(v);
                    subsets.Add(ss);
                }
            }

           foreach(var verts in subsets) {
                //Console.Write("[ ");
                //foreach(var v2 in v) {
                //    Console.Write(v2 + " ");
                //}
                var res = Check(verts);
                //Console.WriteLine("] " + res);

                if (res)
                {
                    if (verts.Count < minLength)
                    {
                        minLength = verts.Count;
                        mvc = verts;
                    }
                }
           }
           //Console.WriteLine("length " + subsets.Count);

            return mvc;

        }


        public List<int> Solve()
        {
            return CheckSubsets();
            
        }
    }
}
