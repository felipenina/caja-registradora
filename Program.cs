// 1. Constante con el nombre del comercio
const string NombreComercio = "KIOSCO EL RECREO";

// Mostrar encabezado
Console.WriteLine($"=== {NombreComercio} ===");
// 2. Pedir el nombre de quien atiende la caja
Console.Write("Nombre del cajero: ");
string cajero = Console.ReadLine();

// 3. Saludo con interpolación de cadenas ($)
Console.WriteLine($"Bienvenida/o, {cajero}. Caja abierta.");

// Pausa final para que no se cierre la consola al ejecutar
Console.ReadLine();
