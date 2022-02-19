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
        var see = solution(new int[][] { });
    }

    public static int[][] solution(int[][] a)
    {
        var newArray = new int[a.Count()][];

        for (int i = 0; i < a.Count(); i++)
        {
            var array = new List<int>();

            for (int j = a.Count() - 1; j >= 0; j--)
            {
                array.Add(a[j][i]);
            }

            newArray[i] = array.ToArray();
        }

        return newArray;
    }


}
