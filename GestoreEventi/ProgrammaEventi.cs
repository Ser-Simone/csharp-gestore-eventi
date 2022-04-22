using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi 
    {
       public string titolo;
        public DateTime data;
        public int capienzaMassima;

        public List<Evento> listaEventi = new List <Evento>();


        public ProgrammaEventi(string titolo,List<Evento>listaEventi)
        {
            this.titolo = titolo;
            this.listaEventi = listaEventi;
        }

        public void addEvento(Evento evento)
        {
            listaEventi.Add(evento); 
        }

        public static void stampaEventi(List<Evento> listaEventi)
        {
            foreach (Evento evento in listaEventi)
            {

                evento.ToString();
            }
        }
        public void rimuoviEvento(List<Evento> listaEventi)
        {
            
                listaEventi.Clear();         
        }

        public void StampanEventi(List<Evento> listaEventi)
        {
            int num = 0;
            for (int i = 0; i < listaEventi.Count; i++)
            {
                 num++;
            }
            Console.WriteLine("i tuoi eventi sono: " +num);
        }
        public void stampaListTitolo(List<Evento> listaEventi)
        {

            Console.WriteLine("Ecco la lista dei tuoi eventi");
            foreach(Evento evento in listaEventi)
            {
                evento.ToString();
            }
          
        }

        public List<Evento> eventiData(DateTime Data)
        {
            List<Evento> listaEventi = new List<Evento>();

            for (int i = 0; i < listaEventi.Count; i++)
            {
                if(listaEventi[i].getDataEvento() == Data)
                {
                    listaEventi.Add(listaEventi[i]);
                }
            }
            return listaEventi;
            Console.WriteLine(listaEventi);
        }


        public void stampaListTitolo(List<Evento> eventiData)
        {

            Console.WriteLine("Ecco la lista dei tuoi eventi");
            foreach (Evento evento in listaEventi)
            {
                evento.ToString();
            }

        }








    }
    }
