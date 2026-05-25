bool bandera = true;
do
{
    Console.WriteLine("Calculadora V2: ");
    Console.Write("Ingrese un numero: ");
    string numero = Console.ReadLine();
    if (double.TryParse(numero,out double num))
    {
        Console.WriteLine("El numero ingresado es valido");
        Console.WriteLine($"El valor absoluto del numero es: {Math.Abs(num)}");
        Console.WriteLine($"El cuadrado del numero es: {Math.Pow(num, 2)}");
        Console.WriteLine($"La raiz cuadrada del numero es: {Math.Sqrt(num)}");
        Console.WriteLine($"El Seno del numero es: {Math.Sin(num)}");
        Console.WriteLine($"El Coseno del numero es: {Math.Cos(num)}");
        Console.WriteLine($"La parte entera del numero float es: {(int)num}");
    }
    else
    {
        Console.WriteLine("El numero ingresado no es valido");
    }
    
    Console.WriteLine("-----------------\n");
    Console.WriteLine("Calculadora V1: ");
    Console.WriteLine("Seleccione la operacion que quiere realizar: ");
    Console.WriteLine("Sumar");
    Console.WriteLine("Restar");
    Console.WriteLine("Multiplicar");
    Console.WriteLine("Dividir");
    string opcion = Console.ReadLine();
    Console.WriteLine("----------------------------------------");
    Console.Write("Ingrese el primer numero: ");
    string numero1 = Console.ReadLine();
    if (double.TryParse(numero1,out double num1))
    {
        Console.WriteLine("El primer numero ingresado es valido");
        Console.Write("Ingrese el segundo numero: ");
        string numero2 = Console.ReadLine();
        if (double.TryParse(numero2,out double num2))
        {
            Console.WriteLine("El segundo numero ingresado es valido");
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
            /*double maximo = Math.Max(num1,num2);
            double minimo = Math.Min(num1,num2);
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"El número máximo es: {maximo}");
            Console.WriteLine($"El número mínimo es: {minimo}");*/
            if(num1 > num2)
            {
                Console.WriteLine($"El numero {num1} es el maximo entre {num1} y {num2}");
                Console.WriteLine($"El numero {num2} es el minimo entre {num1} y {num2}");
            }
            else if(num2 > num1)
            {
                Console.WriteLine($"El numero {num2} es el maximo entre {num1} y {num2}");
                Console.WriteLine($"El numero {num1} es el minimo entre {num1} y {num2}");
            }
            else
            {
                Console.WriteLine($"No hay maximo ni minimo entre {num1} y {num2} ya que son iguales");
            }
        }
        else
        {
            Console.Write("El segundo numero ingresado no es valido");
        }
    }
    else
    {
        Console.Write("El primer numero ingresado no es valido");
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