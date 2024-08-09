Console.WriteLine($"Digite um texto: ");
string textos = Console.ReadLine()!.ToLower();

int[] cont = new int[26];

foreach (char texto in textos)
{
    if (Char.IsLetter(texto))
    {
        cont[texto - 'a']++; 
    }
}

for (int i = 0; i < cont.Length; i++)
{
    if (cont[i] > 0)
    {
        Console.WriteLine($"'{(char)('a' + i)} ' : {cont[i]} vezes");
    }
}