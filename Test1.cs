using System;

class MainClass {
    public static void Main(string[] args) {
        double[] gastos = new double[2]; // arreglo para almacenar los gastos en GASOLINA y COMIDA
        double saldoInicial = 0; // saldo inicial
        char opcion; // opción seleccionada por el usuario

        do {
            Console.Clear();
            Console.WriteLine("Menu de asistente de presupuesto financiero semanal:");
            Console.WriteLine("a) Agregar dinero");
            Console.WriteLine("b) Retirar Dinero");
            Console.WriteLine("c) Ver presupuesto");
            Console.WriteLine("d) Salir");
            Console.Write("Ingrese una opción: ");
            opcion = char.ToLower(Console.ReadKey().KeyChar); // leer la opción seleccionada
            Console.WriteLine();

            switch (opcion) {
                case 'a': // agregar dinero
                    Console.WriteLine("1 para agregar a GASOLINA");
                    Console.WriteLine("2 para agregar a COMIDA");
                    Console.Write("Ingrese la opción seleccionada: ");
                    int indice = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad a agregar: ");
                    double cantidad = double.Parse(Console.ReadLine());
                    gastos[indice - 1] += cantidad;
                    saldoInicial -= cantidad;
                    Console.WriteLine("Cantidad total agregada: " + cantidad);
                    Console.WriteLine("Saldo disponible: " + saldoInicial);
                    Console.WriteLine("Presupuesto actualizado.");
                    Console.ReadKey();
                    break;

                case 'b': // retirar dinero
                    Console.WriteLine("1 para retirar de GASOLINA");
                    Console.WriteLine("2 para retirar de COMIDA");
                    Console.Write("Ingrese la opción seleccionada: ");
                    indice = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad a retirar: ");
                    cantidad = double.Parse(Console.ReadLine());
                    if (gastos[indice - 1] >= cantidad) {
                        gastos[indice - 1] -= cantidad;
                        saldoInicial += cantidad;
                        Console.WriteLine("Cantidad total retirada: " + cantidad);
                        Console.WriteLine("Saldo disponible: " + saldoInicial);
                        Console.WriteLine("Presupuesto actualizado.");
                    } else {
                        Console.WriteLine("No se puede retirar esa cantidad, la cantidad en el presupuesto es menor.");
                    }
                    Console.ReadKey();
                    break;

                case 'c': // ver presupuesto
                    Console.WriteLine("Presupuesto actual:");
                    Console.WriteLine("GASOLINA: " + gastos[0]);
                    Console.WriteLine("COMIDA: " + gastos[1]);
                    Console.WriteLine("Saldo disponible: " + saldoInicial);
                    Console.ReadKey();
                    break;

                case 'd': // salir
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default: // opción no válida
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 'd');
    }
}
