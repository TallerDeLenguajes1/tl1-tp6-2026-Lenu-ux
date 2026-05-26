Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

int n;
int n2;
int numInvert = 0;
Console.WriteLine("Ingrese un numero");
string ?c;
c=Console.ReadLine();
//control uso Tryparse
if (int.TryParse(c, out n))
{
    Console.WriteLine("convertido: "+n);
    if (n > 0)
    {
        while( n > 0)
            {
                int aux = n % 10;
                n2 = n / 10;
                numInvert = numInvert * 10 + aux;  
                n=n2;
            }

           
            Console.WriteLine(numInvert);

    } else
    {
        Console.WriteLine("Entrada no valida...Ingrese un numero mayor a cero");

    }
}else
{
    Console.WriteLine("Entrada no valida...Ingrese un numero");
}

//ejercicio 4
Console.WriteLine("Ingrese la frase:");
string cadena=Console.ReadLine() ?? "";
int longitud= cadena.Length;
Console.WriteLine($"La longitud es {longitud}");