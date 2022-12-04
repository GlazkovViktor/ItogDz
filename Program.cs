string[] arr;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
arr = stroka.Split(' ');
string[] arr1 = new string[arr.Length];
void Find(string[] arr, string[] arr1)
{
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr1[k] = arr[i];
            k++;
        }
    }
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    
}

