// 8.Показать четные числа от 1 до N
int n=2;
int N=new Random().Next(4, 30);
Console.WriteLine("N = "+N);
Console.WriteLine("Четные числа от 1 до N : ");
while (n<=N)
{
    Console.Write(n+"; ");
    n=n+2;
}


