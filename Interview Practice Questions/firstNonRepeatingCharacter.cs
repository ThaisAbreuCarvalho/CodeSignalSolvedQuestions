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
        var see = solution("");
    }

    public static char solution(string s)
    {
        var teste = s.ToList<char>().GroupBy(x => x);

        var re = teste.Where(y => y.Count() == 1);

        return re.Any() ? re.FirstOrDefault().Key : '_';
    }

}
