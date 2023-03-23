
using csharp_abstract_animals;

/**Esercizio 1 : classi astratte*
Dobbiamo realizzare un programma che rappresenti il regno animale.
Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
Vogliamo che gli animali abbiano i seguenti metodi
- void Dormi() (mostra a video “Zzz”)
- void Verso() (mostra a video il verso fatto dall'animale specifico)
- void Mangia() (mostra a video quello che mangia : erba, carne, ...?)
Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.*/

Console.WriteLine("Delfino");
Delfino Tursiope = new Delfino();

Tursiope.Verso();
Tursiope.Dormi();
Tursiope.Mangia();

Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("Cane");
Cane Cavalierking = new Cane();

Cavalierking.Verso();
Cavalierking.Dormi();
Cavalierking.Mangia();

Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("Aquila");
Aquila adalberti = new Aquila();

adalberti.Verso();
adalberti.Dormi();
adalberti.Mangia();

Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("Passero");
Passerotto passero = new Passerotto();

passero.Verso();
passero.Dormi();
passero.Mangia();

Console.WriteLine("--------------------------------------------------------------------------");

/**Esercizio 2 : interfacce*
Alcuni degli animali che abbiamo creato volano, altri nuotano.
Gli animali che volano hanno il seguente metodo :
-void Vola()(mostra a video “Sto volando!!!”)
Gli animali che nuotano hanno il seguente metodo :
-void Nuota()(mostra a video “Sto nuotando!!!”)
Scrivere un programma avente 2 metodi :
-void FaiVolare(IVolante animale)
- void FaiNuotare(INuotante animale)
Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.*/

adalberti.Vola();
Tursiope.Nuota();
passero.Vola();

Console.WriteLine("--------------------------------------------------------------------------");

//Bonus
Console.WriteLine("Pulcinella di mare");

Pulcinelladimare pulcinella = new Pulcinelladimare();
pulcinella.Verso();
pulcinella.Dormi();
pulcinella.Mangia();
pulcinella.Vola();
pulcinella.Nuota();
