// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] arr)  
{
    int count = arr.Length;
    for (int i = 0; i <= count; i++)
    {
       System.Console.Write($"{arr[i]}"+" "); 
    }
}

int[] GetArray(int size, int leftRange, int rightRange) 
{
    int[] arrN = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrN[i] = new Random().Next(leftRange, rightRange); 
    }
    return arrN;
}
int[] myArray = GetArray(8, 3, 100); 
PrintArray(myArray); 