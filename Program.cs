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
System.Console.WriteLine("Ingrese otra frase: ");
string cadena2= Console.ReadLine() ?? "";
string fraseConcat= $"{cadena} {cadena2}";
System.Console.WriteLine("Frase concatenada: "+fraseConcat);

System.Console.WriteLine("Ingrese la posicion a cortar de la frase 1:");
int eliminar;
string ?borr;
borr=Console.ReadLine();
if (int.TryParse(borr, out eliminar))
{
    if (eliminar < longitud)
    {
        string resultado=cadena.Substring(eliminar);
        System.Console.WriteLine("Frase extraida  es:"+ resultado);
    }else
    {
        System.Console.WriteLine("Error...no se encontro la posicion");
    }
    
}else
{
    System.Console.WriteLine("Error...ingrese un numero");
}
//ejercicio 4 final
Console.WriteLine("Ingrese la frase a analizar:");
string frase= Console.ReadLine() ?? "";
foreach (char letra in frase)
{
    System.Console.WriteLine($"Letra:{letra}");
}
//buscar ocurrencia
System.Console.WriteLine("Ingrese la palabra a buscar: ");
string palabraBuscar= Console.ReadLine() ?? "";
int posicion=frase.IndexOf(palabraBuscar);
if (posicion != -1)
{
    System.Console.WriteLine($"Palabra esta en el indice {posicion}");
}else
{
    System.Console.WriteLine("La palabra no se encontro en la cadena");
}

//separar cadena
System.Console.WriteLine("Ingrese el catalago separadas con ',': ");
string entrada=Console.ReadLine()?? "";

string[]resultados =entrada.Split(',');

System.Console.WriteLine("----Resultados de la division---");
foreach (string elemento in resultados)
{
    System.Console.WriteLine($"Elemento:{elemento.Trim()}");
}