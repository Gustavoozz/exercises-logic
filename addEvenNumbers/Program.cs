int[] evenNumb = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

int addEven = 0;

for (int i = 0; i < evenNumb.Length; i++)
{
    if (evenNumb[i] % 2 == 0)
    {
        addEven += evenNumb[i];
    }
}

Console.WriteLine($"A soma dos números pares é: {addEven}");
