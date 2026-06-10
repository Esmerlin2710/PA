using System;
namespace Primeros_pasos
{

    class Program
    {
        static void Main()
        {

            int opcion;

            Console.WriteLine("---------- MENU DE EJERCICIOS ------------");
            Console.WriteLine("1. Control de acceso por edad");
            Console.WriteLine("2. Sistema de calificaciones escolares");
            Console.WriteLine("3. Verificador de números pares e impares");
            Console.WriteLine("4. Simulador de cajero automático");
            Console.WriteLine("5. Clasificador de temperatura ambiental");
            Console.WriteLine("6. Selector de días de la semana");
            Console.WriteLine("7. Calculadora básica de operaciones");
            Console.WriteLine("8. Conversor de tipo de usuario");
            Console.WriteLine("9. Dispensador automático de bebidas");
            Console.WriteLine("10. Identificador de estaciones del año por mes\n");
            Console.WriteLine("Seleccione una opcion:\n");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Acceso_edad();
                    break;
                case 2:
                    Cali_esco();
                    break;
                case 3:
                    Par_impar();
                    break;
                case 4:
                    Cajero();
                    break;
                case 5:
                    ClasificadorTemperatura();
                    break;
                case 6:
                    DiasSemana();
                    break;

                case 7:
                    CalculadoraBasica();
                    break;

                case 8:
                    RolesUsuario();
                    break;

                case 9:
                    DispensadorBebidas();
                    break;

                case 10:
                    EstacionesAnio();
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }


            static void Acceso_edad()
            {
                Console.WriteLine("Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine("Bienvenido");
                }
                else
                {
                    Console.WriteLine("Necesita ser mayor a 18 para entrar");
                }
            }

            static void Cali_esco()
            {
                Console.WriteLine("Ingrese la nota obtenida: ");
                int nota = int.Parse(Console.ReadLine());

                if (nota >= 60)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }

            static void Par_impar()
            {
                Console.WriteLine("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("Par");
                }
                else
                {
                    Console.WriteLine("Impar");
                }
            }

            static void Cajero()
            {
                double saldo = 10000;

                Console.WriteLine("Saldo disponible: " + saldo);
                Console.WriteLine("Ingrese la cantidad a retirar: ");
                double retiro = double.Parse(Console.ReadLine());

                if (retiro <= saldo)
                {
                    saldo -= retiro;
                    Console.WriteLine("Retiro exitoso");
                    Console.WriteLine("Saldo restante: " + saldo);
                }
                else
                {
                    Console.WriteLine("Fondos insuficientes");
                }
            }

            static void ClasificadorTemperatura()
            {
                Console.Write("Ingrese la temperatura en °C: ");
                double temp = double.Parse(Console.ReadLine());

                if (temp < 15)
                    Console.WriteLine("Clima Frío");
                else if (temp <= 28)
                    Console.WriteLine("Clima Templado");
                else
                    Console.WriteLine("Clima Cálido");
            }

            // 6. Días de la semana
            static void DiasSemana()
            {
                Console.Write("Ingrese un número del 1 al 7: ");
                int dia = int.Parse(Console.ReadLine());

                switch (dia)
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
                        Console.WriteLine("Día inválido.");
                        break;
                }
            }

            // 7. Calculadora básica
            static void CalculadoraBasica()
            {
                Console.Write("Primer número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.Write("Operación (+, -, *, /): ");
                char op = char.Parse(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        Console.WriteLine("Resultado: " + (num1 + num2));
                        break;

                    case '-':
                        Console.WriteLine("Resultado: " + (num1 - num2));
                        break;

                    case '*':
                        Console.WriteLine("Resultado: " + (num1 * num2));
                        break;

                    case '/':
                        if (num2 != 0)
                            Console.WriteLine("Resultado: " + (num1 / num2));
                        else
                            Console.WriteLine("No se puede dividir entre cero.");
                        break;

                    default:
                        Console.WriteLine("Operación inválida.");
                        break;
                }
            }

            // 8. Roles de usuario
            static void RolesUsuario()
            {
                Console.Write("Ingrese el rol (A, E, U, L): ");
                char rol = char.Parse(Console.ReadLine().ToUpper());

                switch (rol)
                {
                    case 'A':
                        Console.WriteLine("Administrador: acceso total.");
                        break;

                    case 'E':
                        Console.WriteLine("Editor: puede modificar contenido.");
                        break;

                    case 'U':
                        Console.WriteLine("Autor: puede crear contenido.");
                        break;

                    case 'L':
                        Console.WriteLine("Lector: solo lectura.");
                        break;

                    default:
                        Console.WriteLine("Invitado.");
                        break;
                }
            }

            // 9. Dispensador de bebidas
            static void DispensadorBebidas()
            {
                Console.WriteLine("1. Café");
                Console.WriteLine("2. Té");
                Console.WriteLine("3. Chocolate");
                Console.WriteLine("4. Capuchino");

                Console.Write("\nSeleccione una bebida: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Café - RD$50");
                        break;

                    case 2:
                        Console.WriteLine("Té - RD$40");
                        break;

                    case 3:
                        Console.WriteLine("Chocolate - RD$60");
                        break;

                    case 4:
                        Console.WriteLine("Capuchino - RD$80");
                        break;

                    default:
                        Console.WriteLine("Opción no disponible.");
                        break;
                }
            }

            // 10. Estaciones del año
            static void EstacionesAnio()
            {
                Console.Write("Ingrese un mes: ");
                string mes = Console.ReadLine().ToLower();

                switch (mes)
                {
                    case "diciembre":
                    case "enero":
                    case "febrero":
                        Console.WriteLine("Invierno");
                        break;

                    case "marzo":
                    case "abril":
                    case "mayo":
                        Console.WriteLine("Primavera");
                        break;

                    case "junio":
                    case "julio":
                    case "agosto":
                        Console.WriteLine("Verano");
                        break;

                    case "septiembre":
                    case "octubre":
                    case "noviembre":
                        Console.WriteLine("Otoño");
                        break;

                    default:
                        Console.WriteLine("Mes inválido.");
                        break;
                }
            }
        }
    }
}