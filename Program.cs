Console.Write("Введите массив: ");
string[] array = Console.ReadLine()!.Split(',');
string[] cutTheArray(string[] input, int cutNumber)
{
    string temp = "";    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i].Trim(' ');
        if (array[i].Length <= cutNumber)
            {
                if (temp.Length != 0)
                    temp += ",";
                temp += array[i];
            }
    }
    string[] arr = temp.Split(',');
    return arr;
}
Console.WriteLine($"[{string.Join(',', array)}] → [{string.Join(',', cutTheArray(array, 3))}]");