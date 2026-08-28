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

            const int VELOCIDAD_MAXIMA_PERMITIDA = 350;
            // Uso en validación:
            if (velocidad > VELOCIDAD_MAXIMA_PERMITIDA)
            {
                Console.WriteLine("⚠ VELOCIDAD EXCEDE EL LÍMITE");
            }


            Console.WriteLine("PILOTO");
            Console.WriteLine("Nombre: " + nombre);

            // Interpolación:
            Console.WriteLine($"Velocidad máxima: {velocidad} km/h");
		}
	}
}

