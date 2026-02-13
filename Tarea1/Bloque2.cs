using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Bloque2
    {
        //lo mismo que en el primer bloque cree un menu
        public static void Menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("===== BLOQUE 2 :ESTRUCTURAS DE CONTROL - CONDICIONALES=====");
                Console.WriteLine("9. Clasificación de triángulos");
                Console.WriteLine("10. Sistema de calificaciones UNAH");
                Console.WriteLine("11. Calculadora de descuentos");
                Console.WriteLine("12. Año bisiesto y días del mes");
                Console.WriteLine("13. Validador de fecha");
                Console.WriteLine("14. Cajero automático");
                Console.WriteLine("0. Volver");
                Console.WriteLine("Opción: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 9: Triangulo(); break;
                    case 10: Calificaciones(); break;
                    case 11: Descuento(); break;
                    case 12: Bisiesto(); break;
                    case 13: Fecha(); break;
                    case 14: Cajero(); break;
                }
            } while (op != 0);
        }

        //9. Ejercicio Clasificacion de triangulos
        static void Triangulo()
        {
            Console.Clear();
            Console.WriteLine("\n---CLASIFICACION DE TRIANGULOS ---");
            Console.WriteLine("Lado 1: "); 
            double lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado 2: "); 
            double lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado 3: "); 
            double lado3 = double.Parse(Console.ReadLine());

            if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2|| lado2 + lado3<= lado1)
                Console.WriteLine("No es triángulo válido");
            else
            {
                if (lado1 == lado2 && lado2 == lado3) 
                    Console.WriteLine("Equilátero");
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) 
                    Console.WriteLine("Isósceles");
                else 
                    Console.WriteLine("Escaleno");
            }
            Console.ReadKey();
        }
        

        //10. Ejercicio de calificaciones UNAH
        static void Calificaciones()
        {
            //pedimos las notas y las clasificamos en A,B,C,D y F
            Console.Clear();
             Console.WriteLine("\n---SISTEMA DE CALIFICACIONES UNAH ---");
            Console.WriteLine("Ingrese nota (0-100): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota < 0 || nota > 100)
                Console.WriteLine("Nota inválida");
            else if (nota >= 90) 
                Console.WriteLine("A - Excelente");
            else if (nota>= 80) 
                Console.WriteLine("B - Muy bien");
            else if (nota >= 70) 
                Console.WriteLine("C - Aprobado");
            else if (nota >= 60) 
                Console.WriteLine("D - Reprobado");
            else 
                Console.WriteLine("F - Reprobado");

            Console.ReadKey();
        }

        //11. Ejercicio Calculadora de descuentos
        static void Descuento()
        {
            Console.Clear();
            Console.WriteLine("\n---CALCULADORA DE DESCUENTOS---");
            Console.WriteLine("Monto compra: ");
            double monto = double.Parse(Console.ReadLine());
            double descuento = 0;

            if (monto>= 2500) 
                descuento = 0.15;
            else if (monto >= 1000) 
                descuento = 0.10;
            else if (monto>= 500) 
                descuento = 0.05;

            Console.WriteLine("Descuento: " + (monto * descuento));
            Console.WriteLine("Total: " + (monto - (monto * descuento)));

            Console.ReadKey();
        }


        //12. Ejercicio año bisiesto y dias del mes

    static void Bisiesto()
    {
        //ingreso el año, y el mes en numero
        Console.Clear();
        Console.WriteLine("\n---AÑO BISIESTO Y DIAS DEL MES---");
        Console.WriteLine("Año: ");
        int año= int.Parse(Console.ReadLine());

        Console.WriteLine("Mes (1-12): ");
        int mes = int.Parse(Console.ReadLine());

        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            Console.WriteLine("Es bisiesto");
        else
            Console.WriteLine("No es bisiesto");

        if (mes < 1 || mes > 12)
        {
            Console.WriteLine("Mes inválido");
            Console.ReadKey();
            return;
        }

        if (mes == 2)
        {
            if ((año % 4 == 0 && año % 100 != 0) || ( año% 400 == 0))
                Console.WriteLine("El mes tiene 29 días");
            else
                Console.WriteLine("El mes tiene 28 días");
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            Console.WriteLine("El mes tiene 30 días");
        }
        else
        {
            Console.WriteLine("El mes tiene 31 días");
        }

        Console.ReadKey();
    }

        //13. Ejercicio validador de fecha
    static void Fecha()
    {
        //pedimos el dia, el mes y el año
        Console.Clear();
        Console.WriteLine("\n---VALIDADOR DE FECHA---");
        Console.WriteLine("Día: ");
        int dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Mes (1-12): ");
        int mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Año: ");
        int año = int.Parse(Console.ReadLine());

        //validamos que el mes sea del 1-12
        if (mes < 1 || mes > 12)
        {
            Console.WriteLine("Fecha inválida");
            Console.ReadKey();
            return;
        }

        //validamos que el dia sea mayor que 1
        if (dia < 1)
        {
            Console.WriteLine("Fecha inválida");
            Console.ReadKey();
            return;
        }

        //trabajamos con febrero
        if (mes == 2)
        {
            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                if (dia > 29)
                {
                    Console.WriteLine("Fecha inválida");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                if (dia > 28)
                {
                    Console.WriteLine("Fecha inválida");
                    Console.ReadKey();
                    return;
                }
            }
        }
        //trabajamos con los meses que tienen 30 dias
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            if (dia > 30)
            {
                Console.WriteLine("Fecha inválida");
                Console.ReadKey();
                return;
            }
        }
        //por ultimo los que tienen 31 dias
        else
        {
            if (dia > 31)
            {
                Console.WriteLine("Fecha inválida");
                Console.ReadKey();
                return;
            }
        }
        //validamos la fecha
        Console.WriteLine("Fecha válida");
        Console.ReadKey();

    }

        //14. Ejercicio Cajero automatico
    static void Cajero()
    {
        Console.Clear();
        Console.WriteLine("\n---CAJERO AUTOMATICO---");
        int saldo = 10000; //inicializo con un saldo de 10000

        Console.Write("Monto a retirar: ");
        int m = int.Parse(Console.ReadLine());

        //si no es multiplo de 20 y es mayor que mi saldo lo invalido
        if (m % 20 != 0 || m > saldo || m <= 0)
        {
            Console.WriteLine("Operación inválida");
            Console.ReadKey();
            return;
        }
        // de lo contrario acepto el retiro y desgloso los billetes entregados
        Console.WriteLine("Retiro exitoso");
        Console.WriteLine("Desglose de billetes:");

        int b500 = m / 500;
        m = m % 500;

        int b200 = m / 200;
        m = m % 200;

        int b100 = m / 100;
        m = m % 100;

        int b50 = m / 50;
        m = m % 50;

        int b20 = m / 20;

        if (b500 > 0) Console.WriteLine("Billetes de 500: " + b500);
        if (b200 > 0) Console.WriteLine("Billetes de 200: " + b200);
        if (b100 > 0) Console.WriteLine("Billetes de 100: " + b100);
        if (b50 > 0) Console.WriteLine("Billetes de 50: " + b50);
        if (b20 > 0) Console.WriteLine("Billetes de 20: " + b20);

        Console.ReadKey();
    }
}

}


