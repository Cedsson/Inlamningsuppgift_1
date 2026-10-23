// Cast the Dice - kastar två tärningar tills summan blir 12 eller spelaren vill sluta.

Random random = new Random();
bool playAgain = true;
bool guaranteedWin = false;

while (playAgain)
{
    // Next(1, 7) ger ett tal mellan 1 och 6
    int dice1 = random.Next(1, 7);
    int dice2 = random.Next(1, 7);

    // Svarar spelaren "y" blir det två sexor
    if (guaranteedWin)
    {
        dice1 = 6;
        dice2 = 6;
    }

    int sum = dice1 + dice2;

    Console.WriteLine($"Tärning 1: {dice1}");
    Console.WriteLine($"Tärning 2: {dice2}");

    if (sum == 12)
    {
        Console.WriteLine("Grattis du har vunnit!");
        playAgain = false;
    }
    else
    {
        Console.WriteLine($"Summan blev {sum}.");
        Console.Write("Vill du spela igen? (j/n): ");
        string? answer = Console.ReadLine();

        string normalizedAnswer = answer?.Trim().ToLower() ?? "";
        guaranteedWin = normalizedAnswer == "y";
        playAgain = normalizedAnswer == "j" || guaranteedWin;
        Console.WriteLine();
    }
}

Console.WriteLine("Tack för att du spelade!");
