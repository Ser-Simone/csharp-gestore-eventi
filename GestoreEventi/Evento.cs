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
            capienzaMassima = capienzaMassima - postiRichiesti;
            Console.WriteLine("hai a disposizione" +capienzaMassima);
            return capienzaMassima;
        }

        public int disdiciPosti(int postiDisdetti)
        {
            Console.WriteLine("hai a disposizione" );
            return capienzaMassima + postiDisdetti;
        }
        public virtual void ToString()
        {
            Console.WriteLine(titolo);
            Console.WriteLine(data);
            Console.WriteLine(capienzaMassima);
            

        }
    }
}
