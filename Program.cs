// Etapa 1 : Mostrar nombre
const string NombreComercio = "KIOSCO EL RECREO";

// Etapa 4 

const decimal DescuentoMayor = 0.10m; 
const decimal DescuentoMedio = 0.05m; 

//Etapa 5 

const decimal DescuentoEfectivo = 0.10m; 
const decimal RecargoCredito = 0.15m;     


Console.WriteLine($"=== {NombreComercio} ===");
Console.Write("Nombre del cajero: ");
string cajero = Console.ReadLine();
Console.WriteLine($"Bienvenida/o, {cajero}. Caja abierta.");


// Etapa 3 a 5: 

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
            decimal descuentoPago = 0m;
            decimal recargoCredito = 0m;
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
                        descuentoPago = totalConDescuento * DescuentoEfectivo;
                        totalFinal = totalConDescuento - descuentoPago;
                        opcionValida = true;
                        break;

                    case "2":
                        totalFinal = totalConDescuento;
                        opcionValida = true;
                        break;

                    case "3":
                        recargoCredito = totalConDescuento * RecargoCredito;
                        totalFinal = totalConDescuento + recargoCredito;
                        opcionValida = true;
                        break;

                    default:
                        Console.WriteLine("Medio de pago inválido. Intente nuevamente.");
                        break;
                }
            } while (!opcionValida);

            decimal descuentoTotal = montoDescuentoMonto + descuentoPago;

            // Etapa 6 
            Console.WriteLine();

            for (int i = 0; i < 35; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.WriteLine($"          {NombreComercio}");

            for (int i = 0; i < 35; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.WriteLine($"Cajero: {cajero}");
            Console.WriteLine($"Productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: {subtotal}");
            Console.WriteLine($"Descuento: {descuentoTotal}");
            Console.WriteLine($"Recargo: {recargoCredito}");

            for (int i = 0; i < 35; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.WriteLine($"TOTAL: {totalFinal}");

            for (int i = 0; i < 35; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            break;

        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            Console.WriteLine();
            break;
    }

} while (opcion != "2");

Console.ReadLine();
