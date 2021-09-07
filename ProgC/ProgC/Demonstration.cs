using System;

internal class Solution
{
    // konstruktor
    public Solution()
    {
    }

    public void Uppgift_1A()
    {
        //den frågar vad du heter och skriver ut "HEJ" + ditt namn.
        Console.WriteLine("Vad heter du?");
        String namn = Console.ReadLine();
        Console.WriteLine("Hej " + namn);
        Console.WriteLine();
    }

    public void Uppgift_1B()
    {
        //tre variablar
        double bredd = 9.6;
        double höjd = 5.4;
        double area;
        area = bredd * höjd / 2;
        Console.WriteLine("Area av triangel:");
        Console.WriteLine("bredd: " + bredd);
        Console.WriteLine("höjd: " + höjd);
        Console.WriteLine("area: " + area);
        Console.WriteLine();
    }

    public void Uppgift_1C()
    {
        //frågar vad bredden är.
        Console.WriteLine("Vad är bredden?");
        String text = Console.ReadLine();
        double bredd = Convert.ToDouble(text);

        //frågar vad höjden är.
        Console.WriteLine("Vad är höjden?");
        String name = Console.ReadLine();
        double höjd = Convert.ToDouble(name);

        //räknar ut arean och nedanför berättar den vad arean är.
        double area;
        area = bredd * höjd;

        Console.WriteLine("Arean är " + area);
        Console.WriteLine();
    }

    public void Uppgift_1D()
    {
        //frågar vad bredden är.
        Console.WriteLine("Vad är ditt första tal?");
        String text = Console.ReadLine();
        int talett = Convert.ToInt32(text);

        //frågar vad höjden är.
        Console.WriteLine("Vad är ditt andra tal?");
        String name = Console.ReadLine();
        int taltvå = Convert.ToInt32(name);

        //räknar ut arean och nedanför berättar den vad arean är.
        double summa;
        summa = talett + taltvå;

        Console.WriteLine("Summan är " + summa);
        Console.WriteLine();
    }

    public void Uppgift_2A()
    {
        // RandomGenerator slumpväljer ett tal, i detta fallet mellan 1 till 10. 
        // Skapar även en variabel kállas favorittal.
        Random randomGenerator = new Random();
        int favorittal = randomGenerator.Next(1, 10);

        // Här ber jag använderan gissa ett favorittal. 
        Console.WriteLine("Gissa mitt favorit tal!");
        string text = Console.ReadLine();
        Double bredd = Convert.ToDouble(text);

        // Om tal är 3 kommer den printa "Du gissade rätt!" annars printar den "Du gissade fel"
        if (favorittal == 3)
        {
            Console.WriteLine("Du gissade rätt!");
        }
        else
        {
            Console.WriteLine("Du gissade fel.");
        }

        Console.WriteLine();
    }

    public void Uppgift_2B()
    {
        // Nedanför är två variablar skapade, där varje variabel kommer få ett slumpmässigt tal mellan 1 och 7
        Random randomGenerator = new Random();
        int tärning1 = randomGenerator.Next(1, 7);

        int tärning2 = randomGenerator.Next(1, 7);

        Console.WriteLine("Tärningarna visar: " + tärning1 + ",och " + tärning2);

        if (tärning1 == tärning2)
        {
            Console.WriteLine("Vinst!");
        }
        else
        {
            Console.WriteLine("Förlust....");
        }

        Console.WriteLine();
    }

    public void Uppgift_3A()
    {
        int räknare = 1;
        while (räknare < 6)
        {
            Console.WriteLine("" + räknare);
            räknare = räknare + 1;
        }
        Console.WriteLine();
    }

    public void Uppgift_3B()
    {
        int räknare = 5;
        while (räknare < 21)
        {
            Console.WriteLine("" + räknare);
            räknare = räknare + 3;
        }
        Console.WriteLine();
    }

    public void Uppgift_3C()
    {
        int räknare = 10;
        while (räknare > 0)
        {
            Console.WriteLine("" + räknare);
            räknare = räknare - 1;
        }
        Console.WriteLine();
    }

