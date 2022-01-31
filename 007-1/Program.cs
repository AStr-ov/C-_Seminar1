// 7.//Показать числа от -N до N
int n=new Random().Next(1, 20);
int m=-n;
while (m<=n)
{
    Console.Write(m+"; ");
    m++;
}