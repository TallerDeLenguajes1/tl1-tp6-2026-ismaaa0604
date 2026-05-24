bool bandera = true;
do
{
    Console.WriteLine("Calculadora V1: ");
    Console.WriteLine("Seleccione la operacion que quiere realizar: ");
    Console.WriteLine("Sumar");
    Console.WriteLine("Restar");
    Console.WriteLine("Multiplicar");
    Console.WriteLine("Dividir");
    string opcion = Console.ReadLine();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Ingrese el primer numero: ");
    string numero1 = Console.ReadLine();
    if (int.TryParse(numero1,out int num1))
    {
        Console.WriteLine("El primer numero ingresado es valido");
    }
    else
    {
        Console.WriteLine("El primer numero ingresado no es valido");
    }
    Console.WriteLine("Ingrese el primer numero: ");
    string numero2 = Console.ReadLine();
    if (int.TryParse(numero2,out int num2))
    {
        Console.WriteLine("El segundo numero ingresado es valido");
    }
    else
    {
        Console.WriteLine("El segundo numero ingresado no es valido");
    }
    switch (opcion)
    {
        case "Sumar":
            Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
            break;
        case "Restar":
            Console.WriteLine($"El resultado de la resta es: {num1-num2}");
            break;
        case "Multiplicar":
            Console.WriteLine($"El resultado de la multiplicacion es: {num1*num2}");
            break;
        case "Dividir":
            if(num2 != 0){
                Console.WriteLine($"El resultado de la division es: {num1/num2}");
            }
            else
            {
                Console.WriteLine("No se puede realizar la division sobre cero");
            }
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione una de las 4 opciones permitidas.");
            break;
    }
    Console.WriteLine("-----------------\n");
    Console.Write("Desea continuar (1 si /0 no): ");
    string continuar = Console.ReadLine();
    if(continuar != "1")
    {
        bandera = false;
    }
}while(bandera);
Console.Write("Muchas gracias");