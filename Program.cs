// double[] nbrs = { 2 };
// int n = (int)nbrs[0];
// bool isPrime;

// while(n <= 10000)
// {
//     isPrime = true;
//     for(int i = 0; i < nbrs.Length; i++ )
//     {
//         double temp = nbrs[i];
//         if( n % temp == 0 )
//         {
//             isPrime = false;
//         }
//     }
//     if(isPrime){
//         Console.Write(n + " ");
//         nbrs = nbrs.Append(n).ToArray();
//     }

//     n++;
// }

Console.WriteLine("Podaj wielkość tablicy:");
int n = int.Parse(Console.ReadLine());
double[] nbrs = new double[n];

for(int i = 0; i < nbrs.Length; i++)
{
    Random rnd = new Random();
    nbrs[i] = rnd.Next(0, 99);
}

for(int i = 0; i < nbrs.Length - 1; i++)
{
    for(int j = 0; j < nbrs.Length - 1; j++)
    {
        double now = nbrs[i];
        double jNext = nbrs[j + 1];
        if(now > jNext)
        {
            nbrs[j] = jNext;
            nbrs[j + 1] = now;
        }
    }
}

foreach(double x in nbrs)
  Console.Write(x + " ");


// using System;

// namespace App
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//             double y = double.Parse(args[0]);
//             string mode = args[1];
//             double[] array = new double[args.Length - 2];
//             for(int i = 0; i < args.Length - 2; i++)
//             {
//                 array[i] = double.Parse(args[i + 2]);
//             }

//     }
//   }
// }