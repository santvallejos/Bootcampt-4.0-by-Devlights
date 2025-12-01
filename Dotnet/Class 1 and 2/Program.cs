/// <summary>
/// Program main menu
/// </summary>
void Menu()
{
    int option;
    do
    {
        DisplayMenuOptions();
        option = GetValidOption();

        if (option != 0)
            ProcessMenuOption(option);
    } while (option != 0);

    Console.WriteLine("¡Hasta luego :)!");
}

/// <summary>
/// Display menu options
/// </summary>
void DisplayMenuOptions()
{
    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("====        Menu          ===");
    Console.WriteLine("=============================");
    Console.WriteLine("Seleccione el ejercicio que desea ejecutar: \n");

    for (int i = 1; i <= 21; i++)
    {
        Console.WriteLine($"{i}. Ejercicio {i}");
    }

    Console.WriteLine("0. Salir \n");
    Console.Write("Opción: ");
}

/// <summary>
/// Validator for menu options
/// </summary>
/// <returns>Valid menu option as integer</returns>
int GetValidOption()
{
    int option;
    while (!int.TryParse(Console.ReadLine(), out option) || option < 0 || option > 21)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Opción inválida. Por favor seleccione un número para un ejercicio entre 1 y 21 o 0 para salir.");
        Console.ResetColor();
        Console.Write("Opción: ");
    }
    return option;
}

/// <summary>
/// Validate if the entered value is an integer
/// </summary>
/// <param name="mensaje">Message to display to user</param>
/// <returns>Integer type value</returns>
int GetValidInt(string mensaje)
{
    int number;
    Console.WriteLine(mensaje);
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Por favor ingrese un número entero válido.");
        Console.ResetColor();
    }
    return number;
}

/// <summary>
/// Validate if the entered value is a double
/// </summary>
/// <param name="mensaje">Message to display to user</param>
/// <returns>Double type value</returns>
double GetValidDouble(string mensaje)
{
    double number;
    Console.WriteLine(mensaje);
    while (!double.TryParse(Console.ReadLine(), out number))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Por favor ingrese un número decimal válido.");
        Console.ResetColor();
    }
    return number;
}

/// <summary>
/// Validate and get a positive double from user
/// </summary>
/// <param name="mensaje">Message to display to user</param>
/// <returns>Positive double value</returns>
double GetValidPositiveDouble(string mensaje)
{
    double number;
    do
    {
        number = GetValidDouble(mensaje);
        if (number <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: El número debe ser positivo.");
            Console.ResetColor();
        }
    } while (number <= 0);
    return number;
}

/// <summary>
/// Validate and get a non-empty string from user
/// </summary>
/// <param name="mensaje">Message to display to user</param>
/// <returns>Non-empty string</returns>
string GetValidString(string mensaje)
{
    string texto;
    Console.WriteLine(mensaje);
    while (string.IsNullOrWhiteSpace(texto = Console.ReadLine()))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Debe ingresar un valor, no puede estar vacío.");
        Console.ResetColor();
    }
    return texto;
}

