// Console.WriteLine("Guantanamera!");


// Console.Write("Jak się nazwywasz? ");
// string name = Console.ReadLine();

// Console.WriteLine("Witaj " + name + "!");


// double tax = 0.18;

// Console.Write("Ile zł byś chciał zarabiać? ");
// double pay = double.Parse(Console.ReadLine());

// pay = pay * (1 - tax);
// Console.WriteLine("Niestety po odprowadzeniu podatku zostanie ci " + pay + " zł");


// Przebieg Funkcji A

// double x=0;
// double y;

// if(x < -2)
// {
//   y = -0.5 * x - 3;
// }
// else if(x < 1)
// {
//   y = ((double)4 / 3) * x + ((double)2 / 3);
// }
// else
// {
//   y = 2;
// }

// Przebieg funkcji B

double x=-6;
double y=0;

if(x < -5)
{
y = 0.5 * x + 0.5;
}
else if(x < -2)
{
y = (1.44 * x * x) + (10 * x) + 16;
}
else if (x < 0)
{
y = Math.Sqrt(4 - x * x);
}
else if (x < 3)
{
y = 2;
}
else
{
y = -(3 / 4) * x + 4.25;
}
Console.WriteLine("X:" + x + " -> Y: " + y);