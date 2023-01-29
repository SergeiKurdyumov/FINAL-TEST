 string[] Array(string[] num)
{
    var result = new string[num .Length];
    var index = 0;
    foreach (var str in num )
    {
        if (str.Length <= 3)
        {
            result[index] = str;
            index++;
        }
    }
    return result;
}

void ShowArray (string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {        
        Console.Write($"{arr[i]} ");    
    }
}

string[] array = {"hellow", "world", "123", "GB", "2"};
string[] NewMassiv = Array(array);
ShowArray(NewMassiv);