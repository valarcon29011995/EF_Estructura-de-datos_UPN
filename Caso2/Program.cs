using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int INF = 99999;

            int[,] dijstra =  
            {
                 {0,6,5,16,17,0,0},
                 {6,0,9,0,0,0,0},
                 {7,9,0,6,15,8,0},
                 {0,0,0,0,10,0,7},
                 {6,25,5,0,0,1,0},
                 {0,7,10,0,0,0,4},
                 {0,12,0,14,0,0,0}
            };

            //El camino más corto de Dijkstra
            Console.WriteLine("********** Algoritmo de Dikjstra **********");
            DijkstraAlgo.DijkstraAlgoritmo(dijstra, 1, 7);

            int[,] warshall = 
            {
                { 0,6,5,16,17,INF,INF},
                { INF,0,INF,INF,INF,INF,INF},
                { 7,9,0,6,15,8,INF},
                { INF,INF,INF,0,10,INF,7},
                { 6,25,5,INF,0,1,INF},
                { INF,7,10,INF,INF,0,4},
                { INF,12,INF,14,INF,INF,0}
            };
            Console.WriteLine("\n");

            Console.WriteLine("********** Algoritmo de FloydWarshall **********");
            Floyd.FloydWarshallAlgo(warshall, 7);

            int[,] prim =  
            {
                 {0,6,5,16,17,0,0},
                 {6,0,9,0,0,0,0},
                 {7,9,0,6,15,8,0},
                 {16,0,0,0,10,0,7},
                 {17,25,5,10,0,1,0},
                 {0,7,10,0,1,0,4},
                 {0,12,7,14,0,4,0}
            };
            Console.WriteLine("\n");

            Console.WriteLine("********** Algoritmo de prim **********");
            Prim.PrimAlgo(prim, 7);

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
