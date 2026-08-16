// Etapa 1 : Mostrar nombre
const string NombreComercio = "KIOSCO EL RECREO";

const decimal DescuentoMayor = 0.10m; 
const decimal DescuentoMedio = 0.05m; 

//Etapa 5 

const decimal DescuentoEfectivo = 0.10m; 
const decimal RecargoCredito = 0.15m;     


Console.WriteLine($"=== {NombreComercio} ===");
Console.Write("Nombre del cajero: ");
string cajero = Console.ReadLine();

Console.WriteLine($"Bienvenida/o, {cajero}. Caja abierta.");


// Etapa 3 y 4: Cargar varios productos 

int cantidadProductos = 0;
decimal subtotal = 0m;
string? opcion;

do
{
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    Console.Write("Opción: ");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Producto: ");
            string? producto = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine() ?? "0");


            subtotal += precio;
            cantidadProductos++;

            Console.WriteLine($"Agregado: {producto} - ${precio}");
            Console.WriteLine();
            break;

        case "2":
            decimal porcentajeMonto = 0m;

            if (subtotal > 50000m)
            {
                porcentajeMonto = DescuentoMayor;
            }
            else if (subtotal > 20000m)
            {
                porcentajeMonto = DescuentoMedio;
            }

            decimal montoDescuentoMonto = subtotal * porcentajeMonto;
            decimal totalConDescuento = subtotal - montoDescuentoMonto;

            string? medioPago;
            decimal totalFinal = totalConDescuento;
            bool opcionValida = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Medio de pago:");
                Console.WriteLine("1 - Efectivo");
                Console.WriteLine("2 - Débito");
                Console.WriteLine("3 - Crédito");
                Console.Write("Opción: ");
                medioPago = Console.ReadLine();

                switch (medioPago)
                {
                    case "1": 
                        decimal descEfectivo = totalConDescuento * DescuentoEfectivo;
                        totalFinal = totalConDescuento - descEfectivo;
                        Console.WriteLine($"Descuento por Efectivo (10%): -${descEfectivo}");
                        opcionValida = true;
                        break;

                    case "2": 
                        totalFinal = totalConDescuento;
                        Console.WriteLine("Pago con Débito: Sin recargo ni descuento.");
                        opcionValida = true;
                        break;

                    case "3": 
                        decimal recCredito = totalConDescuento * RecargoCredito;
                        totalFinal = totalConDescuento + recCredito;
                        Console.WriteLine($"Recargo por Crédito (15%): +${recCredito}");
                        opcionValida = true;
                        break;

                    default:
                        Console.WriteLine("Medio de pago inválido. Intente nuevamente.");
                        break;
                }
            } while (!opcionValida);

           
            Console.WriteLine();
            Console.WriteLine("=== RESUMEN DE VENTA ===");
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Descuento por monto ({porcentajeMonto * 100}%): -${montoDescuentoMonto}");
            Console.WriteLine($"Total a pagar: ${totalFinal}");
            break;

        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            Console.WriteLine();
            break;
    }

} while (opcion != "2");













































Console.ReadLine();
