using System;
using System.IO;

public static class Reader
{
	public static int[,] Read(string fname)
	{

        int[,] graph = null;
        StreamReader sr = new StreamReader(fname);
        string[] line;
        while (!sr.EndOfStream)
        {
            line = sr.ReadLine().Split(' ');

            if (line[0] == "p")
            {
                int n = int.Parse(line[2]);
                graph = new int[n, n];
            }
            else if (line[0] == "e")
            {
                if (graph == null)
                {
                    throw new Exception("Чо за фигня? Где строка с описание количества вершин графа?");
                }

                int i = int.Parse(line[1]) - 1;
                int j = int.Parse(line[2]) - 1;

                graph[i, j] = graph[j, i] = 1;
            }
        }
        sr.Close();

        return graph;
	}
}
