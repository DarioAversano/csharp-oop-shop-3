// See https://aka.ms/new-console-template for more information


using CShop3;

Console.OutputEncoding = System.Text.Encoding.Unicode;
/*
Shop Eurospin = new Shop("Eurospin", "Roma", "Via Paolo", "42");
Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 7f, "Vinadio");
Eurospin.AddNewProductToShopList(AcquaSantAnna);

SellingBag Busta1 = new SellingBag("Busta", "Plastica", 0.2f, "Contenitori", "Plastica", 5);
Fruit Limone = new Fruit("Limone", "Limone grande", 0.5f, "Alimentari", "Sicilia", "Agrume");
Busta1.AddFruitInBag(Limone);
Eurospin.AddNewProductToShopList(Busta1);

Fruit Mela = new Fruit("Mela", "Mela rosso", 0.2f, "mela", "Roma", "frutta");

Console.WriteLine(Mela.ToString("newline"));
Busta1.AddFruitInBag(Mela);

Console.WriteLine(Eurospin.ToString());


float numero = 0f;
*/

Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());

Product LavatriceSamsung = new Product("Lavatrice Samsung SE4000", "Lavatrice ultra performante in classe A", 999.99f, "elettrodomestico");
//Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 12f, "Vinadio");
Fruit Limone = new Fruit("Limone", "Limone grande", 0.5f, "Alimentari", "Sicilia", "Agrume");
Fruit Mela1 = new Fruit("Mela verde", "Mela rosso", 0.2f, "mela", "Roma", "frutta");
Fruit Mela2 = new Fruit("Mela gialla", "Mela gialla", 0.2f, "mela", "Roma", "frutta");


Fruit MelaSacchetto1 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
Fruit MelaSacchetto2 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
BagOfFruits sacchettoDiMele = new BagOfFruits("Il mio sacchetto di frutta", "Contiente 2 mele verdi", 0.02f, "frutta", "biodegradibile", 8);

Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());

sacchettoDiMele.AddListOfFruitInbag(new List<Fruit> { MelaSacchetto1, MelaSacchetto2 });

Console.WriteLine(LavatriceSamsung.GetDescription());
Console.WriteLine(LavatriceSamsung.ToString());

Console.WriteLine(AcquaSantAnna.GetLitersInBottle());
AcquaSantAnna.Drink(0.5f);
Console.WriteLine(AcquaSantAnna.GetLitersInBottle());
Console.WriteLine(AcquaSantAnna.GetDescription());
Console.WriteLine(AcquaSantAnna.ToString());

Console.WriteLine(Limone.GetOrigin());

Console.WriteLine(sacchettoDiMele.ToString());

/*
List<Product> mieiProdottiInCasa = new List<Product> { LavatriceSamsung, AcquaSantAnna, Limone, Mela1, Mela2, sacchettoDiMele };

Console.WriteLine("--- HO CREATO LA LISTA DI PRODOTTI IN CASA E ORA TE LA STAMPO: -----");
foreach(Product prodottoScansionato in mieiProdottiInCasa)
{
	Console.WriteLine("------- PRODOTTO ---------");
	Console.WriteLine(prodottoScansionato.ToString());
	Console.WriteLine("---------------------------");
	Console.WriteLine();

	prodottoScansionato.Drink()
}
*/

PhisicalShopCart mioCarrelloDellaSpesa = new PhisicalShopCart(20);
mioCarrelloDellaSpesa.AddProduct(sacchettoDiMele);
mioCarrelloDellaSpesa.AddProduct(Limone);
mioCarrelloDellaSpesa.AddProduct(AcquaSantAnna);

Console.WriteLine("STAMPIAMO IL CARRELLO");
Console.WriteLine(mioCarrelloDellaSpesa.ToString());


// COMANDA 27 APRILE:

/*Come primo esercizio focalizzatevi bene SOLO sulla classe Prodotto e Acqua dove potete aggiungere le seguenti Eccezioni:

nel costruttore di Acqua, non posso creare un’acqua se la bottiglia ha un ph negativo, oppure superiore a 10. O ancora non posso avere una capienza sopra la
capienza massima o negativa e così via.

nel metodo bevi (double litriDaBere) se l’acqua finisce, restituire un eccezione.
metodo riempi(double litri) che riempie la bottiglia di acqua e restituisce un eccezione se supero la sua capienza massima.
un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la conversione dei litri in galloni, 
sapendo che 1 litro è equivalente a 3,785 galloni (ricordatevi di codificare le costanti come 3.785 nel modo corretto come visto in classe).

Una volta terminata la classe Prodotto e Acqua correttamente gestite anche con le Eccezioni. Vi chiedo di inserire un attributo statico alla 
classe Carrello che permetta di contare quanti Carrelli sono stati istanziati fino ad un determinato istante nel vostro programma.Alla fine 
o durante l’esecuzione del programma principale stampare in Console l’ammontare dei prodotti creati nel vostro negozio online e anche il numero 
di carrelli che eventualmente gli utenti sono andati a prendere (ossia generati in questo caso).Buon lavoro!*/


// COSI IL PROGRAMMA NON SI BLOCCA E VA NEL PUNTO CATCH *1*1*1*1*1*1*1
try
{
    Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 12f, "Vinadio");
    Console.WriteLine(AcquaSantAnna);
    //Console.WriteLine(AcquaSantAnna.ToString); Chiamato in automatico da console writeline quando c'è un oggetto.
}
catch (Exception exception)
{
	Console.WriteLine("Errore Errore Errore" + exception.Message);
}


Console.WriteLine("finito il programma");


