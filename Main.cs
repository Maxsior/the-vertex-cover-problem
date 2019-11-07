using System;
using System.Collections.Generic;
using VertexCoverProblem;

public static class Program
{
	public static void Main(string[] args)
	{
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
