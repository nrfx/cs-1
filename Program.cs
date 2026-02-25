
Console.Write("введите три числа по очереди \n");

string a_str = Console.ReadLine();
string b_str = Console.ReadLine();
string c_str = Console.ReadLine();

int a = Convert.ToInt32(a_str);
int b = Convert.ToInt32(b_str);
int c = Convert.ToInt32(c_str);


int res = 0;

if (a > b && a > c)
{
    res = b * c;
}
else if (b > a && b > c)
{
    res = a * c;
}
else
{
    res = a * b;
}

Console.WriteLine($"Числа: {a} {b} {c}");
Console.WriteLine($"результат: {res}");