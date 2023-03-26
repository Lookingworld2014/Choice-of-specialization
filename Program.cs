//Программа, которая из имеющегося массива строк формирует массив строк, длина которых меньше, либо равна 3 символа.



string[] arr = GetArray();
PrintArray(arr);
string[] remakeArr = RemakeArray(arr);
PrintRemake(remakeArr);

string[] GetArray()
{
    string[] arr = new string[5]; 
    arr[0] = "she";
    arr[1] = "he";
    arr[2] = "snake";
    arr[3] = "bear";
    arr[4] = "cat";
    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
}

string[] RemakeArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) 
            count++;
    }
    string[] remakeArr = new string[count]; 
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            remakeArr[j] = arr[i]; 
            j++;
        }
    }
    return remakeArr;
}

void PrintRemake(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
}