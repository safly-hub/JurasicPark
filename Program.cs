using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace JurasicPark
{
    class Dinosaurs
    {
        var new Herbivorous List<string> Herbivors();
        var new Carnivorous List<string> Carnivors();

        var new Dinosaurs WhenAqcquired = new List<DateTime>();
        public string Name { get; set }
        public string DietType { get; set }
        public int WhenAcquired { get; set }

        public string WeightinLBs { get; set; }
        public int EnclosureNumber { get; set; }
    }
    class UserInput
    {

        //add
        //remove
        //quit


    }
    class Program
    {
        static void GreetingandMenu
        {
            Console.Clear();
            Console.WriteLine("\nWelcome to Luke's Jurasic Park\n");
            Console.WriteLine("\n First lets get your first name or favorite alias\n");
            var alias = Console.ReadLine();

        Console.WriteLine($"\n Welcome! {alias});
            Console.WriteLine($"\nWhat would you like to do {alias}\n");
            //\* FEATURES(MENU PROPERTIES)
            Console.WriteLine("Summary");
            Console.WriteLine("TRANSFER");
            Console.WriteLine("REMOVE");
            Console.WriteLine("ADD");
            Console.WriteLine("VIEW -View our Herbivorous and Carnivorous members");
            Console.WriteLine("quit");

    }
    static void Main(string[] args)
    {

        //////Console.Write(GreetingandMenu);
        while (userHasChosenToQuit == false)
        {
            Display(GreetingandMenu);
            var choice = Console.ReadLine().ToUpper().Trim();

            if (choice == "VIEW")
            {
                foreach (var dino in Dinosaurs)
                {
                    Console.WriteLine($"{Dinosaurs} where.DietType == Herbivore");
                }

            }











        }
        //when user has quit 
        //Time to write the file
        //make filewriting stream
        var fileWriter = new StreamWriter("numbers.csv");
        var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);
        //numbers could be Dinos and / or features
        //PROBABLY RESPONSES TO ADD/CHANGE FEATURES OR RESPOND TO MENU 
        csvWriter.WriteRecords(numbers);
        fileWriter.Close();
    }
}
