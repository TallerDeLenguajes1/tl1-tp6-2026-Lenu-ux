// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

int n;
int n2;
Console.WriteLine("Ingrese un numero");
string ?c;
c=Console.ReadLine();
//control uso Tryparse
if (int.TryParse(c, out n))
{
    Console.WriteLine("convertido: "+n);
}else
{
    Console.WriteLine("Entrada no valida...Ingrese un numero");
}
if (n>0)
{
    int aux=n%10;
    n2=n/10;
    Console.WriteLine(aux);
    Console.WriteLine(n2);
}
   
