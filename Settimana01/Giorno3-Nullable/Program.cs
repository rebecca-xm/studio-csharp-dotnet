Console.WriteLine("Quanti anni hai? Quest'informazione è facoltativa, puoi lasciarla vuota premendo 'Invio'");
int? eta = null;
string risposta = Console.ReadLine() ?? "";
int etaConvertita;
bool verifica = int.TryParse(risposta, out etaConvertita);
if (verifica)
{
    eta = etaConvertita;
} 
if (eta.HasValue)
{
    Console.Write($"Hai {eta} anni");
} else
{
    Console.Write("Età non indicata");
}