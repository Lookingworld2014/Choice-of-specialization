//Программа, которая из имеющегося массива строк формирует массив строк, длина которых меньше, либо равна 3 символа.



int[] arr = GetArray();

PrintArray(arr);

RemakeArray(arr);

PrintRemake(arr);

int[] GetArray()
{
    int[] arr = new int[3];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 10000);

    }
    return arr;

}

void PrintArray(int[] arr)

{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }


}

int [] RemakeArray(int[] arr)
{
    
arr = new int [3];

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] < 3)
    count++;

}
return arr;
}

void PrintRemake(int[]arr)

{
for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine();
        Console.WriteLine(arr[i] + " ");
    }

}