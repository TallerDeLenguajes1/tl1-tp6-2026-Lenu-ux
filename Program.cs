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
//ejercicio 2
string ? opcion;
           
    do
        {
            Console.WriteLine("Seleccione la operacion a realizar:");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicacion");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Salir");
            int resultado = 0;
            Console.WriteLine("Ingrese su eleccion:");
            opcion=Console.ReadLine();
            if (int.TryParse(opcion, out n))
            {
                if (n != 5)
                {
                     Console.WriteLine("Ingrese el primer numero:");
            string ?N1;
            N1=Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero:");
            string ?N2;
            N2=Console.ReadLine();
            

            if (int.TryParse(N1,out a) && int.TryParse(N2,out b))
            {
                switch (n)
            {
                case 1:
                        resultado=a+b;
            Console.WriteLine("Resultado :"+ resultado);
                        break;
                case 2:
                        resultado=a-b;
            Console.WriteLine("Resultado :"+ resultado);

                        break;
                case 3:
                        resultado=a*b;
            Console.WriteLine("Resultado :"+ resultado);

                        break;
                case 4:
                        resultado=a/b;
            Console.WriteLine("Resultado :"+ resultado);

                        break;
                default:
                break;


            }
                } else
                {
                    Console.WriteLine("Entrada no valida...Ingrese un numero");
                }
            }
           
            }else
            {
                Console.WriteLine("Entrada no valida...Ingrese un numero");
    
            }

        } while (n !=5);

//ejercicio 3
        