Console.WriteLine($"Informe um número:");
int numb = int.Parse(Console.ReadLine()!);

if (numb % 2 == 0)
{
    Console.WriteLine($"O número {numb} é par!");
    
} else {
    Console.WriteLine($"O número {numb} é ímpar!");
}
