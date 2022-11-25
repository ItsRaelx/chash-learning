# Chash-Learning
Proste przykłady kodu c#

Proste (zoptymalizowane) szukanie liczb pierwszych na podstawie sprawdzania dzielenia kolejnych liczb przez poprzednią liczbę pierwszą.

```
double[] nbrs = { 2 };
int n = 2;
bool isPrime;

while(n <= 500)
{
    isPrime = true;
    for(int i = 0; i < nbrs.Length; i++ )
    {
        double temp = nbrs[i];
        if( n % temp == 0 )
        {
            isPrime = false;
        }
    }
    if(isPrime){
        Console.Write(n + " ");
        nbrs = nbrs.Append(n).ToArray();
    }

    n++;
}
```

Regex is the best thing! I can easily separate text from numbers.

```
// Delete numbers from string
string type = Regex.Replace(str, @"[0-9\+\-]", "");

// Get only numbers from string
int num = int.Parse(Regex.Replace(str, "[^0-9+-]", ""));
```

Operacje na plikach:
```
string text = File.ReadAllText("./data.csv"); // Load
Console.WriteLine(text); // Display
File.WriteAllText("./output.csv", text); // Save
```

Rozdzielenie stringu na 2 tabele:
```
string[] lines = File.ReadAllLines("./data.csv");

double[] I = new double[lines.Length];
double[] V = new double[lines.Length];

// Do a loop and parse data.csv into I and V
for (int i = 1; i < lines.Length; i++)
{
  temp = lines[i].Split(',');
  I[i] = double.Parse(temp[0]);
  V[i] = double.Parse(temp[1]);
}
```