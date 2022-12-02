using System;
using System.Text.RegularExpressions;

Console.Write("Enter a string: ");
string text = Console.ReadLine();

Regex letter = new Regex("[a-z]+", RegexOptions.Compiled | RegexOptions.IgnoreCase);
Regex number = new Regex("[0-9-]+", RegexOptions.Compiled | RegexOptions.IgnoreCase);

Match matchNumber = number.Match(text);
Console.WriteLine($"value:{matchNumber.Value} position:{matchNumber.Index}");

Match matchLetter = letter.Match(text);
Console.WriteLine($"value:{matchLetter.Value} position:{matchLetter.Index}");