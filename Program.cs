Console.Write("Введите массив: ");
string[] array = Console.ReadLine()!.Split(',');
string[] cutTheArray(string[] input, int cutNumber)
{
    string temp = "";    
    for (int i = 0; i < input.Length; i++)
    {
        input[i] = input[i].Trim(' ');
        if (input[i].Length <= cutNumber && input[i] != "")
                temp += input[i] + ',';
    } 
    temp = temp.Remove(temp.Length-1);
    string[] arr = temp.Split(',');
    Console.WriteLine(temp);
    return arr;
}
Console.WriteLine($"[{string.Join(",", array)}] → [{string.Join(", ", cutTheArray(array, 3))}]");