using System;

namespace TorettoRacing
{
	class Program
	{
		static void Main(string[] args)
		{
			// C# Datos del corredor
            Console.Write("Ingrese el nombre del piloto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el número de piloto: ");
            int numero = int.Parse(Console.ReadLine());

            int     edad        = 25;
            double  velocidad   = 310.5;
            decimal combustible = 60.5m;
            bool    aprobado    = true;
            char    categoria   = 'A';

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

