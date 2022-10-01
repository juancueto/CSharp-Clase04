// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Ejercicio 1
Console.WriteLine("Ingrese un numero entero:");
int numero = int.Parse(Console.ReadLine());
int multiplicador = 1;
while(multiplicador <= 10)
{
    Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");
    multiplicador++;
}

// Ejercicio 2

string texto = "";
do
{
    Console.WriteLine("Ingrese un numero:");
    texto = Console.ReadLine();
    int numero2 = 0;
    if (int.TryParse(texto, out numero2))
    {
        if (numero2 > 0)
            Console.WriteLine("Es positivo");
        else if (numero2 == 0)
            Console.WriteLine("Es cero");
        else
            Console.WriteLine("Es negativo");
    }
    else
    {
        Console.WriteLine("Numero no valido. Fin.");
    }
}
while (texto != "");

// Ejercicio 3

Console.WriteLine("Ingrese el ancho:");
int ancho = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el alto:");
int alto = int.Parse(Console.ReadLine());
Console.WriteLine("Relleno?:");
bool esRelleno = bool.Parse(Console.ReadLine());

for (int q = 0; q < alto; q++)
{
    if (esRelleno)
    {
        for (int i = 0; i < ancho; i++)
        {
            Console.Write("*");
        }
    }
    else
    {
        if (q == 0 || q == alto - 1)
        {
            for (int i = 0; i < ancho; i++)
            {
                Console.Write("*");
            }
        }
        else
        {
            Console.Write("*");
            for (int i = 1; i < ancho - 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
        }

    }

    Console.Write("\n");
}

//Reto:

Console.WriteLine("Ingrese el ancho:");
int ancho2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el alto:");
int alto2 = int.Parse(Console.ReadLine());


Console.WriteLine("Ingrese el numero de divisiones:");
int divisiones = int.Parse(Console.ReadLine());

Console.WriteLine("Relleno?:");
bool esRelleno2 = bool.Parse(Console.ReadLine());

for (int q = 0; q < alto2; q++)
{
    for(int j = 0; j < divisiones; j++)
    {
        if (esRelleno2)
        {
            for (int i = 0; i < ancho2; i++)
            {
                Console.Write("*");
            }
        }
        else
        {
            if (q == 0 || q == alto2 - 1)
            {
                for (int i = 0; i < ancho2; i++)
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.Write("*");
                for (int i = 1; i < ancho2 - 1; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
            }

        }

        Console.Write(" ");
    
    }

    Console.Write("\n");
}





