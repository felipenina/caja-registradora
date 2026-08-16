// Etapa 1 : Mostrar nombre
const string NombreComercio = "KIOSCO EL RECREO";


Console.WriteLine($"=== {NombreComercio} ===");

Console.Write("Nombre del cajero: ");
string cajero = Console.ReadLine();


Console.WriteLine($"Bienvenida/o, {cajero}. Caja abierta.");


// Etapa 3: Cargar varios productos 

int cantidadProductos = 0;
decimal total = 0m;
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

            // Acumular total y sumar al contador
            total += precio;
            cantidadProductos++;

            Console.WriteLine($"Agregado: {producto} - ${precio}");
            Console.WriteLine();
            break;

        case "2":
            Console.WriteLine();
            Console.WriteLine($"Venta cerrada. Cantidad de productos: {cantidadProductos} | Total: ${total}");
            break;

        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            Console.WriteLine();
            break;
    }

} while (opcion != "2");













































Console.ReadLine();
