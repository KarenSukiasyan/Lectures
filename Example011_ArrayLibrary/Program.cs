void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index =0;
while (index < Length)
    {
        collection[index] = new Random().Next(1,10);
        // index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] colletion, int find)
{
    int count = colletion.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(colletion[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
