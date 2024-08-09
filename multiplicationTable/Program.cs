Console.WriteLine($"informe um numero: ");
int number = int.Parse(Console.ReadLine()!);

static void calcTable(int number) {
    
    Console.WriteLine($"Tabuada do número: {number}");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{number} X {i} = {number * i}");
        
    }
}

calcTable(number);
