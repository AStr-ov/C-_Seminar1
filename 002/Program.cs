//2.Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число");
int n=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m=int.Parse(Console.ReadLine());
if (n>m)
{
    Console.WriteLine("Число "+n+" больше числа "+m);
}
else
{
    Console.WriteLine("Число "+n+" меньше числа "+m);
}