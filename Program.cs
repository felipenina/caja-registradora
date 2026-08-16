// Etapa 1 : Mostrar nombre
const string NombreComercio = "KIOSCO EL RECREO";

const decimal DescuentoMayor = 0.10m; // 10%
const decimal DescuentoMedio = 0.05m; // 5%

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
            decimal porcentajeAplicado = 0m;

            if (subtotal > 50000m)
            {
                porcentajeAplicado = DescuentoMayor;
            }
            else if (subtotal > 20000m)
            {
                porcentajeAplicado = DescuentoMedio;
            }

            decimal montoDescuento = subtotal * porcentajeAplicado;
            decimal totalFinal = subtotal - montoDescuento;

            Console.WriteLine();
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Descuento aplicado ({porcentajeAplicado * 100}%): -${montoDescuento}");
            Console.WriteLine($"Total a pagar: ${totalFinal}");
            break;

        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            Console.WriteLine();
            break;
    }

} while (opcion != "2");













































Console.ReadLine();