/// <summary>
/// Execute the selected menu option
/// </summary>
/// <param name="option">Selected menu option as integer</param>
void ProcessMenuOption(int option)
{
    Console.Clear();

    // Execute the selected exercise
    switch (option)
    {
        case 1:
            Exercise1();
            break;
        case 2:
            Exercise2();
            break;
        case 3:
            Exercise3();
            break;
        case 4:
            Exercise4();
            break;
        case 5:
            Exercise5();
            break;
        case 6:
            Exercise6();
            break;
        case 7:
            Exercise7();
            break;
        case 8:
            Exercise8();
            break;
        case 9:
            Exercise9();
            break;
        case 10:
            Exercise10();
            break;
        case 11:
            Exercise11();
            break;
        case 12:
            Exercise12();
            break;
        case 13:
            Exercise13();
            break;
        case 14:
            Exercise14();
            break;
        case 15:
            Exercise15();
            break;
        case 16:
            Exercise16();
            break;
        case 17:
            Exercise17();
            break;
        case 18:
            Exercise18();
            break;
        case 19:
            Exercise19();
            break;
        case 20:
            Exercise20();
            break;
        case 21:
            Exercise21();
            break;
        default:
            Console.WriteLine("Opción no implementada.");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Presione cualquier tecla para volver al menú...");
    Console.ReadKey();
}

void Exercise1()
{
    Console.WriteLine("Ejercicio 1: Número positivo o negativo\n");

    int number = GetValidInt("Ingrese un número: ");

    if (number > 0)
        Console.WriteLine("El número es positivo.");
    else if (number < 0)
        Console.WriteLine("El número es negativo.");
    else
        Console.WriteLine("El número es cero.");
}

void Exercise2()
{
    Console.WriteLine("Ejercicio 2: Comparación de tres números\n");

    double num1 = GetValidDouble("Ingrese el primer número: ");
    double num2 = GetValidDouble("Ingrese el segundo número: ");
    double num3 = GetValidDouble("Ingrese el tercer número: ");

    if (num1 == num2 || num1 == num3 || num2 == num3) // Check for distinct numbers
    {
        Console.WriteLine("\nPor favor, ingrese tres números distintos.");
        return;
    }

    double[] numbers = { num1, num2, num3 };

    Console.WriteLine($"\nLos números agregados son {num1}, {num2} y {num3}");
    Console.WriteLine($"El número mayor es: {numbers.Max()}");
    Console.WriteLine($"El número menor es: {numbers.Min()}");
}

void Exercise3()
{
    Console.WriteLine("Ejercicio 3: Múltiplos de un número\n");

    int num1 = GetValidInt("Ingrese el primer número: ");
    int num2 = GetValidInt("Ingrese el segundo número: ");

    if (num2 == 0)
    {
        Console.WriteLine("No se puede dividir por cero.");
        return;
    }

    if (num1 % num2 == 0)
        Console.WriteLine($"{num1} es múltiplo de {num2}.");
    else
        Console.WriteLine($"{num1} no es múltiplo de {num2}.");
}

void Exercise4()
{
    Console.WriteLine("Ejercicio 4: Descuento en tienda\n");

    double price = GetValidPositiveDouble("Ingrese el precio del producto: ");

    if (price > 1000)
    {
        double discount = price * 0.10;
        Console.WriteLine($"El precio con descuento del 10% es: ${price - discount:F2}");
    }
    else
    {
        Console.WriteLine($"El precio no tiene descuento y es: ${price:F2}");
    }
}

void Exercise5()
{
    Console.WriteLine("Ejercicio 5: Conversión de tipo\n");

    double decimalNumber = GetValidDouble("Ingrese un número decimal: ");
    int integerNumber = (int)decimalNumber; // Explicit conversion

    Console.WriteLine($"\nNúmero decimal: {decimalNumber}");
    Console.WriteLine($"Número entero (después de conversión explícita): {integerNumber}");
    Console.WriteLine("\nDiferencia: La conversión explícita trunca la parte decimal, no redondea.");
}

void Exercise6()
{
    Console.WriteLine("Ejercicio 6: Clasificación por edad\n");

    int age = GetValidInt("Ingrese la edad: ");

    if (age >= 1 && age <= 12)
        Console.WriteLine("La persona es un niño.");
    else if (age >= 13 && age <= 19)
        Console.WriteLine("La persona es un adolescente.");
    else if (age >= 20 && age <= 59)
        Console.WriteLine("La persona es un adulto.");
    else if (age >= 60)
        Console.WriteLine("La persona es un adulto mayor.");
    else
        Console.WriteLine("Edad no válida.");
}

void Exercise7()
{
    Console.WriteLine("Ejercicio 7: Número dentro de rango\n");

    double number = GetValidDouble("Ingrese un número: ");

    if (number >= 1 && number <= 100)
        Console.WriteLine($"El número {number} está dentro del rango 1-100.");
    else
        Console.WriteLine("El número está fuera del rango 1-100.");
}

void Exercise8()
{
    Console.WriteLine("Ejercicio 8: Operador ternario\n");

    int number = GetValidInt("Ingrese un número: ");

    Console.WriteLine((number % 2 == 0) ? $"{number} es Par" : $"{number} es Impar");
}

void Exercise9()
{
    Console.WriteLine("Ejercicio 9: Cálculo de impuestos\n");

    double income = GetValidPositiveDouble("Ingrese su ingreso anual: ");

    double tax;
    if (income < 10000)
        tax = 0;
    else if (income >= 10000 && income <= 50000)
        tax = income * 0.10;
    else
        tax = income * 0.20;

    Console.WriteLine($"El monto de impuesto a pagar es: ${tax:F2}");
}

void Exercise10()
{
    Console.WriteLine("Ejercicio 10: Día de la semana con switch\n");

    int dayNumber = GetValidInt("Ingrese un número del 1 al 7: ");

    switch (dayNumber)
    {
        case 1:
            Console.WriteLine("Lunes");
            break;
        case 2:
            Console.WriteLine("Martes");
            break;
        case 3:
            Console.WriteLine("Miércoles");
            break;
        case 4:
            Console.WriteLine("Jueves");
            break;
        case 5:
            Console.WriteLine("Viernes");
            break;
        case 6:
            Console.WriteLine("Sábado");
            break;
        case 7:
            Console.WriteLine("Domingo");
            break;
        default:
            Console.WriteLine("Número inválido. Por favor ingrese un número entre 1 y 7.");
            break;
    }
}

void Exercise11()
{
    Console.WriteLine("Ejercicio 11: Menú con switch\n");

    Console.WriteLine("Seleccione una operación: \n 1. Sumar \n 2. Restar \n 3. Multiplicar \n 4. Dividir");

    int operation = GetValidInt("\nOpción: ");

    switch (operation)
    {
        case 1:
            Addition();
            break;
        case 2:
            Subtraction();
            break;
        case 3:
            Multiplication();
            break;
        case 4:
            Division();
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor seleccione una opción entre 1 y 4.");
            break;
    }
}

void Exercise12()
{
    Console.WriteLine("Ejercicio 12: Contador de pares\n");

    int N = GetValidInt("Ingrese un número N: ");

    if (N < 1)
    {
        Console.WriteLine("Por favor ingrese un número mayor o igual a 1.");
        return;
    }

    int count = 0;
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
            count++;
    }

    Console.WriteLine($"Hay {count} números pares entre 1 y {N}.");
}

