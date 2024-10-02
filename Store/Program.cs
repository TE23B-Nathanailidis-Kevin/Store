int i = 0;
while (i < 10)
{
Console.WriteLine("Hej");
    i++;
}

for (int j=0; j < 10; j++)
{
    Console.WriteLine("Hej");
}


bool success = false;
    int ageNum = 0;

while (success != true)
{
    Console.WriteLine("Ålder:");
    string age = Console.ReadLine();

    success = int.TryParse(age, out ageNum);

    if (success == false)
    {
        Console.WriteLine("Skriv en siffra, malaka");
    }
}

if (ageNum >= 18)
{
    Console.WriteLine("Välkommen");
}

Console.ReadLine();