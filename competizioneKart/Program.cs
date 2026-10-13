int contaPunti=0,punteggio=0,contaVittore=0,contaPodi=0,conta5=0,contaSorpassi=0,contaPenalita=0,contaGare5=0;

for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Inserisci la posizione del pilota:\n " + "(giro:" + (i + 1) + ")");
    int posizione = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci il numero di sorpassi del pilota: ");
    int sorpassi = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci il numero di penalità del pilota: ");
    int penalita = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci il tempo impiegato dal pilota in  secondi: ");
    float tempo = float.Parse(Console.ReadLine());

    if (posizione == 0 || tempo == 0 || (sorpassi < 0 || penalita < 0))
    {
        Console.WriteLine("Errore");
        break;
    }
    // posizione e punteggio
    if (posizione == 1)
    {
        punteggio = (posizione * 10);
        Console.WriteLine("Il punteggio del pilota è: " + punteggio);
    }
    else if (posizione == 2)
    {
        punteggio = (posizione * 8);
        Console.WriteLine("Il punteggio del pilota è: " + punteggio);
    }
    else if (posizione == 3)
    {
        punteggio = (posizione * 6);
        Console.WriteLine("Il punteggio del pilota è: " + punteggio);
    }
    else if (posizione == 4)
    {
        punteggio = (posizione * 5);
       
    }
    else if (posizione == 5)
    {
        punteggio = (posizione * 4);
    }
    else
    {
        punteggio = (posizione * 2);
    }

    // penalità e sorpassi
    if (penalita >= 3)
    {
        Console.WriteLine("Attenzione: Il pilota ha ricevuto più di 3 penalità!");
        if (penalita >= 10)
        {
            Console.WriteLine("ATTENZIONE: troppe penalità durante il campionato.");

        }
    }
    if (sorpassi >= 5)
    {
        Console.WriteLine("Gara particolarmente combattuta");
        contaGare5++;
    }


    contaPunti += punteggio;
    if (posizione == 1)
    {
        contaVittore++;
    }
    else if (posizione <= 3)
    {
        contaPodi++;
    }
    else if (posizione <= 5)
    {
        conta5++;
    }
    if (sorpassi >= 1)
    {
        contaSorpassi++;
    }
    else if (penalita >= 1)
    {
        contaPenalita++;
    }

}

Console.WriteLine("il numero di punti totali è: " + contaPunti);
Console.WriteLine("il numero di vittorie è: " + contaVittore);
Console.WriteLine("il numero di podi è: " + contaPodi);
Console.WriteLine("il numero di piazzamenti tra i primi 5 è: " + conta5);
Console.WriteLine("il numero di sorpassi è: " + contaSorpassi);
Console.WriteLine("il numero di penalità è: " + contaPenalita);
Console.WriteLine("il numero di gare con più di 5 sorpassi è: " + contaGare5);
// classifica pilota
if (contaPunti >= 70)
    {
    Console.WriteLine("Campione assoluto");
    }
    else if (contaPunti >= 55)
    {
        Console.WriteLine("Pilota di vertice");
    }
    else if (contaPunti >= 40)
    {
        Console.WriteLine("Pilota competitivo");
    }
    else
    {
        Console.WriteLine("Deve migliorare");
    }
