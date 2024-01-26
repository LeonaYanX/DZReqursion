//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.

int[] GetRandomArray()
{
    Random random = new Random();
    int[] array = new int[random.Next(1 ,10)];
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = random.Next(0,101);
    }
    return array;
}
void PrintArrayVS(int[] array, int size)
{
    if (size-1 < 0) 
    {
        Console.WriteLine();
        return;
    }
    Console.Write(array[size-1] + " ");
    PrintArrayVS(array,size-1);
}
void PrintArray(int[] array)
{
   for (int i = 0;i < array.Length;i++) 
    {
        Console.Write(array[i]+ " ");
    }
}


int[] myArray = GetRandomArray();
PrintArray(myArray);
Console.WriteLine();
PrintArrayVS(myArray, myArray.Length);
Console.ReadLine();
