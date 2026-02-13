using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Bloque4
    {
        public static void Menu()
        {
            int opcion; 

            do
            {
                Console.Clear(); 
                Console.WriteLine("===== BLOQUE 4: ARREGLOS UNIDIMENSIONALES =====");
                Console.WriteLine("23. Estadisticas de calificaciones");
                Console.WriteLine("24. Busqueda y ordenamiento");
                Console.WriteLine("25. Rotacion de arreglo");
                Console.WriteLine("26. Frecuencia de elementos");
                Console.WriteLine("27. Arreglo de temperaturas");
                Console.WriteLine("0. Volver"); //esta opcion no funciona y no se porque 
                Console.WriteLine("Opción: ");

                opcion = int.Parse(Console.ReadLine()); 

                switch (opcion)
                {
                    case 23: EstadisticasdeCalificaciones(); 
                    break;
                    case 24: BusquedaOrdenamiento(); 
                    break;
                    case 25: RotacionArreglo(); 
                    break;
                    case 26: FrecuenciaElementos(); 
                    break;
                    case 27: ArregloTemperatura(); 
                    break;
                }

            } while (opcion != 0); 
        }

        // 23. Ejercicio estadistica de calificaciones 
        public static void EstadisticasdeCalificaciones()
        {
            Console.Clear();
            Console.WriteLine("\n---ESTADISTICA DE CALIFIACIONES---");
            Console.WriteLine("Cantidad de notas: "); //pedimos al usuario la cantidad de notas
            int n = int.Parse(Console.ReadLine());

            // esto es para evitar que el usuario introduzca que quiera 0 notas ya que debe agregarlas
            if (n <= 0)
            {
                Console.WriteLine("Debe ingresar al menos una nota.");
                return;
            }

            double[] notas = new double[n]; //hacemos un arrgelo

            double suma = 0;
            int aprobados = 0;
            int reprobados = 0;

            // Ingresamos la primera nota fuera del ciclo
            Console.WriteLine("Nota 1: ");
            notas[0] = double.Parse(Console.ReadLine());

            suma = notas[0];          // Inicializamos suma
            double mayor = notas[0];  // La primera es la mayor inicialmente
            double menor = notas[0];  // La primera es la menor inicialmente

            if (notas[0] >= 60)
                aprobados++;
            else
                reprobados++;

            // Desde la segunda nota en adelante
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Nota " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());

                suma += notas[i];

                if (notas[i] > mayor)
                    mayor = notas[i];

                if (notas[i] < menor)
                    menor = notas[i];

                if (notas[i] >= 60)
                    aprobados++;
                else
                    reprobados++;
            }

            double promedio = suma / n;

            Console.WriteLine("\nPromedio: " + promedio);
            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Reprobados: " + reprobados);
    }


        // 24. Ejercicio busqueda y ordenamiento 
       
        public static void BusquedaOrdenamiento()
        {
            Console.Clear();
            Console.WriteLine("\n---BUSQUEDA Y ORDENAMIENTO---");

            int[] numeros = new int[10]; // Arreglo de tamaño fijo

            // Llenamos el arreglo
            for (int posicion = 0; posicion < 10; posicion++)
            {
                Console.Write("Número en posición " + posicion + ": ");
                numeros[posicion] = int.Parse(Console.ReadLine());
            }

            // Método burbuja para ordenar
            for (int recorrido = 0; recorrido < 9; recorrido++)
            {
                for (int comparacion = 0; comparacion < 9 - recorrido; comparacion++)
                {
                    // Si el actual es mayor que el siguiente, intercambiamos
                    if (numeros[comparacion] > numeros[comparacion + 1])
                    {
                        int auxiliar = numeros[comparacion];
                        numeros[comparacion] = numeros[comparacion + 1];
                        numeros[comparacion + 1] = auxiliar;
                    }
                }
            }

            // Mostramos arreglo ordenado
            Console.WriteLine("\nArreglo ordenado:");
            for (int posicion = 0; posicion < 10; posicion++)
            {
                Console.WriteLine(numeros[posicion]);
            }

            // Búsqueda secuencial
            Console.Write("\nNúmero a buscar: ");
            int buscar = int.Parse(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] == buscar)
                {
                    Console.WriteLine("Encontrado en la posición " + i);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                Console.WriteLine("Número no encontrado.");
        }


         public static void RotacionArreglo()
        {
            Console.Clear();
            Console.WriteLine("Tamaño del arreglo: ");  // Pedimos el tamaño del arreglo
            int tamañoArreglo = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamañoArreglo];

            for (int posicion = 0; posicion < tamañoArreglo; posicion++) // Llenamos el arreglo con los números que el usuario ingresa
            {
                Console.WriteLine("Número en posición " + posicion + ": ");
                numeros[posicion] = int.Parse(Console.ReadLine());
            }

            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=====> MENÚ ROTACIÓN DE ARREGLO <=====");
                Console.WriteLine("1. Rotar posiciones a la derecha");
                Console.WriteLine("2. Rotar posiciones a la izquierda");
                Console.WriteLine("3. Invertir arreglo");
                Console.WriteLine("4. Mostrar arreglo");
                Console.WriteLine("0. Salir");
                Console.WriteLine ("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // Rotar a la derecha
                        Console.WriteLine ("¿Cuántas posiciones desea rotar a la derecha?: ");
                        int rotacionesDerecha = int.Parse(Console.ReadLine());
                        rotacionesDerecha = rotacionesDerecha % tamañoArreglo; // Evita rotaciones innecesarias

                        // Repetimos el proceso según el número de rotaciones
                        for (int r = 0; r < rotacionesDerecha; r++)
                        {
                            int ultimo = numeros[tamañoArreglo - 1]; // se guarda el último arreglo
                            for (int i = tamañoArreglo - 1; i > 0; i--)
                            {
                                numeros[i] = numeros[i - 1]; // Desplazamos los elementos a la derecha
                            }
                            numeros[0] = ultimo; // Colocamos el último al inicio
                        }
                        Console.WriteLine("Arreglo rotado a la derecha:");
                        break;

                    case 2: // Rotar a la izquierda
                        Console.WriteLine("¿Cuántas posiciones desea rotar a la izquierda?: ");
                        int rotacionesIzquierda = int.Parse(Console.ReadLine());
                        rotacionesIzquierda = rotacionesIzquierda % tamañoArreglo;

                        // Repetimos el proceso según el número de rotaciones
                        for (int r = 0; r < rotacionesIzquierda; r++)
                        {
                            int primero = numeros[0]; // Guardamos el primero
                            for (int i = 0; i < tamañoArreglo - 1; i++)
                            {
                                numeros[i] = numeros[i + 1]; // Desplazamos los elementos a la izquierda
                            }
                            numeros[tamañoArreglo - 1] = primero; // Colocamos el primero al final
                        }
                        Console.WriteLine("Arreglo rotado a la izquierda:");
                        break;

                    case 3: // Invertir arreglo
                        for (int i = 0; i < tamañoArreglo / 2; i++)
                        {
                            int temp = numeros[i]; // Guardamos temporalmente el valor
                            numeros[i] = numeros[tamañoArreglo - 1 - i]; // Intercambiamos elementos
                            numeros[tamañoArreglo - 1 - i] = temp;
                        }
                        Console.WriteLine("Arreglo invertido:");
                        break;

                    case 4: // Mostrar arreglo actual
                        Console.WriteLine("Arreglo actual:");
                        break;

                    case 0: // Salir del menú
                        Console.WriteLine("Saliendo del menú...");
                        continue;

                    default: // Opción inválida
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                // Mostrar arreglo después de cada operación
                if (opcion != 0)
                {
                    for (int i = 0; i < tamañoArreglo; i++)
                    {
                        Console.WriteLine(numeros[i]);
                    }
                    Console.ReadKey();
                }

            } while (opcion != 0);
            //==============EN ESTE EJERCICIO ME APOYE DE IA======================================
        }

        // 26.Ejercicio frecuencia de elementos
      
        public static void FrecuenciaElementos()
        {
            Console.Clear();
            Console.WriteLine("\n---FRECUENCIA DE ELEMENTOS---");
            Random generadorAleatorio = new Random(); // Creamos un generador de números aleatorios

            int[] numerosGenerados = new int[20];   // Arreglo para guardar los 20 números generados
            int[] contadorFrecuencia = new int[11]; // Contador de frecuencia para números del 1 al 10

            // Generamos 20 números aleatorios
            for (int i = 0; i < 20; i++)
            {
                // Generamos un número aleatorio entre 1 y 10
                numerosGenerados[i] = generadorAleatorio.Next(1, 11);

                // Aumentamos el contador de frecuencia 
                contadorFrecuencia[numerosGenerados[i]]++;
            }

            // Mostramos la lista completa de números generados
            Console.WriteLine("Números generados:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(numerosGenerados[i] + " "); // Imprime cada número separado por espacio
            }

            Console.WriteLine("\n\nFrecuencia de cada número:");

            // Mostramos cuántas veces salió cada número
            for (int numero = 1; numero <= 10; numero++)
            {
                Console.WriteLine("Número " + numero + " salió " + contadorFrecuencia[numero] + " veces");
            }
        }

        // 27. Ejercicio arreglo de temperaturas 
        public static void ArregloTemperatura()
        {
            Console.Clear();
            Console.WriteLine("\n---ARREGLO DE TEMPERATURAS---");

            double[] temperaturasSemana = new double[7]; // hacemo un arreglo para los 7 días de la semana
            double sumaTemperaturas = 0;                 // Aaqui vamos a acumular las temperaturas para calcular promedio

            // Pedimos la temperatura del primer día y la usamos para inicializar mayor y menor
            Console.WriteLine("Temperatura del día 1: ");
            temperaturasSemana[0] = double.Parse(Console.ReadLine());
            sumaTemperaturas += temperaturasSemana[0];

            double temperaturaMayor = temperaturasSemana[0]; // Inicializamos con el primer valor
            double temperaturaMenor = temperaturasSemana[0]; // Inicializamos con el primer valor

            // Pedimos temperaturas del día 2 al día 7
            for (int dia = 1; dia < 7; dia++)
            {
                Console.WriteLine ("Temperatura del día " + (dia + 1) + ": ");
                temperaturasSemana[dia] = double.Parse(Console.ReadLine());

                sumaTemperaturas += temperaturasSemana[dia]; // Sumamos para el promedio

                // Actualizamos la temperatura mayor si es necesario
                if (temperaturasSemana[dia] > temperaturaMayor)
                    temperaturaMayor = temperaturasSemana[dia];

                // Actualizamos la temperatura menor si es necesario
                if (temperaturasSemana[dia] < temperaturaMenor)
                    temperaturaMenor = temperaturasSemana[dia];
            }

            // Calculamos el promedio semanal
            double promedioSemanal = sumaTemperaturas / 7;

            Console.WriteLine("\nPromedio semanal: " + promedioSemanal);
            Console.WriteLine("Temperatura mayor: " + temperaturaMayor);
            Console.WriteLine("Temperatura menor: " + temperaturaMenor);
        }
    }
}