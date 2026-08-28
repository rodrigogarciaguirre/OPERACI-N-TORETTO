using System;

class Program
{
    static void Main()
    {
        // 1. CAPTURA DE DATOS
        Console.Write("Nombre del piloto: ");
        string nombrePiloto = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Velocidad máxima (km/h): ");
        double velocidadMaxima = double.Parse(Console.ReadLine());

        Console.Write("Años de experiencia: ");
        int experienciaAnios = int.Parse(Console.ReadLine());

        Console.Write("Nivel de combustible (%): ");
        double nivelCombustible = double.Parse(Console.ReadLine());

        Console.Write("¿Está en óptimo estado? (true/false): ");
        bool estadoOptimo = bool.Parse(Console.ReadLine());

        Console.WriteLine("\nSeleccione el tipo de vehículo:");
        Console.WriteLine("1. Muscle Car");
        Console.WriteLine("2. JDM");
        Console.WriteLine("3. Supercar");
        Console.WriteLine("4. Muscle Truck");
        Console.WriteLine("5. Otro");
        Console.Write("Opción: ");
        int tipoVehiculo = int.Parse(Console.ReadLine());

        Console.Write("Cantidad de infracciones: ");
        int cantidadInfracciones = int.Parse(Console.ReadLine());

        // 2. SWITCH (BONIFICACIÓN Y NOMBRE DEL VEHÍCULO)
        int bonificacion;
        string nombreVehiculo;

        switch (tipoVehiculo)
        {
            case 1: 
                bonificacion = 20; 
                nombreVehiculo = "Muscle Car";
                break;
            case 2: 
                bonificacion = 15; 
                nombreVehiculo = "JDM";
                break;
            case 3: 
                bonificacion = 25; 
                nombreVehiculo = "Supercar";
                break;
            case 4: 
                bonificacion = 10; 
                nombreVehiculo = "Muscle Truck";
                break;
            default: 
                bonificacion = 5;  
                nombreVehiculo = "Otro";
                break;
        }

        // 3. CATEGORÍA DEL PILOTO
        string categoria;
        if (cantidadInfracciones == 0)
        {
            categoria = "ELITE";
        }
        else if (cantidadInfracciones >= 1 && cantidadInfracciones <= 2)
        {
            categoria = "PROFESIONAL";
        }
        else if (cantidadInfracciones >= 3 && cantidadInfracciones <= 4)
        {
            categoria = "VIGILADO";
        }
        else
        {
            categoria = "EXPULSADO";
        }

        // 4. PANTALLA DE RESULTADO COMPLETO (RETO FINAL)
        Console.WriteLine("\n========================================");
        Console.WriteLine("       STREET KINGS - RIO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Piloto: {nombrePiloto}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Vehículo: {nombreVehiculo}");
        Console.WriteLine($"Velocidad: {velocidadMaxima} km/h");
        Console.WriteLine($"Combustible: {nivelCombustible} L");
        Console.WriteLine($"Infracciones: {cantidadInfracciones}");
        Console.WriteLine("\nAnalizando condiciones...\n");

        if (edad >= 18 && velocidadMaxima >= 250 && nivelCombustible >= 50 && estadoOptimo)
        {
            Console.WriteLine("[OK] Edad");
            Console.WriteLine("[OK] Velocidad");
            Console.WriteLine("[OK] Combustible");
            Console.WriteLine("[OK] Vehículo");

            Console.WriteLine("\n========================================");
            Console.WriteLine("RESULTADO");
            Console.WriteLine("========================================");
            Console.WriteLine("\nPILOTO APROBADO\n");
            Console.WriteLine($"Categoría: {categoria}");
            Console.WriteLine($"Bonificación: +{bonificacion} puntos\n");
            Console.WriteLine("¡BIENVENIDO A LA CARRERA!");
            Console.WriteLine("========================================");
        }
        else
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("RESULTADO");
            Console.WriteLine("========================================");
            Console.WriteLine("\nPILOTO RECHAZADO");
            Console.WriteLine($"Categoría: {categoria}");
            Console.WriteLine("========================================");
        }
    }
}