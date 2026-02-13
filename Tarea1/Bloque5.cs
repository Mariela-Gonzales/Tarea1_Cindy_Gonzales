using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Bloque5
    {
                public static void Menu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===== BLOQUE 5: ARREGLOS BIDIMENSIONALES =====");
                Console.WriteLine("28. Matriz de notas por parcial");
                Console.WriteLine("29. juego tic tac toe");
                Console.WriteLine("30. Inventario simple");
                Console.WriteLine("0. Volver");
                Console.WriteLine("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 28: MatrizDeNotasPorParcial(); 
                    break;
                    case 29: TicTacToe();
                    break;
                    case 30: InventarioSimple(); 
                    break;
                }
            } while (opcion != 0);

        }

        //28. Ejercicio de matriz con notas de parcial 
        public static void MatrizDeNotasPorParcial()
        {
            Console.Clear(); 
            Console.WriteLine("\n---MATRIZ DE NOTAS POR PARCIAL ---");
            Console.WriteLine ("Cantidad de estudiantes: ");    //Pedimos cantidad de estudiantes
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            //Creamos matriz principal Filas = estudiantes y Columnas = 3 parciales
            double[,] matrizNotas = new double[cantidadEstudiantes, 3];

            // LLENAMOS LA MATRIZ
            for (int estudiante = 0; estudiante < cantidadEstudiantes; estudiante++)
            {
                Console.WriteLine("\nEstudiante " + (estudiante + 1));

                for (int parcial = 0; parcial < 3; parcial++)
                {
                    Console.WriteLine("Nota del parcial " + (parcial + 1) + ": ");
                    matrizNotas[estudiante, parcial] = double.Parse(Console.ReadLine());
                }
            }

            // hacemos una matriz para promedios Fila 0 → promedios por estudiante Fila 1 → promedios por parcial
            double[,] matrizPromedios = new double[2, cantidadEstudiantes > 3 ? cantidadEstudiantes : 3];

            // Calculamos el promedio por estudiante 
            Console.WriteLine("\n--- Promedio por estudiante ---");

            for (int estudiante = 0; estudiante < cantidadEstudiantes; estudiante++)
            {
                double suma = 0;

                for (int parcial = 0; parcial < 3; parcial++)
                {
                    suma += matrizNotas[estudiante, parcial];
                }

                matrizPromedios[0, estudiante] = suma / 3;

                Console.WriteLine("Promedio estudiante " +
                                (estudiante + 1) + ": " +
                                matrizPromedios[0, estudiante]);
            }

            // calculamos el promedio por parciañ
            Console.WriteLine("\n--- Promedio por parcial ---");

            for (int parcial = 0; parcial < 3; parcial++)
            {
                double suma = 0;

                for (int estudiante = 0; estudiante < cantidadEstudiantes; estudiante++)
                {
                    suma += matrizNotas[estudiante, parcial];
                }

                matrizPromedios[1, parcial] = suma / cantidadEstudiantes;

                Console.WriteLine("Promedio parcial " +
                                (parcial + 1) + ": " +
                                matrizPromedios[1, parcial]);
            }

            //Buscamos al mejor estduiante 
            int mejorEstudiante = 0;

            for (int i = 1; i < cantidadEstudiantes; i++)
            {
                if (matrizPromedios[0, i] > matrizPromedios[0, mejorEstudiante])
                {
                    mejorEstudiante = i;
                }
            }

            // buscamos el parcial mas dificil 
            int parcialMasDificil = 0;

            for (int i = 1; i < 3; i++)
            {
                if (matrizPromedios[1, i] < matrizPromedios[1, parcialMasDificil])
                {
                    parcialMasDificil = i;
                }
            }

            Console.WriteLine("\n--- RESULTADOS FINALES ---");

            Console.WriteLine("Mejor estudiante: " + (mejorEstudiante + 1) + " con promedio " + matrizPromedios[0, mejorEstudiante]);

            Console.WriteLine("Parcial más difícil: " +
                            (parcialMasDificil + 1) + " con promedio " + matrizPromedios[1, parcialMasDificil]);

            Console.ReadKey();
        }
        //29. Ejercicio del juego tic tac toe
          public static void TicTacToe()
        { 
            Console.WriteLine("\n--- JUEGO TICTACTOE ---");
            Console.WriteLine("\n--- No le entendi ---");
            Console.ReadKey();
        }
        public static void InventarioSimple()
        {
            Console.WriteLine("\n---INVENTARIO SIMPLE ---");
            double[,] productos = new double[5, 3];

            // use IA para el arreglo pararalelo
            string[] nombres = new string[5];
            int opcion;

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                Console.WriteLine("\nProducto #" + (i + 1));

                Console.Write("Código: ");
                productos[i, 0] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Cantidad: ");
                productos[i, 1] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Precio: ");
                productos[i, 2] = Convert.ToDouble(Console.ReadLine());
            }

            do
            {
                Console.Clear();
                Console.WriteLine("===== MENÚ INVENTARIO =====");
                Console.WriteLine("1. Mostrar inventario");
                Console.WriteLine("2. Buscar producto");
                Console.WriteLine("3. Actualizar cantidad");
                Console.WriteLine("4. Calcular valor total del inventario");
                Console.WriteLine("5. Salir");
                Console.WriteLine ("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarInventario(productos, nombres);
                        break;

                    case 2:
                        BuscarProducto(productos, nombres);
                        break;

                    case 3:
                        ActualizarCantidad(productos);
                        break;

                    case 4:
                        CalcularTotal(productos);
                        break;

                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 5);
        }

        static void MostrarInventario(double[,] productos, string[] nombres)
        {
            Console.WriteLine("\n===== INVENTARIO =====");

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                Console.WriteLine("Código: " + productos[i, 0]);
                Console.WriteLine("Nombre: " + nombres[i]);
                Console.WriteLine("Cantidad: " + productos[i, 1]);
                Console.WriteLine("Precio: " + productos[i, 2]);
                Console.WriteLine("-------------------------");
            }
        }

        static void BuscarProducto(double[,] productos, string[] nombres)
        {
            Console.Write("\nIngrese el código a buscar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                if (productos[i, 0] == codigo)
                {
                    Console.WriteLine("\nProducto encontrado:");
                    Console.WriteLine("Nombre: " + nombres[i]);
                    Console.WriteLine("Cantidad: " + productos[i, 1]);
                    Console.WriteLine("Precio: " + productos[i, 2]);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        static void ActualizarCantidad(double[,] productos)
        {
            Console.Write("\nIngrese el código del producto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                if (productos[i, 0] == codigo)
                {
                    Console.WriteLine("Cantidad actual: " + productos[i, 1]);
                    Console.Write("Nueva cantidad: ");
                    productos[i, 1] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cantidad actualizada correctamente.");
                    return;
                }
            }

            Console.WriteLine("Producto no encontrado.");
        }

        static void CalcularTotal(double[,] productos)
        {
            double total = 0;

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                total += productos[i, 1] * productos[i, 2];
            }

            Console.WriteLine("\nValor total del inventario: " + total);
        }
    }
}
     



