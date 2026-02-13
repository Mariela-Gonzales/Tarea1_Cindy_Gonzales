// See https://aka.ms/new-console-template for more information

using System;
using Tarea1;

class Program
{
    static void Main()
    {
        int op;

        do
        {
            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Abrir Bloque 1");
            Console.WriteLine("2. Abrir Bloque 2");
            Console.WriteLine("3. Abrir Bloque 3");
            Console.WriteLine("4. Abrir Bloque 4");
            Console.WriteLine("5. Abrir Bloque 5");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Seleccione una opción: ");

            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Bloque1.Menu();
                    break;

                case 2:
                    Bloque2.Menu();
                    break;
                case 3:
                    Bloque3.Menu();
                    break;
                case 4:
                    Bloque4.Menu();
                    break;
                case 5:
                    Bloque5.Menu();
                    break;
                case 6:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.ReadKey();

        } while (op != 4);
    }
}
