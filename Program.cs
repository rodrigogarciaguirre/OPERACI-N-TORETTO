using System;

namespace TorettoRacing
{
	class Program
	{
		static void Main(string[] args)
		{
			// C# Corredor
            string  nombre      = "Brian O'Conner";
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
		}
	}
}

