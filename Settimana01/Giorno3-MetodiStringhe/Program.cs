/*
ToUpper() -> tutto maiuscolo, restituice una nuova stringa
ToLower() -> tutto minuscolo, restituisce una nuova stringa
Trim() -> rimuove gli spazi all'inizio e alla fine della stringa, restituisce una nuova stringa
Contains("parola") -> restituisce true se la parola è contenuta nella stringa, false altrimenti
Replace("parola1", "parola2") -> restituisce una nuova stringa in cui tutte le occorrenze di parola1 sono sostituite da parola2
Substring(inizio, lunghezza) -> restituisce una nuova stringa che è una parte della stringa originale, a partire dall'indice inizio e lunga lunghezza

un metodo su una stringa non la modifica mai, ne restituisce una nuova
*/

Console.Write("Scrivi una frase qualsiasi: ");
string frase = Console.ReadLine() ?? "";
Console.WriteLine($"Questa frase ha {frase.Length} caratteri");
Console.WriteLine($"La tua frase in maiuscolo: {frase.ToUpper()}");
Console.WriteLine($"Frase senza spazi all'inizio e alla fine: '{frase.Trim()}'");
Console.WriteLine($"Dopo aver tolto gli spazi, la frase ha {frase.Trim().Length} caratteri");
//bool outcome = frase.ToUpper().Contains("C#");
bool outcome = frase.Contains("C#", StringComparison.OrdinalIgnoreCase);
Console.WriteLine($"La tua frase contiene C#? {outcome}");
if (outcome)
{
    string txt = frase.Replace("C#", "Java", StringComparison.OrdinalIgnoreCase); 
    Console.WriteLine(txt);
}