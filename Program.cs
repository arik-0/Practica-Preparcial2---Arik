using System;
using System.Collections.Generic;
using System.Linq;
using Practica_Preparcial2___Arik;

public class Program
{
    static repoMaterial repo = new repoMaterial();

    public static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        int v = 1;
        while (v != 0)
        {
            Console.WriteLine("\nBienvenido al servicio de biblioteca digital");
            Console.WriteLine("Especifique su operación:");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Pedir prestado");
            Console.WriteLine("2 - Devolver libro");
            Console.WriteLine("3 - Consultar disponibilidad");
            Console.WriteLine("4 - Ingresar nuevo material");

            var eleccion = Console.ReadLine();
            switch (eleccion)
            {
                case "0":
                    v = 0;
                    break;
                case "1":
                    PedirPrestado();
                    break;
                case "2":
                    DevolverLibro();
                    break;
                case "3":
                    ConsultarDisponibilidad();
                    break;
                case "4":
                    IngresarMaterial();
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }

    public static void PedirPrestado()
    {
        Console.Write("Ingrese el título del material a pedir prestado: ");
        var nombre = Console.ReadLine()?.Trim().ToUpper();

        var material = repo.ObtenerTodos().FirstOrDefault(m => m.Titulo.ToUpper() == nombre);

        if (material is IPrestable prestable)
        {
            if (prestable.estaDisponible())
            {
                try
                {
                    prestable.prestar();
                    Console.WriteLine("✅ Material prestado correctamente.");
                }
                catch (MaterialNoDisponibleException ex)
                {
                    Console.WriteLine("❌ " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("❌ El material no está disponible.");
            }
        }
        else
        {
            Console.WriteLine("❌ Material no encontrado o no es prestable.");
        }
    }

    public static void DevolverLibro()
    {
        // Acá podrías usar FirstOrDefault igual y llamar a .Devolver() si implementa IPrestable
        Console.Write("Ingrese el título del material a devolver: ");
        var nombre = Console.ReadLine()?.Trim().ToUpper();

        var material = repo.ObtenerTodos().FirstOrDefault(m => m.Titulo.ToUpper() == nombre);

        if (material is IPrestable prestable)
        {
            try
            {
                prestable.devolver();
                Console.WriteLine("✅ Material devuelto correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("❌ Material no encontrado o no es prestable.");
        }
    }

    public static void ConsultarDisponibilidad()
    {
        Console.Write("Ingrese el título del material para consultar: ");
        var nombre = Console.ReadLine()?.Trim().ToUpper();

        try { var material = repo.ObtenerTodos().FirstOrDefault(m => m.Titulo.ToUpper() == nombre); if (material is IPrestable prestable)
        {
            Console.WriteLine(prestable.estaDisponible() ? "✅ Está disponible." : "❌ No está disponible.");
        }
        else
        {
            Console.WriteLine("❌ Material no encontrado o no es prestable.");
        }}
        catch { Console.WriteLine("El libro no existe"); }

        
    }

    public static void IngresarMaterial()
    {
        Console.WriteLine("Ingrese el tipo de material a agregar:");
        Console.WriteLine("1 - Libro\n2 - Revista\n3 - DVD\n4 - Audiolibro");

        var opcion = Console.ReadLine();
        Material nuevo = null;

        switch (opcion)
        {
            case "1":
                nuevo = new Libro();
                break;
            case "2":
                nuevo = new Revista();
                break;
            case "3":
                nuevo = new Dvd();
                break;
            case "4":
                nuevo = new AudioLibro();
                break;
            default:
                Console.WriteLine("Opción inválida.");
                return;
        }

        nuevo.CargarDatos();
        repo.Agregar(nuevo);
        Console.WriteLine("✅ Material agregado correctamente.");
    }
}
