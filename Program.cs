Console.Clear();
Console.WriteLine("Tabuada.");
Console.Write("Tabuada do número: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Escolha um número de vezes para multiplicar: ");
int vezes = Convert.ToInt32(Console.ReadLine());
int i2 = 0;
while (i2 <= vezes)
{
Console.Write($"{numero} X {i2} = {numero*i2}\n");
i2 = i2 + 1;
}
