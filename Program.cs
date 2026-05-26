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

float valorAbs,cuadrado,raiz=0;
float m;
int entero;
string ?num;
Console.WriteLine("Ingrese un numero:");
num=Console.ReadLine();
if (float.TryParse(num, out m))
{
    //valor absoluto
    if (m>=0)
    {
        valorAbs=m;
    }else
    {
        valorAbs=m*(-1);
    }
    //cuadrado
    cuadrado=m*m;
    //raiz cuadrada
    if (m >= 0)
    {
        raiz = m;

        for (int i = 0; i < 10; i++)
        {
            raiz = (raiz + m / raiz) / 2;
        }
    }
    //seno
    float y=m*3.141592f/180f;
    float seno=y-(y*y*y)/6 + (y*y*y*y)/120;
    //coseno
    float coseno=1-(y*y)/2+(y*y*y*y)/24;
    //parte entera
    entero=(int)m;
    //mostrar
    Console.WriteLine("Valor absoluto: "+ valorAbs);
    Console.WriteLine("El cuadrado: "+cuadrado);
    Console.WriteLine("Raiz cuadrada: " + raiz);
    Console.WriteLine("Seno: "+ seno);
    Console.WriteLine("Coseno: "+ coseno);
    Console.WriteLine("Parte entera: "+ entero);

}
    else{

    Console.WriteLine("Numero invalido..");
}

//maximos y minimos
int num1,num2;
int max,min;
Console.WriteLine("Ingrese el primer numero: ");
if (!int.TryParse(Console.ReadLine(),out num1))
{
    Console.WriteLine("Error, ingrese el numero nuevamente");
}
Console.WriteLine("Ingrese el segundo numero: ");
if (!int.TryParse(Console.ReadLine(),out num2))
{
    Console.WriteLine("Error, ingrese el numero nuevamente");
    
}

if (num1>num2)
{
    max=num1;
    min=num2;
}else
{
    max=num2;
    min=num1;
}

Console.WriteLine("El maximo numero es: "+ max);
Console.WriteLine("EL minimo numero es: "+min);