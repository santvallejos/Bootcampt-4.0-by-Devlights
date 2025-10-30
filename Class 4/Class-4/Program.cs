using System;
using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;
using System.Threading;

namespace Class_4
{
    internal class Program
    {
        static void Main()
        {
            int option;
            do
            {
                DisplayMenuOptions();
                option = GetValidOption();

                if (option != 0)
                    ProcessMenuOption(option);
            } while (option != 0);

            Console.WriteLine("¡Hasta luego! :)");
        }

        static void DisplayMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("====        Menu          ===");
            Console.WriteLine("=============================");
            Console.WriteLine("Seleccione el ejercicio que desea ejecutar: \n");

            for (int i = 1; i <= 11; i++)
            {
                Console.WriteLine($"{i}. Ejercicio {i}");
            }

            Console.WriteLine("0. Salir \n");
            Console.Write("Opción: ");
        }

        /// <summary>
        /// Execute the selected menu option
        /// </summary>
        /// <param name="option">Selected menu option as integer</param>
        static void ProcessMenuOption(int option)
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
                default:
                    Console.WriteLine("Opción no implementada.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        static void Exercise1()
        {
            List<int> notes = new List<int>() { 10, 4, 1, 6, 8, 10, 4, 1, 3, 6 }; // List of notes initialized

            double average = notes.Average(); // Calculate the average using LINQ
            Console.WriteLine($"El promedio de las notas es: {average}");
            Console.WriteLine("La lista de notas es:");
            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }
        }

        static void Exercise2()
        {
            List<int> ages = new List<int> { 13, 47, 29, 23, 56, 24, 38, 3, 41, 25, 31, 27, 66, 5, 55, 10, 19, 10, 9, 74 };

            //int adultAges = ages.Where(age => age >= 18).Count(); //Where evaluates a condition and Count counts the elements that meet that condition
            //int minorAges = ages.Where(age => age < 18).Count();
            int adultAges = ages.Count(age => age >= 18); // Using Count with a predicate to count elements that meet the condition
            int minorAges = ages.Count(age => age < 18);
            Console.WriteLine($"Edades de adultos: {adultAges}");
            Console.WriteLine($"Edades de menores: {minorAges}");
        }

        static void Exercise3()
        {
            List<string> studentNames = new List<string>
            {
                "Ana", "Luis", "Carlos", "Beatriz", "Sofía",
                "Miguel", "Lucía", "Jorge", "María", "Pedro"
            };

            string longestName = studentNames.OrderByDescending(name => name.Length).First(); // Order names by length in descending order and take the first one
            string shortestName = studentNames.OrderBy(name => name.Length).First();

            Console.WriteLine($"El nombre más largo es: {longestName} con {longestName.Length} caracteres.");
            Console.WriteLine($"El nombre más corto es: {shortestName}  con {shortestName.Length} caracteres.");
        }

