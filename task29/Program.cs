string number = Console.ReadLine();
Console.Write(number.Length);
string[] array = new string[number.Length];
int index = 0;
for (int i = 0; i<=number.Length; i++)
{
    if (number[i] != ',')
    {
    array[index] += number[i].ToString();
}
    else
{
    index++;
}
}
Console.Write("[ ");
for (int i = 0; i <= index - 1; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write(array[index] + "]");
