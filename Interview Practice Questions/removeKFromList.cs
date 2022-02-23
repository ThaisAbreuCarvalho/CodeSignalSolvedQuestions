using System;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Web;

using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Numerics;

using Newtonsoft.Json;

class Solution
{
    public static void Main(string[] args)
    {
        var see = solution(new ListNode<int>
        {
            value = 1,
            next = new ListNode<int>
            {
                value = 2,
                next = new ListNode<int>
                {
                    value = 3,
                    next = new ListNode<int>
                    {
                        value = 2
                    }
                }
            }
        }, 2);
    }

    public static ListNode<int> solution(ListNode<int> l, int k)
    {
        if (l == null)
        {
            return null;
        }

        
        if (l?.value == k)
        {
            l = solution(l?.next, k);
        }
        if (l?.next != null)
        {
            l.next = solution(l?.next, k);
        }

        return l;
    }

    public class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }
    }
}
