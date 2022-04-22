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

        public int prenotaPosti(int postiRichiesti)
        {
            postiDisponibili = capienzaMassima - postiRichiesti;
            Console.WriteLine("hai a disposizione" +postiDisponibili);
            Console.WriteLine("hai prenotato" + postiRichiesti);
            
            return postiDisponibili;
       
        }

        public int disdiciPosti(int postiDisdetti)
        {
           // int postiDisponibili =  postiPrenotati;
            postiDisponibili =+ postiDisdetti;
            Console.WriteLine("hai a disposizione" +postiDisponibili);
            Console.WriteLine("hai disdetto" + postiDisdetti);
            return postiDisponibili;
        }
        public virtual void ToString()
        {
            Console.WriteLine("Il titolo del tuo evento è :" +titolo);
            Console.WriteLine("il tuo eventi si terrà in data: " +data);
            Console.WriteLine("Hai ancora a disposizione: " +capienzaMassima +"posti");
            

        }
    }
}
