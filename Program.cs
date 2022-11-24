using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace App
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] x = new string[args.Length - 2];
      string inputDate = args[0] + " " + args[1];

      DateTime dt = DateTime.ParseExact(inputDate, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

      for(int i = 0; i < args.Length - 2; i++)
      {
        x[i] = args[i + 2];
      }

      foreach(string str in x)
      {
        // Delete numbers from string
        string type = Regex.Replace(str, @"[0-9\+\-]", "");

        // Get only numbers from string
        int num = int.Parse(Regex.Replace(str, "[^0-9+-]", ""));
        
        switch(type)
        {
          case "mo":
            dt = dt.AddMonths(num);
            break;
          case "m":
            dt = dt.AddMinutes(num);
            break;
          case "s":
            dt = dt.AddSeconds(num);
            break;
          case "h":
            dt = dt.AddHours(num);
            break;
          case "d":
            dt = dt.AddDays(num);
            break;
          case "y":
            dt = dt.AddYears(num);
            break;
        }
      }
      Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss"));
    }
  }
}
// It works on Linux!