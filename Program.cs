// ===============================================
// SISTEMA DE INVENTARIO DE PRODUCTOS - CLASS 1
// Desarrollado por: ABYLEYVA
// Fecha: 2026-04-28
// ===============================================

using System.Reflection;
using System.Data;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;


Console.WriteLine("===============================================");
Console.WriteLine("SISTEMA DE INVENTARIO DE PRODUCTOS - CLASS 1");
Console.WriteLine("Desarrollado por: ABYLEYVA");
Console.WriteLine("===============================================");
Console.WriteLine();
Console.WriteLine("¡Bienvenido al Sistema de Inventario de Productos!");
Console.WriteLine($"Version: {version}");
Console.WriteLine($"Fecha de lanzamiento: 2026-04-28");
Console.WriteLine();
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($"Framework: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estado: En desarrollo");
Console.WriteLine("Avance del prpyecto: Estrucutura");
Console.WriteLine("Configuracion .csproj");
Console.WriteLine("carpeta src/ creada");
Console.WriteLine("Meta datos configurada");
Console.WriteLine();
Console.WriteLine("¡Gracias por usar el Sistema de Inventario de Productos!");
Console.WriteLine("Proximo paso: Agregar argumentos CLI y configuracion de repositorio GitHub");

