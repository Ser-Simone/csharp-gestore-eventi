using System;
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

        public string setTitolo ()
        {
            return titolo;
        }
        public DateTime setData()
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
        public virtual void ToString()
        {
            Console.Write( data);
            Console.WriteLine( " - " +titolo);
            
        }

        public DateTime getDataEvento()
        {
            Console.WriteLine("Inserisci la data che vuoi verificare:");
            string Date = Console.ReadLine();
            DateTime DataInserita = DateTime.Parse(Date);

            return DataInserita;
        }
    }
}
