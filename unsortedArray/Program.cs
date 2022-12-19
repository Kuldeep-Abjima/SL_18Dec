// See https://aka.ms/new-console-template for more information
int[] a = { 1, 2, 3, 5, 3, 6, 7, 1, 3, 10 };
int n = a.Length;

Array.Sort(a);
int j = 0;

for (int i = 0; i < n - 1; i++)
{
    if (a[i] != a[i + 1])
    {
        a[j++] = a[i];
    }
}
a[j++] = a[n - 1];

for (int i = 0; i < j; i++)
{
    Console.WriteLine(a[i]);
}