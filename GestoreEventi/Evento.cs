﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        public string titolo;
        public DateTime data;
        public int capienzaMassima;
        public int postiPrenotati=0;
        private int postiDisponibili =0;
        

        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            this.titolo = titolo;
            this.data = data;   
            this.capienzaMassima = capienzaMassima; 
        }

        public string getTitolo ()
        {
            return titolo;
        }
        public DateTime getData()
        {
            return data;
        }
        public int getCapienzaMax()
        {
            return capienzaMassima; 
        }

        // METODO PER PRENOTARE I POSTI
        public int prenotaPosti(int postiRichiesti)
        {
            postiDisponibili = capienzaMassima - postiRichiesti;
            Console.WriteLine("hai a disposizione" +postiDisponibili);
            Console.WriteLine("hai prenotato" + postiRichiesti);
            
            return postiDisponibili;
       
        }

        // METODO PER DISDIRE I POSTI
        public int disdiciPosti(int postiDisdetti)
        {
            postiDisponibili =+ postiDisdetti;
            Console.WriteLine("hai a disposizione" +postiDisponibili);
            Console.WriteLine("hai disdetto" + postiDisdetti);
            return postiDisponibili;
        }
        public override string ToString()
        {
            string stampaEvento = "";
            stampaEvento += data;
            stampaEvento += "  -  " +titolo;

            return stampaEvento;
        }

    }
}
