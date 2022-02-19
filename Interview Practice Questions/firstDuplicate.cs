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
        var see = solution(new int[] { });
    }

    public static int solution(int[] a)
    {
        HashSet<int> indexes = new HashSet<int>();
        for (int i = 0; i < a.Count(); i++)
        {
            if (indexes.Contains(a[i]))
            {
                return a[i];
            }

            indexes.Add(a[i]);
        }

        return -1;
    }
}
