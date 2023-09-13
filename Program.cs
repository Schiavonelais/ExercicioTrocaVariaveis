string PrimeiroNome, SegundoNome;

Console.Write("Escreva seu Nome:");
PrimeiroNome=Console.ReadLine();

Console.Write("Escreva seu Nome:");
SegundoNome=Console.ReadLine();

Console.WriteLine("-------Troca de Valores -------");
Console.WriteLine($"{PrimeiroNome}, {SegundoNome}");
Console.WriteLine("-Após a Troca de Valores, Temos:");
Console.WriteLine($"{SegundoNome}, {PrimeiroNome}");
