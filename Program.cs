Console.Write("Введите массив: ");
string[] array = Console.ReadLine()!.Split(',');
string[] cutTheArray(string[] input, int cutNumber)
{
    string temp = "";    
    for (int i = 0; i < input.Length; i++)
    {
        input[i] = input[i].Trim(' ');
        if (input[i].Length <= cutNumber)
            {
                if (temp.Length != 0)
                    temp += ",";
                temp += input[i];
            }
    }
    string[] arr = temp.Split(',');
    return arr;
}
Console.WriteLine($"[{string.Join(",", array)}] → [{string.Join(", ", cutTheArray(array, 3))}]");