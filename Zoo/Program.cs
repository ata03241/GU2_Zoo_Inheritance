using Seido.Utilities.SeedGenerator;



namespace GU1_Zoo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Zoo!");


        var rnd = new csSeedGenerator();
        // var a1 = new csAnimal(rnd);
        // Console.WriteLine(a1);




        // var n = new csZoo(5, "Small Zoo");
        // Console.WriteLine(n);

        // var n1 = new csZoo(25, "Large Zoo");
        // Console.WriteLine(n1);


        // var refZoo = new csZoo();
        // Console.WriteLine(refZoo);

        // System.Console.WriteLine("AfricanZoo");
        // csAfricanZoo a = new csAfricanZoo();
        // System.Console.WriteLine(a);
        // System.Console.WriteLine();

        System.Console.WriteLine("AfricanZoo\n");
        csAfricanZoo a = new csAfricanZoo();
        System.Console.WriteLine(a);
        System.Console.WriteLine();

        System.Console.WriteLine("NordicZoo\n");
        csNordicZoo b = new csNordicZoo();
        System.Console.WriteLine(b);
        System.Console.WriteLine();

        System.Console.WriteLine("BirdZoo\n");
        csBirdZoo c = new csBirdZoo();
        System.Console.WriteLine(c);
        System.Console.WriteLine();

        System.Console.WriteLine("\nMeat Consumption in Africa");
        System.Console.WriteLine($"Total amount of {a.meatconsumption}");

        System.Console.WriteLine("\nNumber of wolves in Nordic");
        System.Console.WriteLine($"Number of wolves {b.Nrofwolves}");

        System.Console.WriteLine("\nNumber of Parrot in birdzoo");
        System.Console.WriteLine($"Number of parrot {c.NrofParrot}");

        System.Console.WriteLine("\nMeat Consumption in Nordic");
        csNordicZoo C = new csNordicZoo();
        System.Console.WriteLine($"Total amount of meat consumption {C.meatconsumption} Kg");

        System.Console.WriteLine("\nEvery zoo\n-------------------");
        List<csZoo> zoowithallkind = new List<csZoo> { new csAfricanZoo(), new csNordicZoo(), new csBirdZoo() };

        foreach (var zoo in zoowithallkind)
        {
            System.Console.WriteLine($"{zoo}\n--------------------------");
            System.Console.WriteLine($"Tootal amount of meat consumption in {zoo.Name}: {zoo.meatconsumption} kg");
            System.Console.WriteLine($"Number of wolves in {zoo.Name}: {zoo.Nrofwolves}");
            System.Console.WriteLine($"Number of parrot in {zoo.Name}: {zoo.NrofParrot}");
            System.Console.WriteLine("----------------------------------");
        }
    }
}

