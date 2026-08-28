using System;

class Program
{
    static void Main()
    {
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
        Console.Write("Tipo de vehículo (1: Deportivo, 2: Muscle, 3: Urbano, 4: Moto): ");
        int tipoVehiculo = int.Parse(Console.ReadLine());
        Console.Write("Cantidad de infracciones: ");
        int cantidadInfracciones = int.Parse(Console.ReadLine());

        // Datos para los cálculos de la carrera
        double distancia = 15.0;
        int vueltas = 4;

        // OPERADORES ARITMÉTICOS
        int puntos = (int)velocidadMaxima / 10 + 20;
        double promedio = distancia / vueltas;
        double distanciaTotal = distancia * vueltas;
        int residuo = vueltas % 3;

        // OPERADORES RELACIONALES
        bool mayorEdad        = edad >= 18;
        bool velSuficiente   = velocidadMaxima >= 250;
        bool tieneCombustible = nivelCombustible >= 50;
        bool esExacta        = velocidadMaxima == 250;
        bool esDiferente     = experienciaAnios != 0;

        if (edad >= 18 &&
            velocidadMaxima >= 250 &&
            nivelCombustible >= 50 &&
            estadoOptimo)
        {
            Console.WriteLine("PILOTO APROBADO");
        }

        if (edad >= 18)
        {
            Console.WriteLine("Puede competir");
        }
        else
        {
            Console.WriteLine("Edad insuficiente");
            Console.WriteLine("PILOTO RECHAZADO");
        }

        Console.WriteLine("\n=== CÁLCULOS DE CARRERA ===");
        Console.WriteLine($"Puntos: {puntos}");
        Console.WriteLine($"Promedio por vuelta: {promedio} km");
        Console.WriteLine($"Distancia total: {distanciaTotal} km");
        Console.WriteLine($"Residuo de vueltas: {residuo}");
    }
}