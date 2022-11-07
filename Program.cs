Console.ForegroundColor = ConsoleColor.Yellow;
string frase = "- - - Tabuada - - -\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
Console.ForegroundColor = ConsoleColor.White;
frase = "Escolha um número para fazer tabuada do: ";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
Console.ForegroundColor = ConsoleColor.Cyan;
int numero = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;
frase = "Escolha um número de vezes: ";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
Console.ForegroundColor = ConsoleColor.Cyan;
int vezes = Convert.ToInt32(Console.ReadLine());
int i2 = 0;
while (i2 <= vezes)
{
    Console.ForegroundColor = ConsoleColor.Blue;
frase = $"{numero} X {i2} = {numero*i2}\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
i2 = i2 + 1;
}
Console.ResetColor();