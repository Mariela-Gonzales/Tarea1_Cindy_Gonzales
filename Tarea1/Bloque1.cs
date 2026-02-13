using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Bloque1
    {
        //primero crearemos un menu para trabajar todos los ejercicios del bloque 1
        //en una sola clase
        public static void Menu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===== BLOQUE 1: Variables y Operadores =====");
                Console.WriteLine("1. Calculadora de IMC");
                Console.WriteLine("2. Conversión de temperatura");
                Console.WriteLine("3. Desglose de billetes");
                Console.WriteLine("4. Préstamo simple");
                Console.WriteLine("5. Tiempo transcurrido");
                Console.WriteLine("6. Área y perímetro");
                Console.WriteLine("7. Conversión almacenamiento");
                Console.WriteLine("8. Salario semanal");
                Console.WriteLine("0. Volver");
                Console.WriteLine("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: IMC(); 
                    break;
                    case 2: Temperatura();
                    break;
                    case 3: Billetes(); 
                    break;
                    case 4: Prestamo(); 
                    break;
                    case 5: Tiempo(); 
                    break;
                    case 6: AreaPerimetro(); 
                    break;
                    case 7: Almacenamiento(); 
                    break;
                    case 8: Salario(); 
                    break;
                }
            } while (opcion != 0);

        }


        // 1.Ejercicio de la calculadora IMC
        static void IMC()
        {
            Console.Clear();
            Console.WriteLine("\n---CALCULADORA IMC ---");
            Console.WriteLine("Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("IMC: " + imc);

             //Las categorías estándar son: Bajo peso (IMC < 18.5), 
             // Normal/Saludable (18.5-24.9),
             //  Sobrepeso (25-29.9) y Obesidad (>= 30)
            if (imc < 18.5) 
                Console.WriteLine("Bajo peso");
            else if (imc < 25) 
                Console.WriteLine("Normal");
            else if (imc < 30) 
                Console.WriteLine("Sobrepeso");
            else 
                Console.WriteLine("Obesidad");

            Console.ReadKey(); //lo uso para detener la ejecución del programa y 
            // esperar a que el usuario presione una tecla para continuar
        }
        

        // 2. Ejercicio de Conversión temperatura
        static void Temperatura()
        { 
            Console.Clear();
            Console.WriteLine("\n---CONVERSION DE TEMPERATURAS ---");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            Console.WriteLine("Opción: ");
            int op = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor: ");
            double valor = double.Parse(Console.ReadLine());

            //Covertimos 
            if (op == 1) 
                Console.WriteLine("Resultado: " + (valor * 9 / 5 + 32));
            if (op == 2) 
                Console.WriteLine("Resultado: " + ((valor - 32) * 5 / 9));
            if (op == 3) 
                Console.WriteLine("Resultado: " + (valor+ 273.15));

            Console.ReadKey();
        }

          
        // 3.Ejercicio de Billetes
        static void Billetes()
        {
            Console.Clear();
            Console.WriteLine("\n---DESGLOCE DE BILLETES ---");
            Console.WriteLine("Monto en Lempiras: ");
            int monto = int.Parse(Console.ReadLine());

            int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };

            //calculamos el desgloce del monto 
            for (int i = 0; i < billetes.Length; i++)
            {
                    int b = billetes[i];
                    Console.WriteLine(b + ": " + (monto / b));
                     monto %= b;
            }
            Console.ReadKey();
        }

        // 4.Ejercicio del Préstamo simple
        static void Prestamo()
        {
            //pedimos el monto del prestamo, lel porcentaje de la tasa anual de interes
            //  y la cantidad de meses 
            Console.Clear();
            Console.WriteLine("\n---CALCULADORA DE PRESTAMO SIMPLE ---");
            Console.WriteLine("Monto: ");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine("Tasa anual (%): ");
            double tasa = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine ("Meses: ");
            int meses = int.Parse(Console.ReadLine());

            //calculamos el interes y el total
            double interes = monto * tasa * (meses / 12.0);
            double total = monto + interes;

            Console.WriteLine("Interes: " + interes);
            Console.WriteLine("Cuota mensual: " + (total / meses));
            Console.ReadKey();
        }

        // 5. Ejercicio de Tiempo transcurrido
        static void Tiempo()
        {
        //pedimos la primer cantidad de horas, minutos y segundos
            Console.Clear();
            Console.WriteLine("\n---TIEMPO TRANSCURRIDO---");
            Console.WriteLine("Hora 1 (horas minutos segundos): ");
            int horas1 = int.Parse(Console.ReadLine());
            int minutos1 = int.Parse(Console.ReadLine());
            int segundos1 = int.Parse(Console.ReadLine());

        //pedimos la segunda cantidad de horas, minutos y segundos
            Console.WriteLine ("Hora 2 (horas minutos segundos): ");
            int horas2 = int.Parse(Console.ReadLine());
            int minutos2 = int.Parse(Console.ReadLine());
            int segundos2 = int.Parse(Console.ReadLine());

        //Convertimos todo a segundos tanto la primera como la segunda vez
            int totalSeg1 = horas1 * 3600 + minutos1 * 60 + segundos1;
            int totalSeg2 = horas2 * 3600 + minutos2 * 60 + segundos2;

        //Calculamos la diferencia de segundos y si la diferencia es menor a 0 le colocamos negativo
            int difSeg = totalSeg2 - totalSeg1;
            if (difSeg < 0) difSeg = -difSeg;

         //Convertimos los segundos a horas y minutos 
            int diferenciaHoras = difSeg / 3600;
            int diferenciaMinutos = (difSeg % 3600) / 60;
            int diferenciaSegundos = difSeg % 60;

        Console.WriteLine("Diferencia: " + diferenciaHoras + "h " + diferenciaMinutos + "m " + diferenciaSegundos + "s");
        Console.ReadKey();

        }


        // 6. Ejercicio de Área y perímetro 
         static void AreaPerimetro()

    {
        Console.WriteLine("\n---AREA Y PERIMETRO---");
        //creamos un menu ya que son varias areas y perimetros
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== Calculadora de Área y Perímetro ===");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Trapecio");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opción: ");
            
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Rectangulo(); 
                        break;
                case 2: Circulo(); 
                        break;
                case 3: Triangulo(); 
                        break;
                case 4: Trapecio(); 
                        break;
                case 5: Console.WriteLine("Saliendo..."); 
                        break;
                default: Console.WriteLine("Opción inválida."); 
                        break;
            }

            if (opcion != 5)
            {
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5);
    }

    //validamos que los valores sean positivos
        static double Positivo(string mensaje)
    {
        double valor;
        do
        {
            Console.Clear();
            Console.WriteLine(mensaje);
            valor = double.Parse(Console.ReadLine());
            if (valor <= 0)
                Console.WriteLine("Error: el valor debe ser positivo.");
        } while (valor <= 0);
        return valor;
    }

    //trabajamos con el area y el perimetro del rectangulo
      static void Rectangulo()
    {
        Console.Clear();
        Console.WriteLine("=== Rectángulo ===");
        double baseR = Positivo("Base: ");
        double alturaR = Positivo("Altura: ");

        double area = baseR * alturaR;
        double perimetro = 2 * (baseR + alturaR);

        Console.WriteLine("Área: " + area);
        Console.WriteLine("Perímetro: " + perimetro);
    }

     //trabajamos con el area y el perimetro del circulo
      static void Circulo()
        {
            Console.Clear();
            Console.WriteLine("=== Círculo ===");
        //pedimos el radio y que sea positivo
            double radio = Positivo("Radio: ");
            double pi = 3.1416;

            double area = pi * radio * radio;
            double perimetro = 2 * pi * radio;

            Console.WriteLine("Área: " + area);
            Console.WriteLine("Perímetro: " + perimetro);
        }


     //trabajamos con el area y el perimetro del triangulo
    static void Triangulo()
    {
        Console.Clear();
        Console.WriteLine("=== Triángulo ===");
        double a = Positivo("Lado a: ");
        
        double b = Positivo("Lado b: ");
        double c = Positivo("Lado c: ");

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Error: los lados no forman un triángulo válido.");
            return;
        }

        //calculo el semiperimetro y uso Math.Sqrt para calcular raiz y hacer uso de la formula de Heron
        double semiperimetro = (a + b + c) / 2;
        double area = Math.Sqrt(semiperimetro * (semiperimetro - a) * (semiperimetro) * (semiperimetro));
        double perimetro = a + b + c;

        Console.WriteLine("Área: " + area);
        Console.WriteLine("Perímetro: " + perimetro);
    }

     //trabajamos con el area y el perimetro del trapecio
        static void Trapecio()
    {
        Console.Clear();
        Console.WriteLine("=== Trapecio ===");
        double a = Positivo("Base mayor: ");
        double b = Positivo("Base menor: ");
        double h = Positivo("Altura: ");
        double lado1 = Positivo("Lado lateral 1: ");
        double lado2 = Positivo("Lado lateral 2: ");

        double area = ((a + b) / 2) * h;
        double perimetro = a + b + lado1 + lado2;

        Console.WriteLine("Área: " + area);
        Console.WriteLine("Perímetro: " + perimetro);
    }



    // 7. Ejercicio de Almacenamiento
    static void Almacenamiento()
        {
            Console.Clear();
            Console.WriteLine("\n--CONVERSION DE UNIDADES DE ALMACENAMIENTO ---");
            Console.WriteLine("Bytes: ");
            double bytes = double.Parse(Console.ReadLine());

        //Simplemente los convertimos
            Console.WriteLine("KB: " + (bytes / 1024));
            Console.WriteLine("MB: " + (bytes / 1024 / 1024));
            Console.WriteLine("GB: " + (bytes / 1024 / 1024 / 1024));
            Console.ReadKey();
        }


        // 8. Ejercicio Salario semanal
        static void Salario()
        {
    
            Console.Clear();
            Console.WriteLine("\n---CALCULO DE SALARIO MENSUAL ---");
            Console.WriteLine ("Horas trabajadas: ");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine ("Tarifa por hora: ");
            double tarifa = double.Parse(Console.ReadLine());
            double extra = 0;
            double subtotal=0;

            if (horas > 44)
            {
                extra = (horas - 44) * tarifa * 0.5;
                horas = 44;
                subtotal = 44 * tarifa; 
            }

            double total = subtotal + extra;
            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("Horas extra: " + extra);
            Console.WriteLine("Salario total: " + total);
            Console.ReadKey();

        }
    }
}
    