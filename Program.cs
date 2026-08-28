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

        // 2. SWITCH (ASIGNACIÓN DE BONIFICACIÓN)
        int bonificacion;
        switch (tipoVehiculo)
        {
            case 1: bonificacion = 20; break;
            case 2: bonificacion = 15; break;
            case 3: bonificacion = 25; break;
            case 4: bonificacion = 10; break;
            default: bonificacion = 5;  break;
        }

        // 3. OPERADORES ARITMÉTICOS
        double distancia = 15.0;
        int vueltas = 4;

        int puntos = ((int)velocidadMaxima / 10 + 20) + bonificacion;
        double promedio = distancia / vueltas;
        double distanciaTotal = distancia * vueltas;
        int residuo = vueltas % 3;

        // 4. OPERADORES RELACIONALES Y LÓGICOS
        bool mayorEdad        = edad >= 18;
        bool velSuficiente    = velocidadMaxima >= 250;
        bool tieneCombustible = nivelCombustible >= 50;
        bool esExacta         = velocidadMaxima == 250;
        bool esDiferente      = experienciaAnios != 0;

        bool esAprobado = mayorEdad && velSuficiente && tieneCombustible && estadoOptimo && (cantidadInfracciones < 3);

        // 5. ESTRUCTURA CONDICIONAL (IF / ELSE)
        Console.WriteLine("\n=================================");
        Console.WriteLine($" PILOTO: {nombrePiloto.ToUpper()}");
        Console.WriteLine("=================================");

        if (esAprobado)
        {
            Console.WriteLine("ESTADO: PILOTO APROBADO");
            Console.WriteLine("Puede competir en la carrera de Río.");
        }
        else
        {
            Console.WriteLine("ESTADO: PILOTO RECHAZADO");
            if (!mayorEdad) Console.WriteLine("- Motivo: Edad insuficiente.");
            if (!velSuficiente) Console.WriteLine("- Motivo: Velocidad mínima no alcanzada.");
            if (!tieneCombustible) Console.WriteLine("- Motivo: Nivel de combustible insuficiente.");
            if (!estadoOptimo) Console.WriteLine("- Motivo: El vehículo no está en óptimo estado.");
            if (cantidadInfracciones >= 3) Console.WriteLine("- Motivo: Exceso de infracciones.");
        }

        // 6. IMPRESIÓN DE CÁLCULOS
        Console.WriteLine("\n=== CÁLCULOS DE CARRERA ===");
        Console.WriteLine($"Bonificación por vehículo: +{bonificacion} pts");
        Console.WriteLine($"Puntos totales: {puntos}");
        Console.WriteLine($"Promedio por vuelta: {promedio} km");
        Console.WriteLine($"Distancia total: {distanciaTotal} km");
        Console.WriteLine($"Residuo de vueltas: {residuo}");
    }
}