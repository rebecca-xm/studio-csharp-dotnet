int pezzi = 7;
double temperatura = 21.5;
decimal prezzo = 19.99m;

Console.WriteLine(pezzi);
Console.WriteLine(temperatura);
Console.WriteLine(prezzo);

var quantita = 3;
const decimal Iva = 0.22m;
Console.WriteLine(quantita * prezzo * (1 + Iva));

string testo1 = "42";
string testo2 = "21,5";
string testo3 = "21.5";

int a = int.Parse(testo1);
double b = double.Parse(testo2);
//double c = double.Parse(testo3);
double c = double.Parse(testo3, System.Globalization.CultureInfo.InvariantCulture);

Console.WriteLine(a + 1);
Console.WriteLine(b);
Console.WriteLine(c);

bool riuscito = int.TryParse("ciao", out int d);
Console.WriteLine(riuscito);
Console.WriteLine(d);

bool riuscito2 = int.TryParse("42", out int e);
Console.WriteLine(riuscito2);
Console.WriteLine(e);