        static void Exercise4()
        {
            List<string> supermarketList = new List<string>();

            int option;
            Console.WriteLine("Bienvenido a tu lista de supermercado personal.");
            do
            {
                if (supermarketList.Count == 0)
                {
                    Console.WriteLine("\nTu lista de supermercado está vacía agrega productos a tu lista.");
                }
                else
                {
                    Console.WriteLine("\nTu lista de supermercado actual es:");
                    foreach (var item in supermarketList)
                    {
                        Console.WriteLine($"- {item}");
                    }
                }

                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("0. Salir");
                option = GetValidInt("Opción: ");

                switch (option)
                {
                    case 1:
                        string productToAdd = GetValidString("Ingrese el nombre del producto a agregar:");
                        if (supermarketList.Contains(productToAdd)) // Check for duplicates
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("El producto ya está en la lista.");
                            Console.ResetColor();
                            Thread.Sleep(2000); // Pause for 2 seconds to show the success message
                            Console.Clear();
                        }
                        else
                        {
                            supermarketList.Add(productToAdd); // Add product to the list
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Producto agregado exitosamente.");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    case 2:
                        string productToRemove = GetValidString("Ingrese el nombre del producto que desea eliminar:");
                        if (supermarketList.Remove(productToRemove)) // return true if the product was found and removed
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Producto eliminado exitosamente.");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("El producto no está en la lista.");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saliendo de la lista de supermercado.");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción inválida. Por favor seleccione una opción válida.");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            } while (option != 0);
        }

        static void Exercise5()
        {
            string[,] matrix = new string[5, 5]
            {
                {"I", "I", "I", "I", "I"},
                {"I", "P", "I", "P", "I"},
                {"I", "I", "I", "I", "I"},
                {"I", "P", "I", "P", "I"},
                {"I", "I", "I", "I", "I"}
            };

            Console.WriteLine("Matriz 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Exercise6()
        {
            int[,] tempsCab = new int[5, 7];

            string[] daysOfWeek = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            // Generate random temperatures between 7 and 38 degrees
            Console.WriteLine("Temperaturas de la cabina en el mes de Mayo son:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    tempsCab[i, j] = Random.Shared.Next(7, 39);
                    Console.Write(tempsCab[i, j] + " ");
                }
                Console.WriteLine();
            }

            var tempsMaxOfWeek = new List<(int day, int temp)>(); // List to store max temps of each week
            // Find the day with the maximum temperature for each week
            for (int i = 0; i < 5; i++)
            {
                int maxTemp = tempsCab[i, 0]; // Assume the first day is the max initially
                int dayOfMaxTemp = 0;   // Initialize with the first day of the week
                for (int j = 1; j < 7; j++)
                {
                    if (tempsCab[i, j] > maxTemp)
                    {
                        maxTemp = tempsCab[i, j];
                        dayOfMaxTemp = j;
                    }
                }
                tempsMaxOfWeek.Add((dayOfMaxTemp, maxTemp));
            }

            Console.WriteLine("\nDías con temperatura máxima de cada semana:");
            for (int i = 0; i < tempsMaxOfWeek.Count; i++) // Show all temps max of each week
            {
                Console.WriteLine($"Semana {i + 1}: {daysOfWeek[tempsMaxOfWeek[i].day]} con {tempsMaxOfWeek[i].temp}°C");
            }

            var averageTempsOfWeek = new List<double>(); // List to store average temps of each week
            // Calculate average temperature for each week
            for (int i = 0; i < 5; i++)
            {
                int sumTemps = 0; // sum of temperatures of the week
                for (int j = 0; j < 7; j++)
                {
                    sumTemps += tempsCab[i, j];
                }
                averageTempsOfWeek.Add(sumTemps / 7.0);
            }

            Console.WriteLine("\nTemperaturas promedio de cada semana:");
            for (int i = 0; i < averageTempsOfWeek.Count; i++)
            {
                Console.WriteLine($"Semana {i + 1}: {averageTempsOfWeek[i]:F2}°C");
            }

            var maxTempOfMonth = tempsCab[0, 0];
            var dayOfMaxTempOfMonth = (week: 0, day: 0);
            // Find the maximum temperature of the month
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (tempsCab[i, j] > maxTempOfMonth)
                    {
                        maxTempOfMonth = tempsCab[i, j];
                        dayOfMaxTempOfMonth = (week: i, day: j);
                    }
                }
            }

            Console.WriteLine($"\nLa temperatura máxima del mes fue {maxTempOfMonth}°C el día {daysOfWeek[dayOfMaxTempOfMonth.day]} de la semana {dayOfMaxTempOfMonth.week + 1}.");
        }

