const decimal Cambio = 1.1m;
Console.Write("Indica l'importo in euro: ");
string? euro = Console.ReadLine();
bool riuscito = decimal.TryParse(euro, out decimal importo);
if(riuscito)
{
    Console.WriteLine(importo + " euro corrispondono a " + (importo * Cambio) + " dollari.");
}
else
{
    Console.WriteLine("Valore non valido.");
}