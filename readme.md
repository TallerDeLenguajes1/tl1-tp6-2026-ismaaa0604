
### 1. ¿`string` es un tipo por valor o un tipo por referencia?

En C#, `string` es un **tipo por referencia** (`reference type`). Esto significa que las variables de tipo string almacenan una referencia a un objeto en el montón (heap) de memoria, en lugar de almacenar el valor directamente en la pila (stack).

Sin embargo, `string` tiene un comportamiento especial que lo hace actuar de manera similar a un tipo por valor debido a dos características clave:

1. **Inmutabilidad:** Una vez que se crea un objeto `string`, no se puede modificar. Cualquier operación que parezca modificar la cadena (como concatenar o reemplazar) en realidad crea un nuevo objeto `string` en la memoria.
2. **Sobrecarga de operadores de igualdad:** Los operadores `==` y `!=` están sobrecargados para comparar el *contenido* de las cadenas (comparación por valor) y no las direcciones de memoria a las que apuntan (comparación por referencia).

---

### 2. ¿Qué secuencias de escape tiene el tipo string?

Las secuencias de escape se utilizan para introducir caracteres especiales que de otro modo serían difíciles o imposibles de representar directamente en una cadena de texto literal. Comienzan siempre con una barra diagonal inversa (`\\`).

A continuación se detallan las secuencias de escape válidas en C#:

| Secuencia de escape | Significado | Descripción |
| :---: | :--- | :--- |
| `\\'` | Comilla simple | Permite incluir una comilla simple `'` sin cerrar un literal de carácter. |
| `\\"` | Comilla doble | Permite incluir comillas dobles `"` dentro de la cadena sin cerrarla. |
| `\\\\` | Barra diagonal inversa | Representa el carácter físico de la barra inversa `\\`. |
| `\\0` | Null | Representa el carácter nulo (Unicode 0). |
| `\\a` | Alerta / Campana | Produce un sonido de alerta del sistema (beep). |
| `\\b` | Retroceso (Backspace) | Mueve el cursor un espacio hacia atrás. |
| `\\f` | Avance de página (Form feed) | Utilizado históricamente para salto de página en impresoras. |
| `\\n` | Nueva línea (Newline) | Mueve el cursor al inicio de la siguiente línea (salto de línea). |
| `\\r` | Retorno de carro (Carriage return) | Mueve el cursor al inicio de la línea actual. |
| `\\t` | Tabulación horizontal | Inserta un espacio de tabulación horizontal estándar. |
| `\\v` | Tabulación vertical | Inserta una tabulación vertical. |
| `\\uXXXX` | Carácter Unicode (Hex) | Representa un carácter Unicode usando 4 dígitos hexadecimales (ej. `\\u00C6`). |
| `\\UXXXXXXXX` | Carácter Unicode largo | Representa un carácter Unicode usando 8 dígitos hexadecimales. |
| `\\xXX` | Carácter Hexadecimal | Representa un carácter ASCII/Unicode mediante su valor en formato hexadecimal variable. |

---

### 3. ¿Qué sucede cuando utiliza el carácter `@` y `$` antes de una cadena de texto?

Estos caracteres modifican la forma en que el compilador de C# interpreta el literal de cadena. Cada uno cumple una función muy específica:

#### El carácter `@` (Cadenas literales textuales o *Verbatim*)
Colocar `@` antes de las comillas dobles le indica a C# que interprete la cadena **exactamente como está escrita**, desactivando las secuencias de escape ordinarias.

* **Ignora la barra inversa:** `\"C:\\\\Usuarios\\\\Documentos\"` se puede escribir de forma más limpia como `@\"C:\\Usuarios\\Documentos\"`.
* **Permite saltos de línea multilínea:** Puedes presionar *Enter* dentro del código y el salto de línea formará parte del string.
* **Comillas dobles:** Para incluir una comilla doble dentro de un string con `@`, se deben escribir dos comillas dobles seguidas (`\"\"`).
*El carácter $ (Interpolación de cadenas)*
*Colocar $ antes de las comillas dobles habilita la interpolación de cadenas (String Interpolation). Esto permite incrustar expresiones de C# o variables directamente dentro del texto utilizando llaves {}.El compilador evalúa las expresiones dentro de las llaves, las convierte a su representación de texto y las concatena automáticamente de forma eficiente.Reemplaza de forma mucho más legible al método tradicional string.Format() o a la concatenación manual con el operador +.*