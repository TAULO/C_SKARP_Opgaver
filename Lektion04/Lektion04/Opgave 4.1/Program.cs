using System;

namespace Lektion04
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var string1 = "hello";
    //        var string2 = "hello my friend";

    //        var n  = string1.Lang(5);
    //        var n2 = string2.Lang(5);

    //        Console.WriteLine(n);
    //        Console.WriteLine(n2);
    //    }
    //}

    public static class StrLang
    {
        public static bool Lang(this string s, int n)
        {
            return s.Length > n;
        }
    }
}
