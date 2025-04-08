using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int count = 10000;

        // STRING bilan test
        Stopwatch sw1 = Stopwatch.StartNew();
        string result = "";
        for (int i = 0; i < count; i++)
        {
            result += "Salom";
        }
        sw1.Stop();
        Console.WriteLine("string: " + sw1.ElapsedMilliseconds + " ms");

        // STRINGBUILDER bilan test
        Stopwatch sw2 = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            sb.Append("Salom");
        }
        sw2.Stop();
        Console.WriteLine("StringBuilder: " + sw2.ElapsedMilliseconds + " ms");
    }
}
