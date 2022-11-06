# Chash-Learning
Proste przykłady kodu c#

Proste (zoptymalizowane) szukanie liczb pierwszych na podstawie sprawdzania dzielenia kolejnych liczb przez poprzednią liczbę pierwszą.

```double[] nbrs = { 2 };
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
}```
