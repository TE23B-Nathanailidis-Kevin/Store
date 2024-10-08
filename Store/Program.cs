int SpelarPengar = 100;

while (SpelarPengar > 0)
{
    Console.WriteLine($"Du har {SpelarPengar} Kronor kvar");

    Console.WriteLine("Vad vill du köpa");
    Console.WriteLine("1. Tzatziki 10kr");
    Console.WriteLine("2. Gyros 20kr");
    Console.WriteLine("3. Souvlaki 30kr");

    string VadSkaManKöpa ="";
    while (VadSkaManKöpa != "1" && VadSkaManKöpa != "2" && VadSkaManKöpa != "3")
    {
        VadSkaManKöpa = Console.ReadLine();
    }

    int PrisPerSak = 0;

    if (VadSkaManKöpa == "1")
    {
        PrisPerSak = 10;
    }
    else if (VadSkaManKöpa == "2")
    {
        PrisPerSak = 20;
    }
    else if (VadSkaManKöpa == "3")
    {
        PrisPerSak = 30;
    }

    Console.WriteLine("Hur många vill du köpa?");
    int numAttKöpa = 0;
    while (numAttKöpa == 0)
    {
        string num = Console.ReadLine();
        bool success = int.TryParse(num, out numAttKöpa);
        if (success == false)
        {
            Console.WriteLine("Du måste skriva en siffra");
        }
    }

    int SlutKostnaden = PrisPerSak * numAttKöpa;

    if (SlutKostnaden <= SpelarPengar)
    {
        Console.WriteLine("Ja, var de bra så?");
        SpelarPengar -= SlutKostnaden;
    }
    else
    {
        Console.WriteLine("Du har inte råd med detta!");
    }
}

Console.Write("Nu har du slut med pengar");
Console.WriteLine(" Tryck på ENTER för att avsluta");
Console.ReadLine();