        static void Exercise7()
        {
            int[,] table = new int[9, 10];

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Tabla del {i + 1}:");
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = (i + 1) * (j + 1); // Calculate multiplication and save in the array
                    Console.WriteLine($"{i + 1} x {j + 1} = {table[i, j]}"); // Display the multiplication
                }
            }
        }

        static void Exercise8()
        {
            string[,] matrix = new string[10, 10]
            {
                {"*", "*", "X", "*", "*", "X", "*", "*", "X", "*"},
                {"X", "*", "*", "X", "*", "X", "*", "*", "*", "X"},
                {"*", "X", "*", "*", "X", "*", "X", "*", "X", "*"},
                {"X", "*", "X", "*", "*", "X", "*", "X", "*", "*"},
                {"*", "X", "*", "X", "*", "*", "X", "*", "X", "*"},
                {"X", "*", "X", "*", "X", "*", "*", "X", "*", "X"},
                {"*", "X", "*", "X", "*", "X", "*", "*", "X", "*"},
                {"X", "*", "X", "*", "X", "*", "X", "*", "*", "*"},
                {"*", "*", "*", "X", "*", "X", "*", "X", "*", "X"},
                {"X", "*", "X", "*", "X", "*", "X", "*", "X", "*"}
            };
            int lives = 3;
            int x = 41;
            string[,] displayMatrix = new string[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    displayMatrix[i, j] = "⚪"; // Initialize display matrix with underscores
                    Console.Write(displayMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("¡Bienvenido al juego de encontrar las x! Tienes 3 vidas para encontrar todas las x en la matriz. Hay 41 x en total.");
            while (lives > 0 && x != 0)
            {
                int row = GetValidInt("Ingrese la Fila (0-9): ");
                int col = GetValidInt("Ingrese la Columna (0-9): ");

                if (row >= 0 && row <= 9 && col >= 0 && col <= 9)
                {
                    if (displayMatrix[row, col] == "❎" || displayMatrix[row, col] == "*")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ya has intentado esta posición. Intenta otra.");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                    }
                    else if (matrix[row, col] == "X")
                    {
                        displayMatrix[row, col] = "❎";
                        x--;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Has encontrado una x!");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        displayMatrix[row, col] = "*";
                        lives--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"No hay una x aquí. Te quedan {lives} vidas.");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Coordenadas inválidas. Por favor ingrese valores entre 0 y 9.");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }

                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(displayMatrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"Te quedan {lives} vidas y {x} x por encontrar.");
            }

            if (x == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Felicidades! Has encontrado todas las x.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Has perdido todas tus vidas. Fin del juego.");
                Console.ResetColor();
                Console.WriteLine("\nLa matriz completa era:");
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Exercise9()
        {
            Dictionary<string, double> studentGrades = new Dictionary<string, double>();

            int option;
            do
            {
                Console.WriteLine("Lista de notas de alumnos");

                if (studentGrades.Count == 0)
                {
                    Console.WriteLine("\nNo hay notas disponibles.");
                }
                else
                {
                    Console.WriteLine("\nLa lista de alumnos y sus notas:");
                    foreach (var student in studentGrades)
                    {
                        Console.WriteLine($"Alumno: {student.Key}, Nota: {student.Value}");
                    }
                }
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar alumno y su nota");
                Console.WriteLine("2. Promedio general del curso");
                Console.WriteLine("3. Alumno con mejor y peor nota");
                Console.WriteLine("0. Salir");
                option = GetValidInt("Opción: ");

                switch (option)
                {
                    case 1:
                        string studentName = GetValidString("Ingrese el nombre del alumno:");
                        double studentGrade = GetValidDouble("Ingrese la nota del alumno (0-10):");
                        while (studentGrade < 0 || studentGrade > 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nota inválida. Por favor ingrese una nota entre 0 y 10.");
                            Console.ResetColor();
                            studentGrade = GetValidDouble("Ingrese la nota del alumno (0-10):");
                        }
                        studentGrades[studentName] = studentGrade; // Add or update the student's grade
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Alumno y nota agregados exitosamente.");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 2:
                        if (studentGrades.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("No hay notas disponibles para calcular el promedio.");
                            Console.ResetColor();
                        }
                        else
                        {
                            double averageGrade = studentGrades.Values.Average();
                            Console.WriteLine($"El promedio general del curso es: {averageGrade:F2}");
                        }
                        break;
                    case 3:
                        if (studentGrades.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("No hay notas disponibles para determinar el mejor y peor alumno.");
                            Console.ResetColor();
                        }
                        else
                        {
                            var bestStudent = studentGrades.Aggregate((l, r) => l.Value > r.Value ? l : r);
                            var worstStudent = studentGrades.Aggregate((l, r) => l.Value < r.Value ? l : r);
                            Console.WriteLine($"El alumno con la mejor nota es: {bestStudent.Key} con una nota de {bestStudent.Value}");
                            Console.WriteLine($"El alumno con la peor nota es: {worstStudent.Key} con una nota de {worstStudent.Value}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saliendo de la gestión de notas de alumnos.");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción inválida. Por favor seleccione una opción válida.");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            } while (option != 0);
        }

        static void Exercise10()
        {
            Console.WriteLine("Ventanilla N°1");
            Queue<String> queue = new Queue<string>();

            int option;
            Boolean attendingBoolean = false;
            string currentClient = ""; // Variable para almacenar el cliente que está siendo atendido
            do
            {
                if (queue.Count == 0 && !attendingBoolean)
                    Console.WriteLine("\nNo hay personas en la fila.");
                if (attendingBoolean)
                    Console.WriteLine($"\nEstás Atendiendo a: {currentClient}");

                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar persona a la fila");
                Console.WriteLine("2. Atender persona en la fila");
                Console.WriteLine("3. Ver quien está siendo atendido y cuántas personas hay en la fila");
                if (attendingBoolean)
                    Console.WriteLine("4. Finalizar atención");

                Console.WriteLine("0. Salir");
                option = GetValidInt("Opción: ");

                switch (option)
                {
                    case 1:
                        string clientToAdd = GetValidString("Ingrese el nombre de la persona a agregar a la fila:");
                        queue.Enqueue(clientToAdd); // Add person to the queue
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Persona agregada a la fila exitosamente.");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 2:
                        if (attendingBoolean)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Ya estás atendiendo a alguien. Finaliza la atención actual primero.");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else if (queue.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("No hay personas en la fila para atender.");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else
                        {
                            currentClient = queue.Dequeue(); // Sacar a la persona de la fila y empezar a atenderla
                            attendingBoolean = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Atendiendo a: {currentClient}");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    case 3:
                        if (!attendingBoolean && queue.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("No hay personas en la fila ni nadie siendo atendido.");
                            Console.ResetColor();
                        }
                        else
                        {
                            if (attendingBoolean)
                                Console.WriteLine($"Persona siendo atendida: {currentClient}");
                            else
                                Console.WriteLine("No hay ninguna atención en curso.");

                            Console.WriteLine($"Personas en la fila: {queue.Count}");
                        }
                        break;
                    case 4:
                        if (attendingBoolean)
                        {
                            attendingBoolean = false;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Atención finalizada para: {currentClient}");
                            Console.ResetColor();
                            currentClient = ""; // Limpiar el cliente actual
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No hay ninguna atención en curso para finalizar.");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saliendo de la gestión de la fila.");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción inválida. Por favor seleccione una opción válida.");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            } while (option != 0);
        }

        static void Exercise11()
        {
            List<string> products = new List<string>(); // List of available products
            Dictionary<string, int> stock = new Dictionary<string, int>(); // Stock of each product
            Stack<string> actionsHistory = new Stack<string>(); // History of actions performed

            int option;
            do
            {
                Console.WriteLine("\n========== Sistema de Inventario ==========");

                if (products.Count == 0)
                {
                    Console.WriteLine("\nNo hay productos en el inventario.");
                }
                else
                {
                    Console.WriteLine($"\nProductos disponibles: {products.Count}");
                }

                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar producto y cantidad");
                Console.WriteLine("2. Vender producto");
                Console.WriteLine("3. Mostrar inventario actual");
                Console.WriteLine("4. Mostrar últimas 3 acciones");
                Console.WriteLine("0. Salir");
                option = GetValidInt("Opción: ");

                switch (option)
                {
                    case 1:
                        string productToAdd = GetValidString("Ingrese el nombre del producto:");

                        if (products.Contains(productToAdd))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"El producto '{productToAdd}' ya existe en el inventario.");
                            Console.ResetColor();

                            int additionalQuantity = GetValidInt("Ingrese la cantidad a agregar:");
                            while (additionalQuantity < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("La cantidad no puede ser negativa.");
                                Console.ResetColor();
                                additionalQuantity = GetValidInt("Ingrese la cantidad a agregar:");
                            }

                            stock[productToAdd] += additionalQuantity;
                            actionsHistory.Push($"Agregado: {additionalQuantity} unidades de '{productToAdd}' (Total: {stock[productToAdd]})");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Se agregaron {additionalQuantity} unidades. Stock actual: {stock[productToAdd]}");
                            Console.ResetColor();
                        }
                        else
                        {
                            int quantity = GetValidInt("Ingrese la cantidad inicial:");
                            while (quantity < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("La cantidad no puede ser negativa.");
                                Console.ResetColor();
                                quantity = GetValidInt("Ingrese la cantidad inicial:");
                            }

                            products.Add(productToAdd);
                            stock[productToAdd] = quantity;
                            actionsHistory.Push($"Creado: Producto '{productToAdd}' con {quantity} unidades");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Producto agregado exitosamente al inventario.");
                            Console.ResetColor();
                        }

                        Thread.Sleep(2000);
                        Console.Clear();
                        break;

                    case 2:
                        if (products.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("No hay productos disponibles para vender.");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }

                        string productToSell = GetValidString("Ingrese el nombre del producto a vender:");

                        if (!products.Contains(productToSell))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"El producto '{productToSell}' no existe en el inventario.");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }

                        Console.WriteLine($"Stock disponible: {stock[productToSell]} unidades");
                        int quantityToSell = GetValidInt("Ingrese la cantidad a vender:");

                        while (quantityToSell < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("La cantidad no puede ser negativa.");
                            Console.ResetColor();
                            quantityToSell = GetValidInt("Ingrese la cantidad a vender:");
                        }

                        if (quantityToSell > stock[productToSell])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Stock insuficiente. Solo hay {stock[productToSell]} unidades disponibles.");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else
                        {
                            stock[productToSell] -= quantityToSell;
                            actionsHistory.Push($"Vendido: {quantityToSell} unidades de '{productToSell}' (Restante: {stock[productToSell]})");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Venta realizada. Stock restante: {stock[productToSell]} unidades");
                            Console.ResetColor();

                            // Si el stock llega a 0, opcionalmente se puede remover el producto
                            if (stock[productToSell] == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"⚠️ El producto '{productToSell}' se ha agotado.");
                                Console.ResetColor();
                            }

                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;

                    case 3:
                        if (products.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nEl inventario está vacío.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("\n========== Inventario Actual ==========");
                            Console.WriteLine($"{"Producto",-30} {"Stock",10}");
                            Console.WriteLine(new string('-', 42));

                            foreach (var product in products)
                            {
                                Console.WriteLine($"{product,-30} {stock[product],10}");
                            }

                            Console.WriteLine(new string('-', 42));
                            Console.WriteLine($"Total de productos: {products.Count}");
                            Console.WriteLine($"Total de unidades: {stock.Values.Sum()}");
                        }
                        break;

                    case 4:
                        if (actionsHistory.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nNo hay acciones registradas.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("\n========== Últimas 3 Acciones ==========");
                            int count = 0;
                            foreach (var action in actionsHistory)
                            {
                                if (count >= 3) break;
                                Console.WriteLine($"{count + 1}. {action}");
                                count++;
                            }
                            Console.WriteLine(new string('-', 42));
                        }
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del sistema de inventario.");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción inválida. Por favor seleccione una opción válida.");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            } while (option != 0);
        }

        // Methods Auxiliares

        /// <summary>
        /// Validator for menu options
        /// </summary>
        /// <returns>Valid menu option as integer</returns>
        static int GetValidOption()
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
        static int GetValidInt(string mensaje)
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
        static double GetValidDouble(string mensaje)
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
        /// Validate and get a non-empty string from user
        /// </summary>
        /// <param name="mensaje">Message to display to user</param>
        /// <returns>Non-empty string</returns>
        static string GetValidString(string mensaje)
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
    }
}