void Exercise13()
{
    Console.WriteLine("Ejercicio 13: Suma de números impares\n");

    int sum = 0;
    for (int i = 1; i <= 100; i += 2)
    {
        sum += i;
    }

    Console.WriteLine($"La suma de los números impares del 1 al 100 es: {sum}");
}

void Exercise14()
{
    Console.WriteLine("Ejercicio 14: Contador de letras\n");

    string word = GetValidString("Ingrese una palabra: ");

    Console.WriteLine($"La palabra '{word}' tiene {word.Length} letras.");
}

void Exercise15()
{
    Console.WriteLine("Ejercicio 15: Tabla de multiplicar\n");

    double number = GetValidDouble("Ingrese un número: ");

    Console.WriteLine($"\nTabla de multiplicar del {number}:");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{number} x {i} = {number * i}");
    }
}

void Exercise16()
{
    Console.WriteLine("Ejercicio 16: Promedio de notas\n");

    Console.WriteLine("Ingrese 5 notas:");
    double sum = 0;

    for (int i = 1; i <= 5; i++) // Loop to get 5 grades
    {
        double grade = GetValidDouble($"Nota {i}: ");
        sum += grade;
    }

    double average = sum / 5;

    Console.WriteLine($"\nEl promedio es: {average:F2}");
    if (average >= 6)
        Console.WriteLine("El estudiante aprueba.");
    else
        Console.WriteLine("El estudiante no aprueba.");
}

void Exercise17()
{
    Console.WriteLine("Ejercicio 17: Contador hasta que sea cero\n");

    int count = 0;
    int number;

    do
    {
        number = GetValidInt("Ingrese un número entero (0 para terminar): ");
        if (number != 0)
            count++;
    } while (number != 0);

    Console.WriteLine($"Cantidad de números introducidos: {count}");
}

