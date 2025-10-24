using System;

namespace PirosuZoo
{
    class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }

        private int eta;
        public int Eta
        {
            get { return eta; }
            set
            {
                if (value < 0)
                    Console.WriteLine("L'età non può essere negativa!");
                else
                    eta = value;
            }
        }

        private double peso;
        public double Peso
        {
            get { return peso; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Il peso deve essere maggiore di zero!");
                else
                    peso = value;
            }
        }

        public string StatoDiSalute { get; set; }
        public DateTime DataArrivo { get; set; }

        public int AnniAlloZoo
        {
            get
            {
                return DateTime.Now.Year - DataArrivo.Year;
            }
        }

        private double _pesoIniziale;
        private int _numeroControlliVeterinari;

        public Animale(string nome, string specie, int eta, double peso, DateTime dataArrivo)
        {
            Nome = nome;
            Specie = specie;
            Eta = eta;
            Peso = peso;
            _pesoIniziale = peso;
            DataArrivo = dataArrivo;
            StatoDiSalute = "Buono";
            _numeroControlliVeterinari = 0;
        }

        private double CalcolaVariazionePesoPercentuale()
        {
            double variazione = ((Peso - _pesoIniziale) / _pesoIniziale) * 100;
            return Math.Round(variazione, 1);
        }

        private void DeterminaStatoSaluteAutomatico()
        {
            if (Peso < _pesoIniziale * 0.9)
                StatoDiSalute = "Critico";
            else if (Peso > _pesoIniziale * 1.1)
                StatoDiSalute = "Ottimo";
            else
                StatoDiSalute = "Buono";
        }

        public virtual double CalcolaCiboDiarioKg()
        {
            return Peso / 20;
        }

        public virtual double CalcolaCostoGestioneMensile()
        {
            return 100;
        }

        public virtual string EmettiVerso()
        {
            return "L'animale emette un verso.";
        }

        public void AggiornaPeso(double nuovoPeso)
        {
            if (nuovoPeso <= 0)
            {
                Console.WriteLine("Il peso non può essere negativo o zero!");
                return;
            }

            Peso = nuovoPeso;
            double variazione = CalcolaVariazionePesoPercentuale();
            DeterminaStatoSaluteAutomatico();

            Console.WriteLine($"{Nome}: peso aggiornato ({variazione:+0.0;-0.0;0}%).");
        }

        public void EffettuaControlloVeterinario()
        {
            _numeroControlliVeterinari++;
            DeterminaStatoSaluteAutomatico();
            Console.WriteLine($"{Nome} ha fatto un controllo veterinario.");
        }

        public virtual void MostraInformazioni()
        {
            Console.WriteLine($"\n[{Specie}] {Nome} - {Eta} anni - {Peso} kg" +
            $"Salute: {StatoDiSalute}" +
            $"Allo zoo da {AnniAlloZoo} anni" +
            $"Controlli veterinari: {_numeroControlliVeterinari}" +
            $"Variazione peso: {CalcolaVariazionePesoPercentuale()}%");
        }
    }
}
