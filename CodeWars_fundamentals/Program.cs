using System;
using System.Linq;

public static class Kata
{
    public static string boolToWord(bool word)
    {
        return word ? "yes" : "no";
    }
    
    public static int FindSmallestInt(int[] args)
    {
        return args.Min();
    }
    
    public static string RemoveExclamationMarks(string s)
    {
        return s.Replace("!", "");
    }
    
    public static int Enough(int cap, int on, int wait)
    {
        int total = cap >= on + wait ? 0 :(on + wait) - cap;
        return total; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        int result = Kata.Enough(10, 5, 7);
        Console.WriteLine(result);
    }
}