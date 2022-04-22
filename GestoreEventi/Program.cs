using GestoreEventi;

Console.WriteLine("--- Benvenuto ----");
Console.WriteLine("Inserisci il titolo dell'evento");
string titolo = Console.ReadLine();
Console.WriteLine("\nInserisci la data dell'evento");
string dataEvento = Console.ReadLine();
DateTime dataInserita = DateTime.Parse(dataEvento);
Console.WriteLine("\nInserisci la capienza Massiam");
int CapienzaMassima = int.Parse(Console.ReadLine());

Evento primoEvento = new Evento(titolo, dataInserita,CapienzaMassima);

primoEvento.ToString();
Console.ReadKey();

bool risposta = false;

Console.WriteLine("Vuoi prenotare o disdire dei posti?");
string risposta1 = Console.ReadLine();
if(risposta1 == "no")
{
    risposta = true;
}
while (risposta == false)
{
    
    Console.WriteLine("Selezione 1 per prenotare posti, altrimenti 2 per disdire dei posti\n");
    int scelta = int.Parse(Console.ReadLine());

    if (scelta == 1)
{
    Console.WriteLine("Quanti posti vuoi prenotare?");
    int postiDaPrenotare = int.Parse(Console.ReadLine());
    primoEvento.prenotaPosti(postiDaPrenotare);
}else if(scelta == 2)
{
    Console.WriteLine("Quanti posti vuoi disdire?");
    int postiDaDisdire = int.Parse(Console.ReadLine());
    primoEvento.disdiciPosti(postiDaDisdire);
}

Console.WriteLine("Vuoi fare altro? Scrivi si o no\n");
string  risposta2 = Console.ReadLine();
    if (risposta2 == "no")
    {
        risposta = true;
    }
}

primoEvento.ToString();
Console.ReadKey();
Console.Clear();

 // ---------------------------------------------------------------- Inizio Miles 3 ----------------------------------------------


Console.WriteLine("Quanti Eventi vuoi inserire?");
int numEventi = int.Parse(Console.ReadLine());



List<Evento> listaEventi = new List<Evento>();
for (int i = 0; i < numEventi; i++)
{

    Console.WriteLine("Inserisci il titolo dell'evento");
     titolo = Console.ReadLine();
    Console.WriteLine("\nInserisci la data dell'evento");
     dataEvento = Console.ReadLine();
     dataInserita = DateTime.Parse(dataEvento);
    Console.WriteLine("\nInserisci la capienza Massiam");
     CapienzaMassima = int.Parse(Console.ReadLine());

    
    Evento SecondoEvento = new Evento(titolo, dataInserita, CapienzaMassima);
    
    
    listaEventi.Add(SecondoEvento);
    
}

ProgrammaEventi programmaEventi = new ProgrammaEventi(titolo, listaEventi);

programmaEventi.StampanEventi(listaEventi);
Console.ReadKey();
Console.Clear();

programmaEventi.stampaListTitolo(listaEventi);