using System;

namespace PirosuZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ZOO DI PIROSU ===\n");

            Animale leone = new Animale("Simba", "Leone", 8, 190, new DateTime(2020, 5, 10));
            Animale pinguino = new Animale("Skipper", "Pinguino", 4, 12, new DateTime(2022, 3, 1));
            Animale elefante = new Animale("Dumbo", "Elefante", 25, 4500, new DateTime(2018, 8, 20));

            Console.WriteLine("=== ELENCO ANIMALI ===");
            leone.MostraInformazioni();
            pinguino.MostraInformazioni();
            elefante.MostraInformazioni();

            Console.WriteLine("\n=== AGGIORNAMENTI ===");

            leone.AggiornaPeso(195); 
            leone.EffettuaControlloVeterinario();

            pinguino.AggiornaPeso(11.5);
            pinguino.EffettuaControlloVeterinario();

            elefante.AggiornaPeso(4600);
            elefante.EffettuaControlloVeterinario();

            Console.WriteLine("\n=== INFORMAZIONI AGGIORNATE ===");
            leone.MostraInformazioni();
            pinguino.MostraInformazioni();
            elefante.MostraInformazioni();

            Console.WriteLine("\n=== CONCERTO DI VERSI ===");
            Console.WriteLine($"{leone.Nome}: {leone.EmettiVerso()}");
            Console.WriteLine($"{pinguino.Nome}: {pinguino.EmettiVerso()}");
            Console.WriteLine($"{elefante.Nome}: {elefante.EmettiVerso()}");

            double ciboTotale = leone.CalcolaCiboDiarioKg() +
                                pinguino.CalcolaCiboDiarioKg() +
                                elefante.CalcolaCiboDiarioKg();

            Console.WriteLine($"\nCibo totale necessario al giorno: {ciboTotale:F2} kg");

            Console.WriteLine("\n=== FINE PROGRAMMA ===");
        }
    }
}
