Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

// ----Invertir Numero
Console.Write("Por favor, ingresa un número entero: ");
string numeroIngresado = Console.ReadLine();
if (int.TryParse(numeroIngresado, out int numeroOriginal))
{
    if(numeroOriginal>0){
        int aux = numeroOriginal, UltDig, numeroInvertido = 0;
        while (aux > 0)
        {
            UltDig = aux % 10;
            numeroInvertido = numeroInvertido*10 + UltDig;
            aux = aux / 10;
        }
        Console.WriteLine($"El número invertido es: {numeroInvertido}");
    }
    else
    {
        Console.WriteLine($"El número ingresado no es mayor a cero");
    }
}
else
{
    Console.WriteLine("Error: Lo que ingresaste NO es un número válido.");
}