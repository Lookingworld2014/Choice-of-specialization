//Программа, которая из имеющегося массива строк формирует массив строк, длина которых меньше, либо равна 3 символа.



int[] arr = GetArray();

PrintArray(arr);

RemakeArray(arr);

int[] array = PrintRemake();

int[] GetArray()
{
    int[] arr = new int[3];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);

    }
    return arr;

}

void PrintArray(int[] arr)

{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }


}

int [] RemakeArray(int[] arr)
{
    
array = new int [3];

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(array[i] < 3)
    count++;

}
return array;
}

void PrintRemake(int[]array)

{
for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }

}