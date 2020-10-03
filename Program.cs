using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            string entradaMilhas; 
            double milhas, quilometros; 

            Console.Write("entre com a medida (em milhas): "); 

            entradaMilhas = Console.ReadLine();
            milhas = Convert.ToDouble(entradaMilhas); 

            quilometros = milhas * 1.609; 
            Console.WriteLine($"o valor {milhas} milhaas correspondem a quilometros {quilometros}");
            

        }
    }
}
