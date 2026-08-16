// 1. Constante con el nombre del comercio
const string NombreComercio = "KIOSCO EL RECREO";

// Mostrar encabezado
Console.WriteLine($"=== {NombreComercio} ===");
// 2. Pedir el nombre de quien atiende la caja
Console.Write("Nombre del cajero: ");
string cajero = Console.ReadLine();

// 3. Saludo con interpolación de cadenas ($)
Console.WriteLine($"Bienvenida/o, {cajero}. Caja abierta.");

// --- ETAPA 2: Cargar un producto ---
// 1. Pedir el nombre del producto
Console.Write("Producto: ");
string? producto = Console.ReadLine();

// 2. Pedir el precio y convertirlo a decimal
Console.Write("Precio: ");
decimal precio = decimal.Parse(Console.ReadLine() ?? "0");

// 3. Mostrar el producto cargado con su precio
Console.WriteLine($"Agregado: {producto} - ${precio}");












































// Pausa final para que no se cierre la consola al ejecutar
Console.ReadLine();
