using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System;
using System.Linq;
using System.Diagnostics;

class Solution
{
    public static void Main(string[] args)
    {
        var see = solution(new char[][] { });
    }

    public static bool solution(char[][] grid)
    {
        var response = true;
        var dictV = new Dictionary<char, HashSet<int>>();
        var dictH = new Dictionary<char, List<int>>();
        var square = new List<char>();

        int nArray = 3;
        int nValues = 3;
        int indiceArray = 0;
        int indiceSquares = 0;

        while (indiceArray < grid.Count())
        {
            for (int i = indiceArray; i < nArray; i++)
            {
                for (int j = indiceSquares; j < nValues; j++)
                {
                    if (grid[i][j] != '.')
                    {
                        square.Add(grid[i][j]);

                        if (dictV.ContainsKey(grid[i][j]))
                        {
                            var testeV = dictV.Where(x => x.Key == grid[i][j]);
                            var testeH = dictH.Where(x => x.Key == grid[i][j]);

                            if (testeV.Any(x => x.Value.Contains(j)) || testeH.FirstOrDefault().Value.Contains(i))
                            {
                                response = false;
                                break;
                            }
                            else
                            {
                                testeV.FirstOrDefault().Value.Add(j);
                                testeH.FirstOrDefault().Value.Add(i);
                            }
                        }
                        else
                        {
                            dictV.Add(grid[i][j], new HashSet<int> { j });
                            dictH.Add(grid[i][j], new List<int> { i });
                        }
                    }

                }

                if (response == false)
                    break;
            }


            indiceSquares = nValues;
            if (square.GroupBy(x => x).Any(x => x.Count() > 1))
            {
                response = false;
                break;
            }
            else if (indiceSquares < grid.Count())
            {
                nValues += 3;
                square.Clear();
            }
            else
            {
                indiceSquares = 0;
                nValues = 3;
                indiceArray = nArray;
                nArray += 3;
                square.Clear();
            }
        }

        return response;
    }



}
