using System;

namespace TorettoRacing
{
	class Program
	{
		static void Main(string[] args)
		{
			// C# Datos del corredor
            Console.WriteLine("STREET KINGS RACING");
            Console.WriteLine("REGISTRO DE PILOTO");

            Console.Write("Nombre completo: ");
            string nombre = Console.ReadLine();
            Console.Write("Alias: ");
            string alias  = Console.ReadLine();
            Console.Write("Edad: ");
            int edad   = int.Parse(Console.ReadLine());
            Console.Write("País: ");
            string pais   = Console.ReadLine();
            Console.Write("Número de piloto: ");
            int numero = int.Parse(Console.ReadLine());
            double velocidad = 320.1;
            
            //Datos del vehiculo
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Año: ");
            int anio = int.Parse(Console.ReadLine());
            Console.Write("Cilindraje (L): ");
            double cilindraje = double.Parse(Console.ReadLine());
            Console.Write("Capacidad del tanque (L): ");
            double tanque = double.Parse(Console.ReadLine());
            Console.Write("Velocidad máxima (km/h): ");
            double velMax = double.Parse(Console.ReadLine());

            //carrera
            Console.WriteLine("Distancia(km): ");
            double distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Vueltas: ");
            int vueltas = int.Parse(Console.ReadLine());
            Console.WriteLine("Combustible(L):  ");
            double combustible = double.Parse(Console.ReadLine());

            const int VELOCIDAD_MAXIMA_PERMITIDA = 350;
            // Uso en validación:
            if (velocidad > VELOCIDAD_MAXIMA_PERMITIDA)
            {
                Console.WriteLine("⚠ VELOCIDAD EXCEDE EL LÍMITE");
            }

            // Mostrar datos del corredor y del vehículo
            Console.WriteLine("============================================");
            Console.WriteLine("\nSTREET KINGS RACING - DATOS DEL PILOTO");
            Console.WriteLine("=============================================");
            Console.WriteLine();
            Console.WriteLine($"PILOTO");
            Console.WriteLine($"Nombre completo: {nombre}");
            Console.WriteLine($"Alias: {alias}");
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine($"País: {pais}");
            Console.WriteLine($"Número de piloto: {numero}");
            Console.WriteLine();
            Console.WriteLine($"VEHÍCULO");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Año: {anio}");
            Console.WriteLine($"Cilindraje: {cilindraje} L");
            Console.WriteLine($"Capacidad del tanque: {tanque} L");
            Console.WriteLine($"Velocidad máxima: {velMax} km/h");
            Console.WriteLine();
            Console.WriteLine($"CARRERA");
            Console.WriteLine($"Distancia: {distancia} km");
            Console.WriteLine($"Vueltas: {vueltas}");
            Console.WriteLine($"Combustible: {combustible} L");
            //Bonus
            double velocidadPromedio = distancia / vueltas;
            double combustibleporvuelta = combustible / vueltas;
            double distanciaTotal = distancia * vueltas;
            Console.WriteLine($"Velocidad promedio: {velocidadPromedio} km/h");
            Console.WriteLine($"Combustible por vuelta: {combustibleporvuelta} L");
            Console.WriteLine($"Distancia total: {distanciaTotal} km");
            Console.WriteLine();
            Console.ReadKey();
		}
	}
}

