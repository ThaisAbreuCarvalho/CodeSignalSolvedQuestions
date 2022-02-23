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
        var see = solution(new string[] { "SEND", "MORE", "MONEY" }, new char[][] {
            new char[] {'O', '0'},
            new char[] {'M', '1'},
            new char[] {'Y', '2'},
            new char[] {'E', '5'},
            new char[] {'N', '6'},
            new char[] {'D', '7'},
            new char[] {'R', '8'},
            new char[] {'S', '9'} });
    }

    public static bool solution(string[] crypt, char[][] solution)
    {
        var expression = string.Empty;
        var toSum = new List<long>();

        foreach(var word in crypt)
        {
            var wordChanged = word.ToCharArray();
            foreach (var letter in wordChanged)
            {
                var letterToAdd = solution.Where(x => x[0] == letter).ToList().FirstOrDefault();
                expression += letterToAdd[1];
            }

            if (expression.Length> 1 && expression.StartsWith('0'))
            {
                return false;
            }
            else
            {
                toSum.Add(Convert.ToInt64(expression));
                expression = string.Empty;
            }
        }

        if(!(toSum[0] + toSum[1] == toSum[2]))
        {
            return false;
        }

        return true;
    }
}
