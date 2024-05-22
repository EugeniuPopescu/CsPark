using ExEma;

/*
 * problema del parcheggio:
 * 
 * ENTRANO DEI VEICOLI
 * 
 * registrare i veicoli in ingresso
 * 
 * possibilità di toglire i veicoli dall'ingresso -> targa
 * 
 * i veicoli possono essere moto o auto
 * 
 * i veicoli pagano i parcheggio con una tassa fissa: auto 5, moto 2
 * 
 * 1) riuscire a calcolare quanto vale la sosta di tutti i veicoli che sono nel parcheggio in una determinata ora 
 * 
 * parcheggio -> proprietà lista veicoli, aggiungere e togliere, attraverso la targa ciclo e tolgo il veicolo (visibilità privata), sistema per capire se sono auto o moto (sidecar -> 3 ruote, è moto)
 * per calcolare il totale 
 * 1) classe padre da cui ereditano
 * 2) interfaccia 
 * 3) interfaccia e classe padre 
 * 
 * metodo per aggiure i veicoli, visibilità 
 *
 * mettere un limite di posti, e che non mi lasci più inserire veicoli se supero il limite
 * (gestirlo con le eccezioni)
 * o 
 * (se mi ritorna un false, chiedo al parcheggio se è pieno, metodo che mi rito0rna quanti posti liberi ci sono)
 * devo capire, che mi sta tornando false o che c'è un problema legato al numero di posti
 * verificare il perchè mi torna false 
 * se è per la targa o se è perchè non ci sono posti 
 * 
 * tornare i posti disponibili
 * 
 * TOGLIERE TUTTI I CW
 * 
 */


// creare il parcheggio, (costo auto, costo moto, tot posti)
Park monteNapolene = new Park(10,5,10);

// 3 macchine 2 moto 
Moto ducati = new Moto("bs3234r");
Car opel = new Car("bs3434r");

Moto yamaha = new Moto("bs3434r");

// aggiungere al pargheggio le macchine e moto 
monteNapolene.ToAddVehicle(opel);
monteNapolene.ToAddVehicle(ducati);
monteNapolene.ToAddVehicle(yamaha);

monteNapolene.GetAvailableParkSpace();

Console.WriteLine($"Available parking spaces: {monteNapolene.GetAvailableParkSpace()}");
Console.WriteLine($"Totale amount of vehicles in park are: {monteNapolene.GetAmountPark()}");

monteNapolene.ToRemoveVehicle("bs3434r");

Console.WriteLine($"Available parking spaces: {monteNapolene.GetAvailableParkSpace()}");
Console.WriteLine($"Totale amount of vehicles in park are: {monteNapolene.GetAmountPark()}");