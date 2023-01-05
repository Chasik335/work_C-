// See https://aka.ms/new-console-template for more information

int[] arr = { 54, 32, 6 };
int index = 0;
int max = 0;
while (index < arr.Length - 1)
{
    if (arr[index] > max)
    {
        max = arr[index];
    }
index = index + 1;
}
Console.WriteLine("Максимум -> " + max);
