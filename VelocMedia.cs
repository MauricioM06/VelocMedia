using System;

namespace VelocMedia
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double Distancia;
			double Tempo;
			double VelocMedia;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Velocidade Média (m/s)");
			Console.WriteLine();
			Console.ResetColor();
			
			Console.Write("Insira a distância percorrida (m): ");
			Distancia = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Insira o tempo gasto (s): ");
			Tempo = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine();
			VelocMedia = Distancia / Tempo;
			Console.WriteLine("Velocidade Média: " + VelocMedia + "m/s");
        }
    }
}