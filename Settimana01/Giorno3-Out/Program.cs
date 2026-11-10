// 1. Creo una variabile di tipo testo e ci metto dentro una stringa
string txt = "Ulisse";

// 2. Creo una variabile di tipo intero, ma NON le do un valore
int num;

// 3. Chiamo TryParse, che prova a trasformare il testo in un numero intero
//    Gli passo due cose:
//    - txt      → il testo da convertire. Questo ENTRA nel metodo.
//    - out num   → la scatola vuota. TryParse ci mette dentro il risultato,
//                  che ESCE dal metodo e torna a me dentro num
//    TryParse restituisce anche true o false, a seconda che ci sia riuscito
//    Quel true/false lo salvo in outcome
bool outcome = int.TryParse(txt, out num);

// A questo punto:
// - outcome vale False, perché "Ulisse" non è un numero
// - num vale 0, perché quando fallisce TryParse ci scrive comunque 0

// 4. Stampo se la conversione è riuscita
Console.WriteLine($"Conversione riuscita? {outcome}");

// 5. Stampo cosa c'è nella scatola dopo la chiamata
Console.WriteLine($"Numero: {num}");

string txt2 = "42";
int num2;
bool outcome2 = int.TryParse(txt2, out num2);
Console.WriteLine($"Conversione riuscita? {outcome2}");
Console.WriteLine($"Numero 2: {num2} ");

string txt3 = " 42 ";
int num3;
bool outcome3 = int.TryParse(txt3, out num3);
Console.WriteLine($"Conversione riuscita? {outcome3}");
Console.WriteLine($"Numero 3: {num3} ");

string txt4 = "4 2";
int num4;
bool outcome4 = int.TryParse(txt4, out num4);
Console.WriteLine($"Conversione riuscita? {outcome4}");
Console.WriteLine($"Numero 4: {num4} ");
// "4 2" fallisce: TryParse ignora gli spazi all'inizio e alla fine,
// ma uno spazio in mezzo rende il numero ambiguo (42? oppure 4 e 2?),
// quindi restituisce false e mette 0 in num