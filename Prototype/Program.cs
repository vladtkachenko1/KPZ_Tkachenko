using Prototype;
using System;

class Program
{
    static void Main()
    {
        var virusA = new Virus("Alpha", "Corona", 0.5, 1);
        var virusB = new Virus("Beta", "Corona", 0.4, 2);
        var virusC = new Virus("Gamma", "Corona", 0.3, 1);
        var virusD = new Virus("Delta", "Corona", 0.2, 0);


        virusB.Children.Add(virusC);
        virusA.Children.Add(virusB);
        virusA.Children.Add(virusD);

        Console.WriteLine("Original Virus Family:");
        virusA.Print();

        var clonedVirus = virusA.Clone();
        clonedVirus.Name = "AlphaClone";

        Console.WriteLine("\nCloned Virus Family:");
        clonedVirus.Print();
    }
}
