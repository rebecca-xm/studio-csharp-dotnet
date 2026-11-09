Console.Write("Come ti chiami? ");
string? nome = Console.ReadLine();
Console.Write("In che città vivi? ");
string? citta = Console.ReadLine();
Console.Write("Che linguaggio preferisci? ");
string? linguaggio = Console.ReadLine();

Console.WriteLine("--------------------");
Console.WriteLine("SCHEDA");
Console.WriteLine("--------------------");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Città: " + citta);
Console.WriteLine("Linguaggio: " + linguaggio);
Console.WriteLine("--------------------");
Console.WriteLine(nome + " abita a " + citta + " e preferisce " + linguaggio + ".");
