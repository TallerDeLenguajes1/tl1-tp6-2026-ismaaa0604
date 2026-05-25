/*Console.WriteLine("Hello, World!");
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
}*/
//1
Console.Write("Ingrese una cadena: ");
string cadena = Console.ReadLine();
int longitud = cadena.Length;
Console.WriteLine($"La longitud de la cadena {cadena} es {longitud}");
//2
Console.Write("Ingrese otra cadena: ");
string cadena2 = Console.ReadLine();
string concat = $"{cadena} {cadena2}";
Console.WriteLine(concat);
//3
string subcadena = concat.Substring(6);
Console.WriteLine(subcadena);
//5
string miTexto = Console.ReadLine();
Console.WriteLine($"Cadena original: {miTexto}\n");
Console.WriteLine("Mostrando elemento por elemento:");
foreach (char letra in miTexto)
{
    Console.WriteLine(letra);
}
//6
Console.Write("Ingrese un texto o frase: ");
string textoCompleto = Console.ReadLine();
Console.Write("Ingrese la palabra que desea buscar: ");
string palabraBuscada = Console.ReadLine();
int posicion = textoCompleto.IndexOf(palabraBuscada);
Console.WriteLine("\n--- Resultados de la búsqueda ---");
Console.WriteLine($"Su primera ocurrencia comienza en la posición (índice): {posicion}");
//7
Console.WriteLine("=== 1. MAYÚSCULAS Y MINÚSCULAS ===");
Console.Write("Ingrese una cadena de texto: ");
string texto = Console.ReadLine();
string textoMayusculas = texto.ToUpper();
string textoMinusculas = texto.ToLower();
Console.WriteLine($"En mayúsculas: {textoMayusculas}");
Console.WriteLine($"En minúsculas: {textoMinusculas}");
//8
Console.WriteLine("\n=== 2. USO DEL MÉTODO SPLIT() ===");
        // Pedimos una cadena separada por un carácter específico (ej. un guion o una coma)
        Console.WriteLine("Ingrese palabras separadas por un guion '-' (ejemplo: rojo-verde-azul): ");
        string textoConSeparadores = Console.ReadLine();

        // El método Split() corta la cadena cada vez que encuentra el carácter indicado
        // y devuelve un arreglo (array) de strings (string[])
        string[] elementos = textoConSeparadores.Split('-');

        Console.WriteLine("Los elementos extraídos son:");
        foreach (string elemento in elementos)
        {
            Console.WriteLine($"- {elemento.Trim()}"); // .Trim() limpia espacios en blanco por si el usuario los puso
        }


        Console.WriteLine("\n=== 3. CALCULADORA POR CADENA DE CARACTERES ===");
        Console.Write("Ingrese una ecuación matemática simple (ej. 582+2 o 10*5): ");
        string ecuacion = Console.ReadLine();

        // Definimos los operadores matemáticos válidos que vamos a buscar
        char[] operadores = { '+', '-', '*', '/' };

        // Buscamos la posición (índice) donde se encuentra alguno de esos operadores
        int indiceOperador = ecuacion.IndexOfAny(operadores);

        // Si IndexOfAny devuelve -1, significa que no encontró ningún operador válido
        if (indiceOperador != -1)
        {
            // Guardamos cuál fue el operador exacto que el usuario escribió
            char operador = ecuacion[indiceOperador];

            // Extraemos la parte izquierda de la ecuación (antes del operador)
            string strNum1 = ecuacion.Substring(0, indiceOperador);
            
            // Extraemos la parte derecha de la ecuación (después del operador)
            string strNum2 = ecuacion.Substring(indiceOperador + 1);

            // Convertimos esos textos extraídos a números reales
            double num1 = double.Parse(strNum1);
            double num2 = double.Parse(strNum2);
            double resultado = 0;

            // Evaluamos el operador para hacer la cuenta correcta
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    break;
            }

            Console.WriteLine($"El resultado de la operación {ecuacion} es: {resultado}");
        }
        else
        {
            Console.WriteLine("No se detectó una ecuación válida. Asegúrese de usar +, -, * o /.");
        }