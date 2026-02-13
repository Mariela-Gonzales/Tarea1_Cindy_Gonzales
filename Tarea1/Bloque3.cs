using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1
{
    //Creamos menu
    public class Bloque3
    {
        public static void Menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("===== BLOQUE 3: ESTRUCTURAS DE CONTROL - CICLOS =====");
                Console.WriteLine("15. Tabla de multiplicar");
                Console.WriteLine("16. Primos en rango");
                Console.WriteLine("17. Fibonacci");
                Console.WriteLine("18. Factorial");
                Console.WriteLine("19. Adivinanza");
                Console.WriteLine("20. Validar Contraseña");
                Console.WriteLine("21. Patron de Asteriscos");
                Console.WriteLine("22. Calculadora con Menu");
                Console.WriteLine("0. Volver");
                Console.WriteLine("Opción: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 15: Tabla(); break;
                    case 16: Primos(); break;
                    case 17: Fibonacci(); break;
                    case 18: Factorial(); break;
                    case 19: Juego(); break;
                    case 20: ValidarContraseña (); break;
                    case 21: PatrondeAsteriscos (); break;
                    case 22: CalculadoraconMenu (); break;
    
                }
            } while (op != 0);
        }

        //15. Ejercicio de tablas de multiplicar
    static void Tabla()
    {
        //pido al usuario que ingrese el numero que quiere conocer la tabla
        Console.Clear();
        Console.WriteLine("\n---TABLA DE MULTIPLICAR EXTENDIDA---");
        Console.WriteLine("Ingrese Número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));

        Console.ReadKey();
    }

        //16.Ejercicio de numeros primos con rango
        static void Primos()
        {
            //pedimos el inicio y el final del rango y luego calculamos los nuneros primos en ese rango
            Console.Clear();
            Console.WriteLine("\n---NUMEROS PRIMOS EN RANGO---");
            Console.WriteLine("Inicio del rango: "); 
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Fin del rango: "); 
            int final = int.Parse(Console.ReadLine());

        //calculo los numeros primos
           for (int i = inicio; i <= final; i++)
        {
            if (i <= 1) 
                continue;

            int j;
            for (j = 2; j < i; j++)
            {
                if (i % j == 0)
                    break;
            }

            if (j == i)
                Console.WriteLine(i);
        }

            Console.ReadKey();
        }

        //17.  Ejercicio de serie Fibonacci
        static void Fibonacci()
        {
            // pedir la cantidad de terminos y luego se suman los terminos y se muestra el promedio
            Console.Clear();
            Console.WriteLine("\n---SERIE FIBONACCI---");
            Console.WriteLine("Ingrese la cantidad de terminos Fibonacci: ");
            int n = int.Parse(Console.ReadLine());

            int numeroActual = 0, siguienteNumero = 1; // iniciamos los valores de Fibonacci
            int sumaTotal = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numeroActual);
                sumaTotal = sumaTotal + numeroActual;

                int suma = numeroActual + siguienteNumero; // calculamos el siguiente valor de Fibonacci
                numeroActual = siguienteNumero;
                siguienteNumero = suma;
            }

            double promedio = (double)sumaTotal / n;
            Console.WriteLine("Promedio: " + promedio);

            Console.ReadKey();
        }


        //18.Ejercicio de factoriales y combinaciones
        static void Factorial()
        {
            //pedimos el numero al que le calularemos el factorial
            Console.Clear();
            Console.WriteLine("\n---FACTORIAL--");
            Console.WriteLine("Número: ");
            int n = int.Parse(Console.ReadLine());

            //inicializamos el factorial en 1
            int factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial = factorial* i; //acumulamos el factorial

            Console.WriteLine("Factorial: " + factorial);
            Console.ReadKey();
        }

        //19. Ejercicio juego de adivinanza
        static void Juego()
        {
            Console.Clear();
            Console.WriteLine("\n---JUEGO DE ADIVINANZA---");
            Random random = new Random(); // generador de números aleatorios
            int numeroGanador = random.Next(1, 101); // número que el jugador debe adivinar
            int n=0;
            int intentos = 0; // contador de intentos
            int maxIntentos = 7;

            do
            {
                if (intentos >= maxIntentos)
                {
                    Console.WriteLine("Se acabaron los intentos. El número era: " + numeroGanador);
                    break; // salimos del juego
                }

                // pedimos al usuario que adivine el número
                Console.WriteLine("Adivina: ");
                n = int.Parse(Console.ReadLine());
                intentos++; // sumamos un intento

                // pistas para el jugador
                if (n < numeroGanador) Console.WriteLine("Mayor");
                if (n > numeroGanador) Console.WriteLine("Menor");

            } while (n != numeroGanador);

            if (n== numeroGanador)
                Console.WriteLine("¡Correcto! Lo adivinaste en " + intentos + " intentos.");

            Console.ReadKey();
        }


    //20.Ejercicio de validar contraseña
       static void ValidarContraseña()
        {
            Console.Clear();
            Console.WriteLine("\n---VALIDACION DE CONTRASEÑA---");
            string contraseña;
            bool contraseñaValida; //usamos bool para validad si es verdadero o falso

            //usamos bool
            do
            {
                contraseñaValida = true;

                bool tieneMayuscula = false;
                bool tieneMinuscula = false;
                bool tieneNumero = false;
                bool tieneEspecial = false;

                Console.Write("Ingrese contraseña: ");
                contraseña = Console.ReadLine();
                //usamos length para ver la cantidad de caracteres 
                if (contraseña.Length < 8)
                {
                    Console.WriteLine("Falta: minimo 8 caracteres");
                    contraseñaValida = false;
                }
                //revisamos cada caracter 
                for (int posicion = 0; posicion < contraseña.Length; posicion++)
                {
                    char caracter = contraseña[posicion];
                //validamos la contraseña
                    if (caracter >= 'A' && caracter <= 'Z')
                        tieneMayuscula = true;
                    else if (caracter >= 'a' && caracter <= 'z')
                        tieneMinuscula = true;
                    else if (caracter >= '0' && caracter <= '9')
                        tieneNumero = true;
                    else
                        tieneEspecial = true;
                }

                //si no cumple con los requisitos le decimos al usuario que lo corrija
                if (!tieneMayuscula)
                {
                    Console.WriteLine("Falta: una letra mayuscula");
                    contraseñaValida = false;
                }

                if (!tieneMinuscula)
                {
                    Console.WriteLine("Falta: una letra minuscula");
                    contraseñaValida = false;
                }

                if (!tieneNumero)
                {
                    Console.WriteLine("Falta: un numero");
                    contraseñaValida = false;
                }

                if (!tieneEspecial)
                {
                    Console.WriteLine("Falta: un caracter especial");
                    contraseñaValida = false;
                }

                Console.WriteLine();

            } while (!contraseñaValida);

            Console.WriteLine("Contraseña valida");
            Console.ReadKey();
        }


     //21.Ejercicio patron de asteriscos
   static void PatrondeAsteriscos()
        {
            Console.Clear();
            Console.WriteLine("\n---PATRON DE ASTERISCOS---");
            int op, n;

            // pedir tamaño del patrón
            Console.WriteLine("Tamaño del patrón: ");
            n = int.Parse(Console.ReadLine());

            // hacemos un menu para que el usuario elija el tipo de patron
            Console.WriteLine("1. Triángulo");
            Console.WriteLine("2. Triángulo invertido");
            Console.WriteLine("3. Cuadrado hueco");
            Console.WriteLine("Opción: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: // Trabajamos con la opcion 1 que es el triangulo
                    for (int filas = 1; filas <= n; filas++)
                    {
                        for (int asteriscos = 1; asteriscos <= filas; asteriscos++)
                            Console.WriteLine("*");
                        Console.WriteLine();
                    }
                    break;

                case 2: //opcion 2 Triángulo invertido
                    for (int filas = n; filas >= 1; filas--)
                    {
                        for (int asteriscos = 1; asteriscos <= filas; asteriscos++)
                            Console.WriteLine("*");
                        Console.WriteLine();
                    }
                    break;

                case 3: // opcion 3 Cuadrado hueco
                    for (int filas = 1; filas <= n; filas++)
                    {
                        for (int asteriscos = 1; asteriscos <= n; asteriscos++)
                        {
                            if (filas == 1 || filas == n || asteriscos == 1 || asteriscos == n)
                                Console.WriteLine("*");
                            else
                                Console.WriteLine(" ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }

            Console.ReadKey();
        }

         //22.Ejercicio de Calculadora con menu
        static void CalculadoraconMenu()
        {
            Console.Clear();
            Console.WriteLine("\n---CALCULADORA CON MENU---");
            int op = 0;
            double resultado = 0, segundoNumero; // resultado acumula resultados, segundoNumero es el número que ingresa el usuario
            bool tieneResultado = false; // controla si ya se ingreso un número inicial

            while (op != 8)
            {
                // Mostrar menú
                Console.WriteLine("\n--- CALCULADORA ---");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                op = int.Parse(Console.ReadLine());

                if (op == 8) break; // salir del bucle

                // Pedir número inicial si aún no lo tenemos
                if (!tieneResultado)
                {
                    Console.Write("Ingrese número: ");
                    resultado = double.Parse(Console.ReadLine());
                    tieneResultado = true;
                }

                // Pedir segundo número solo si la operación lo necesita
                if (op != 6) // la raíz cuadrada no necesita segundo número
                {
                    Console.WriteLine("Ingrese otro número: ");
                    segundoNumero = double.Parse(Console.ReadLine());
                }
                else
                {
                    segundoNumero = 0; // aplica para raíz cuadrada
                }

                // Ejecutar operación según la opción
                switch (op)
                {
                    case 1: // suma
                        resultado += segundoNumero;
                        break;
                    case 2: // resta
                        resultado -= segundoNumero;
                        break;
                    case 3: // multiplicación
                        resultado *= segundoNumero;
                        break;
                    case 4: // división
                        if (segundoNumero != 0)
                            resultado /= segundoNumero;
                        else
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        break;
                    case 5: // potencia
                        resultado = Math.Pow(resultado, segundoNumero);
                        break;
                    case 6: // raíz cuadrada
                        if (resultado >= 0)
                            resultado = Math.Sqrt(resultado);
                        else
                            Console.WriteLine("Error: No se puede calcular raíz de un número negativo.");
                        break;
                    case 7: // porcentaje
                        resultado = resultado * segundoNumero / 100;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("Resultado actual: " + resultado);
            }

            Console.WriteLine("Calculadora finalizada.");
            Console.ReadKey();
        }


        }





        
    
}
