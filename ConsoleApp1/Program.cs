using System;
using System.IO;

class Program
{
    static void Main()
    {
        int meetodNumber = int.Parse(Console.ReadLine());
            // sisestage soovitud meetodi number siia

        if (meetodNumber == 1)
        {
            Meetod1();
        }
        else if (meetodNumber == 2)
        {
            Meetod2();
        }
        else if (meetodNumber == 3)
        {
            Meetod3();
        }
        else
        {
            Console.WriteLine("Vigane meetodi number!");
        }
    }

    static void Meetod1()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "fail.txt");
        File.Create(filePath);
        Console.WriteLine("Fail loodud desktopile.");
    }

    static void Meetod2()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "fail.txt");
        string fileContent = "Siia sisu kirjutada";
        File.WriteAllText(filePath, fileContent);
        Console.WriteLine("Fail loodud desktopile ja sisu kirjutatud.");
    }

    static void Meetod3()
    {
        string filePath = "ValeFailiAsukoht\\fail.txt";
        File.Create(filePath);
        Console.WriteLine("Fail loodud, kuid vale asukohaga.");
    }
}