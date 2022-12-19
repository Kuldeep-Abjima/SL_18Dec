// See https://aka.ms/new-console-template for more information
int[] a = {1,2,2,3,3,3,4,5,6,6,7};
int n = a.Length;
int j = 0;

for(int i =0; i < n-1; i++)
{
    if (a[i] != a[i + 1])
    {
        a[j++] = a[i];
    }
}
a[j++] = a[n - 1];

for(int i = 0; i < j; i++)
{
    Console.WriteLine(a[i]);
}
