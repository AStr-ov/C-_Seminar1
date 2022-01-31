//4.Найти максимальное из трех чисел
int a=new Random().Next(-1000, 1000);
int b=new Random().Next(-1000, 1000);
int c=new Random().Next(-1000, 1000);
Console.WriteLine(a+" , "+b+" , "+c);
int max=a;
if (b>max)
{
   max=b;
}
if (c>max)
{
   max=c;
}
Console.WriteLine("Максимальное число: "+max);