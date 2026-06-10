using System;

class Program
{
    static void Main()
    {
        int opcion;

        Console.Clear();
        Console.WriteLine("===== MENÚ DE EJERCICIOS =====");
        Console.WriteLine("1. Contador simple");
        Console.WriteLine("2. Suma de números naturales");
        Console.WriteLine("3. Tabla de multiplicar");
        Console.WriteLine("4. Números pares");
        Console.WriteLine("5. Promedio de notas");
        Console.WriteLine("6. Arreglo de números");
        Console.WriteLine("7. Mayor y menor en un arreglo");
        Console.WriteLine("8. Contador de positivos, negativos y ceros");
        Console.WriteLine("9. Búsqueda en un arreglo");
        Console.WriteLine("10. Frecuencia de valores");
        Console.WriteLine("0. Salir");

        Console.Write("\nSeleccione una opción: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                ContadorSimple();
                break;

            case 2:
                SumaNumeros();
                break;

            case 3:
                TablaMultiplicar();
                break;

            case 4:
                NumerosPares();
                break;

            case 5:
                PromedioNotas();
                break;

            case 6:
                ArregloNumeros();
                break;

            case 7:
                MayorMenor();
                break;

            case 8:
                ContadorNumeros();
                break;

            case 9:
                BuscarNumero();
                break;

            case 10:
                FrecuenciaValores();
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

        
        static void ContadorSimple()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        
        static void SumaNumeros()
        {
            int i = 1;
            int suma = 0;

            while (i <= 100)
            {
                suma += i;
                i++;
            }

            Console.WriteLine("La suma de los primeros 100 números naturales es: " + suma);
        }

        
        static void TablaMultiplicar()
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        
        static void NumerosPares()
        {
            for (int i = 2; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        
        static void PromedioNotas()
        {
            Console.Write("¿Cuántas notas desea ingresar? ");
            int cantidad = int.Parse(Console.ReadLine());

            double suma = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese la nota {i}: ");
                suma += double.Parse(Console.ReadLine());
            }

            double promedio = suma / cantidad;

            Console.WriteLine("Promedio final: " + promedio);
        }

        
        static void ArregloNumeros()
        {
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros almacenados:");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        
        static void MayorMenor()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int mayor = numeros[0];
            int menor = numeros[0];

            foreach (int numero in numeros)
            {
                if (numero > mayor)
                    mayor = numero;

                if (numero < menor)
                    menor = numero;
            }

            Console.WriteLine("Número mayor: " + mayor);
            Console.WriteLine("Número menor: " + menor);
        }

        
        static void ContadorNumeros()
        {
            Console.Write("¿Cuántos números desea ingresar? ");
            int n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            foreach (int numero in numeros)
            {
                if (numero > 0)
                    positivos++;
                else if (numero < 0)
                    negativos++;
                else
                    ceros++;
            }

            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Ceros: " + ceros);
        }

        
        static void BuscarNumero()
        {
            int[] numeros = { 10, 20, 30, 40, 50 };

            Console.Write("Ingrese el número a buscar: ");
            int buscar = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscar)
                {
                    Console.WriteLine($"Número encontrado en la posición {i}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Número no encontrado.");
            }
        }

        
        static void FrecuenciaValores()
        {
            Console.Write("¿Cuántos números desea ingresar? ");
            int n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nFrecuencia de los números:");

            for (int i = 0; i < numeros.Length; i++)
            {
                bool yaContado = false;

                for (int j = 0; j < i; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        yaContado = true;
                        break;
                    }
                }

                if (!yaContado)
                {
                    int frecuencia = 0;

                    foreach (int numero in numeros)
                    {
                        if (numero == numeros[i])
                        {
                            frecuencia++;
                        }
                    }

                    Console.WriteLine($"{numeros[i]} aparece {frecuencia} vez(es)");
                }
            }
        }
    }

    
}