    public void Uppgift_4A()
    {
        for (int räknare = 1; räknare < 6; räknare = räknare + 1)
        {
            Console.WriteLine("" + räknare);
        }
    }

    public void Uppgift_4B()
    {
        for (int räknare = 5; räknare < 21; räknare = räknare + 3)
        {
            Console.WriteLine("" + räknare);
        }
    }

    public void Uppgift_4C()
    {
        for (int räknare = 10; räknare > 0; räknare = räknare - 1)
        {
            Console.WriteLine("" + räknare);
        }
    }

    public void Uppgift_5()
    {
        String input = "j";
        while (input.Equals("j"))
        {
            Console.WriteLine("Gissa mitt favorittal!!");

            int tal = Convert.ToInt32(Console.ReadLine());

            if (tal == 15)
            {
                Console.WriteLine("Grattis du gissa rätt.");
            }
            else

            {
                Console.WriteLine("Det var fel.");
                Console.WriteLine("Vill du gissa igen? j/n");
            }

            input = Console.ReadLine();
        }
        Console.WriteLine("Klart!");
        Console.WriteLine();
    }

    public void Uppgift_6()
    {
        Random randomGenerator = new Random();
        int Tärning1 = randomGenerator.Next(1, 7);
        int tärning2 = randomGenerator.Next(1, 7);

        Console.WriteLine("Tärning ett visar " + Tärning1);
        Console.WriteLine("Tärning två visar " + tärning2);

        if (Tärning1 + tärning2 == 12)
        {
            Console.WriteLine("Stor vinst!");
        }
        else if (Tärning1 == tärning2)
        {
            Console.WriteLine("Liten vinst...");
        }
        else
        {
            Console.WriteLine("Förlust...");
        }
    }

    public void Uppgift_7A()
    {
        int[] tal = new int[6];
        tal[0] = 3;
        tal[1] = 5;
        tal[2] = 7;
        tal[3] = 9;
        tal[4] = 11;
        tal[5] = 13;

        foreach (int talet in tal)
        {
            Console.Write(talet + ", ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public void Uppgift_8A()
    {
        int[] nummer = { 3, 5, 7, 9, 11, 13 };
        foreach (int i in nummer)
        {
            System.Console.Write("{0} ", i);
        }
    }

    public void Uppgift_8B()
    {
        int[] nummer = { 3, 5, 7, 9, 11, 13 };
        foreach (int i in nummer)
        {
            Console.Write("{0} ", i + 1);
        }
    }

    public void printHello()
    {
        Console.WriteLine("Välkommen Agent X. Ditt uppdrag är ...");
        Console.WriteLine();
    }



    public void Uppgift_9A()
    {
        printHello();
    }

    public void Uppgift_9Bdel1()
    {
        Console.WriteLine("Välj ett tal");

        int tal = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Välj ett till tal");

        int tal2 = Convert.ToInt32(Console.ReadLine());

        int summa = (tal + tal2);

        Console.WriteLine("Summan av de två talen är " + summa);
    }

    public void Uppgift_9Bdel2()
    {
        Console.WriteLine(addera(10, 7));
    }

    public int addera(int x, int y)
    {
        return x + y;
    }

    public void Uppgift_9Bdel3()
    {
        Console.WriteLine(addera(10, 7, 8));
    }

    public int addera(int x, int y, int z)
    {
        return x + y + z;
    }

    public void Uppgift_10A()
    {
        string[] vara = new string[200];



        int i = 0;

        Console.WriteLine("Hej och välkommen!");
        String input = "j";
        while (input.Equals("j"))
        {

            
           
            Console.WriteLine("Skriv en vara: ");
            vara [i] = Console.ReadLine();
            Console.WriteLine("Vill du lägga till en till vara j/n?");
            input = Console.ReadLine();


            i = i + 1;
            
        }

        Console.WriteLine("Din inköpslista innehåller: ");
        foreach (string varorna in vara)
        {
            if (varorna != null)
            {
                
                Console.WriteLine(varorna);
            }
        }


    }

}