Console.WriteLine("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (Number > 0)
{
    sum = sum + Number % 10;
    Number = Number / 10;
}

Console.WriteLine(sum);