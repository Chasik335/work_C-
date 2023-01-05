// See https://aka.ms/new-console-template for more information

int N = 10;
int[] arr = new int[N + 1];
int index = 0;
while (index < N + 1)
{
    if (index % 2 == 0)
    {
        arr[index] = index;
        Console.WriteLine("Четное -> " +arr[index]);
    }
index = index +1;
}

