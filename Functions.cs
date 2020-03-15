using System;
using System.IO;

public class Functions
{
    static void ReadFromFile(string path)
    {
        string[] s = File.ReadAllLines(path);
        
        for (long n = 0; n < s.Length; n++)
        {
            var v = s[n]; //just add s[n].type.TryParse in case of numeric operations
            if ((* anything whatever you need goes here *))
            {
                //code
            }
        }
    }
    
    static bool IsEven(long n)
    {
        bool even = (n % 2 == 0 && n != 0);
        
        switch (even)
        {
            case true:
                return true;
                break;
            default:
                return false;
                break;
        }
    }
}
