
Console.Write("введите три числа по очереди \n");

string a_str = Console.ReadLine();
string b_str = Console.ReadLine();
string c_str = Console.ReadLine();

int a = Convert.ToInt32(a_str);
int b = Convert.ToInt32(b_str);
int c = Convert.ToInt32(c_str);

Console.WriteLine($"Числа: {a} {b} {c}");

if (a > b && a > c)
{
    int res = b * c;
    Console.WriteLine($"результат: {res}");
}
else if (b > a && b > c)
{
    int res = a * c;
    Console.WriteLine(res);
}
else
{
    int res = a * b;
    Console.WriteLine(res);
}
