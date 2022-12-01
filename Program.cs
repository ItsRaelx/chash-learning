using System;
using System.IO;

// string text = File.ReadAllText("./data.csv");
// Console.WriteLine(text);
// File.WriteAllText("./output.csv", text);

// string[] lines = File.ReadAllLines("./data.csv");
// foreach (string line in lines) 
// {
//   Console.WriteLine(line);
//   Console.WriteLine("----");
// }
// File.WriteAllLines("./output.csv", lines);

string[] lines = File.ReadAllLines("./data.csv");

double[] I = new double[lines.Length];
double[] V = new double[lines.Length];
double[] T = new double[lines.Length];
double[] P = new double[lines.Length];
string[] temp = new string[2];

// Do a loop and parse data.csv into I and V
for (int i = 1; i < lines.Length; i++)
{
  temp = lines[i].Split(',');
  I[i] = double.Parse(temp[0]);
  V[i] = double.Parse(temp[1]);
}

// Genetate T (time) each is 2 ms apart
for (int i = 0; i < lines.Length; i++)
{
  T[i] = Math.Round(i * 0.002, 3);
}

// Calculate P and round to 3 decimal places
for(int i = 0; i < lines.Length; i++)
{
  P[i] = Math.Round(I[i] * V[i], 3);
}

string output = "Time (s);Current (10A);Voltage (V);Power (10W)\r\n";

for(int i = 1; i < lines.Length; i++)
  output += T[i-1] + ";" + I[i] + ";" + V[i] + ";" +  P[i] + "\r\n";

// output = output.Replace(",", ".");
// output = output.Replace(";", ",");

File.WriteAllText("./output.csv", output);

// Done!