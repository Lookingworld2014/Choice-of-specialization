//Программа, которая из имеющегося массива строк формирует массив строк, длина которых меньше, либо равна 3 символа.



int [] arr = GetArray();

int[] GetArray()
{
    int[] arr = new int[3];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(1, 10);
    return arr;

    Console.WriteLine(arr);

}

