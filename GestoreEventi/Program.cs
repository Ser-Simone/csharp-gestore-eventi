using GestoreEventi;

Console.WriteLine("--- Benvenuto ----");
Console.WriteLine("Inserisci il titolo dell'evento");
string titolo = Console.ReadLine();
Console.WriteLine("Inserisci la data dell'evento");
string dataEvento = Console.ReadLine();
DateTime dataInserita = DateTime.Parse(dataEvento);
Console.WriteLine("Inserisci la capienza Massiam");
int CapienzaMassima = int.Parse(Console.ReadLine());
Evento primoEvento = new Evento(titolo, dataInserita,CapienzaMassima);

primoEvento.ToString();


bool risposta = false;

while (risposta == false)
{
    Console.WriteLine("Vuoi prenotare o disdire dei posti?");
    Console.WriteLine("Selezione 1 per prenotare posti, altrimenti 2 per disdire dei posti");
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

Console.WriteLine("Vuoi fare altro? Scrivi si o no");
string  risposta2 = Console.ReadLine();
    if (risposta2 == "no")
    {
        risposta = true;
    }
}

primoEvento.ToString();