void Exercise18()
{
    Console.WriteLine("Ejercicio 18: Suma acumulada con condición\n");

    int sum = 0;
    int count = 0;

    while (sum <= 100)
    {
        int number = GetValidInt("Ingrese un número: ");
        sum += number;
        count++;
    }

    Console.WriteLine($"\nSe ingresaron {count} números hasta que la suma superó 100.");
    Console.WriteLine($"Suma final: {sum}");
}

void Exercise19()
{
    Console.WriteLine("Ejercicio 19: Contador de dígitos\n");

    int value = GetValidInt("Ingrese un número entero: "); // Read integer input
    string number = value.ToString(); //Convert to string to count digits

    int digitCount = number.Replace("-", "").Length; // If negative, remove '-' before counting

    Console.WriteLine($"El número {number} tiene {digitCount} dígitos.");
}

void Exercise20()
{
    Console.WriteLine("Ejercicio 20: Contar vocales\n");

    string word = GetValidString("Ingrese una palabra: ");
    word = word.ToLower();

    int vowelCount = 0;
    foreach (char c in word) // Loop through each character
    {
        if ("aeiouáéíóú".Contains(c))
            vowelCount++;
    }

    Console.WriteLine($"La palabra '{word}' tiene {vowelCount} vocales.");
}

void Exercise21()
{
    Console.WriteLine("Ejercicio 21: Mini cajero automático\n");

    double balance = 1000.0;
    int option;

    do
    {
        Console.WriteLine("\n=============================");
        Console.WriteLine("Menú del Cajero Automático:");
        Console.WriteLine("=============================");
        Console.WriteLine("1) Consultar saldo");
        Console.WriteLine("2) Depositar");
        Console.WriteLine("3) Retirar");
        Console.WriteLine("4) Salir");

        option = GetValidInt("Seleccione una opción: ");

        switch (option)
        {
            case 1:
                Console.WriteLine($"Su saldo actual es: ${balance:F2}");
                break;

            case 2:
                double depositAmount = GetValidPositiveDouble("Ingrese el monto a depositar: ");
                balance += depositAmount;
                Console.WriteLine($"Depósito exitoso. Nuevo saldo: ${balance:F2}");
                break;

            case 3:
                double withdrawAmount = GetValidPositiveDouble("Ingrese el monto a retirar: ");

                if (withdrawAmount <= balance)
                {
                    balance -= withdrawAmount;
                    Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${balance:F2}");
                }
                else
                {
                    Console.WriteLine("Fondos insuficientes para realizar el retiro.");
                }
                break;

            case 4:
                Console.WriteLine("Gracias por usar el cajero automático. ¡Hasta luego!");
                break;

            default:
                Console.WriteLine("Opción inválida. Por favor seleccione una opción entre 1 y 4.");
                break;
        }
    } while (option != 4);
}

// Auxiliary functions for Exercise 11
void Addition()
{
    double num1 = GetValidDouble("Ingrese el primer número: ");
    double num2 = GetValidDouble("Ingrese el segundo número: ");
    Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
}

void Subtraction()
{
    double num1 = GetValidDouble("Ingrese el primer número: ");
    double num2 = GetValidDouble("Ingrese el segundo número: ");
    Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
}

void Multiplication()
{
    double num1 = GetValidDouble("Ingrese el primer número: ");
    double num2 = GetValidDouble("Ingrese el segundo número: ");
    Console.WriteLine($"El resultado de la multiplicación es: {num1 * num2}");
}

void Division()
{
    double num1 = GetValidDouble("Ingrese el primer número: ");
    double num2;

    do
    {
        num2 = GetValidDouble("Ingrese el segundo número: ");
        if (num2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: No se puede dividir por cero. Ingrese un número diferente de cero.");
            Console.ResetColor();
        }
    } while (num2 == 0);

    Console.WriteLine($"El resultado de la división es: {num1 / num2:F2}");
}

// Execute program
Menu();