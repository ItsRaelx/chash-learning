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

// if(x <= -2)
// {
//   y = -0.5 * x - 3;
// }
// else if(x <= 1)
// {
//   y = ((double)4 / 3) * x + ((double)2 / 3);
// }
// else
// {
//   y = 2;
// }

// Przebieg funkcji B

// double x=-5;
// double y=0;

// if(x <= -5)
// {
//     y = 0.5 * x + 0.5;
// }
// else if(x <= -2)
// {
//     y = (1.44 * x * x) + (10 * x) + 16;
// }
// else if (x <= 0)
// {
//     y = Math.Sqrt(4 - x * x);
// }
// else if (x <= 3)
// {
//     y = 2;
// }
// else
// {
//     y = -((double)3 / 4) * x + 4.25;
// }
// Console.WriteLine("X:" + x + " -> Y: " + y);

// Przebieg funkcij C

// double x=2;
// double y=0;

// if (x <= -4 || x >= 2)
// {
//     y = (-((double)1 / 3) * x) + ((double)2 / 3);
// }
// else
// {
//     y = ((double)1 / 3) * (x + 3) * (x - 2);
// }

// Console.WriteLine("X:" + x + " -> Y: " + y);

// Przebieg funkcji D

// int number = 2;
// bool isPrime;
// while(number <= 100)
// {
//     isPrime = true;
//     for(int i = 2; i < number; i++ )
//     {
//         if(number % i == 0)
//         {
//             isPrime = false;
//         }
//     }
//     if(isPrime){
//         Console.Write(number + " ");
//     }

//     number++;
// }


// double[] nbrs = { 12, 45, 56.5, 8, 94 };

// foreach(double x in nbrs)
//   Console.Write(x + " ");

// Console.Write("Length: ");
// int n = int.Parse(Console.ReadLine());

// double[] array = new double[n];

// for(int i = 0; i < n; i++)
// {
//   Console.Write("Element[" + i + "]: ");
//   array[i] = double.Parse(Console.ReadLine());
// }

// Console.Write("Operation: ");
// char o = char.Parse(Console.ReadLine());

// foreach(double x in n)
//   Console.Write(x + " ");

// switch(option)
// {
//   case "+": x = x + y; break;
//   case "-": x = x - y; break;
//   case "*": x = x * y; break;
//   case "/": x = x / y; break;
//   default:
//     Console.WriteLine("Nieobsługiwana operacja!");
//     return;
// }

// DOKOŃCZYĆ

// Zadanie 5
// Musimy podać pierwszą liczbę pierwszą

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