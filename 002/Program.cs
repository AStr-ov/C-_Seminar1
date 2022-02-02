//2.Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число");
double n=double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
double m=double.Parse(Console.ReadLine());
if (n>m)
{
    Console.WriteLine("Число "+n+" больше числа "+m);
}
else
{
    Console.WriteLine("Число "+n+" меньше числа "+m);
}