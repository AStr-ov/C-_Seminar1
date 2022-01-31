//1.По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число");
int n= int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m=int.Parse(Console.ReadLine());
if (n==m*m)
{
    Console.WriteLine("Число "+n+" является квдратом числа "+m);
}
else
{
    Console.WriteLine("Число "+n+"  не является квдратом числа "+m);
}