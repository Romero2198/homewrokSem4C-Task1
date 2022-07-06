Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 0;
int c = 1;
while (count < b)
{
    c = c * a;
    count++;
}
Console.WriteLine($"{a}, {b} -> {c}");