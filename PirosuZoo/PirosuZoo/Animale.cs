using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirosuZoo
{
    class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public int Età { get; set; }
        public int Peso { get; set; }
        public string StatoSalute { get; set; }
        public DateOnly DataArrivo { get; set; }
        public int AnniZoo { get; set; }

        //membri privati

        private double _pesoiniziale;
        private int _numeroControlliVeterinari;

        private static void CalcolaVariazionePesoPercentuale()
        {
            
            
        }
        private static void DeterminaStatoSaluteAutomatico()
        {
            
        }


        //metodi pubblici

        public virtual void CalcolaCiboDiarioKg()
        {

        }
        public static void CalcolaCostoGestioneMensile()
        {

        }
        public static void EmettiVerso()
        {

        }
        public static double AggiornaPeso(double nuovoPeso)
        {
            return (nuovoPeso);
            

        }
        public static void EffettuaControlloVeterinario()
        {
            
        }
        public static void MostraInformazioni()
        {

        }



    }
}
