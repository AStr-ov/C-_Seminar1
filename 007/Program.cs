//Показать числа от -N до N

int n=new Random().Next(0, 20);
int m=-n;
while (m<=n)
{
   Console.WriteLine(m);
   m++; 
}

//Console.WriteLine(-n );
//Console.WriteLine(n);
