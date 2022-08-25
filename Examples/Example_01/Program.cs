// Написать программу копирования массива

void CopyArray(int[] array, int[] newArray)
{
    for (int i = 0; i < array.Length; i++) 
    {
        newArray[i] = array[i];
    }
}
void PrintArray(int[] array)
{
        foreach (var element in array) Console.Write($"{element} "); 
        Console.WriteLine();
}

Console.Clear();
int[] array = {10, -54, 0, 489, -2, 86, 1};
PrintArray(array);

int[] newArray = new int[array.Length];
CopyArray(array, newArray);
PrintArray(newArray);
