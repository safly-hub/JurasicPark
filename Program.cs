using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace JurassicPark
{
    class DinosaurProperties
    {
        var new <list> dinosaurs();

        public string Name { get; set }
        public string DietType { get; set }
        public int WhenAcquired { get; set }
        public string WeightinLBs { get; set; }
        public int EnclosureNumber { get; set; }

        public string Description()
        {
            var details = ($"{Name} is a {DietType} dinosaur added on {WhenAcquired} and weights {Weight} lbs and it's location is enclosure number {EnclosureNumber}");
            return details;

        }
    }
    static void MENU()
    {
        Console.WriteLine("What do you need to do?");
        Console.WriteLine();
        Console.WriteLine("View: view a list of all dinosaurs in the park's database");
        Console.WriteLine("Add: add a dinosaur into the database");
        Console.WriteLine("Remove: Remove a dinosaur from the database");
        Console.WriteLine("Transfer: Transfer a dinosaur from one enclosure to a new one");
        Console.WriteLine("Summary: view a summary of total numbers of dinosaurs based on their diet");
        Console.WriteLine("Quit: Exit");
        Console.WriteLine();
        Console.Write("Choice:  ");
    }
    static void Greeting()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("\nWelcome to Luke's Jurasic Park\n");
        Console.WriteLine("\n First lets get your first name or favorite alias\n");
        var alias = Console.ReadLine();
        Console.WriteLine($"\n Welcome! {alias}\n");
    }
    static Dinosaur DinoSearch(List<Dinosaur> dinosaurs)
    {
        if choice == ("Add")
        {
            Console.WriteLine("What is the dino's name? Answer: ");

            var dinoName = Console.ReadLine();
            var foundDino = dinosaurs.FirstOrDefault(Dino => Dino.Name == dinoName);
            return foundDino;
        }

    }
    static void Main(string[] args)
    {
        var dinosaurs = new List<Dinosaur>()
              new Dinosaur
              {
                  Name = "Lucasaurus",
                  DietType = "carnivore",
                  WhenAcquired = DateTime.Now,
                  Weight = 6000,
                  EnclosureNumber = 126
              }
              new Dinosaur
              {
                  Name = "Triceratops",
                  DietType = "herbivore",
                  WhenAcquired = DateTime.Now,
                  Weight = 26500,
                  EnclosureNumber = 64
              }
              new Dinosaur
              {
                  Name = "Tyrannosaurus",
                  DietType = "carnivore",
                  WhenAcquired = DateTime.Now,
                  Weight = 15500,
                  EnclosureNumber = 132
              }

        Greeting()
        Menu()
        var choice = Console.ReadLine().ToUpper().Trim();
        var choice = Console.ReadLine();
        if (choice = !"Quit")
        {
            hasQuit = true;
            Console.WriteLine("-----Adíos----");
        else if (choice == "Add")
            {
                Console.Write("What is the dino's name? Answer: ");
                var name = Console.ReadLine();
                Console.Write("What is the dino's diet? carnivore/herbivore. Answer: ");
                var diet = Console.ReadLine();
                Console.Write("what is the weight of the dino in lbs? Answer: ");
                var weight = int.Parse(Console.ReadLine());
                Console.Write("What is the enclosure number you wish to put the dino in? Answer: ");
                var enclosure = int.Parse(Console.ReadLine());
                var dino = new Dinosaur()
                {
                    Name = name,
                    DietType = diet,
                    Weight = weight,
                    EnclosureNumber = enclosure,
                    WhenAcquired = DateTime.Now
                };
                dinosaurs.Add(dino);
            }

            if (choice == "VIEW")
            {
                foreach (var dino in Dinosaurs)
                {
                    Console.WriteLine(dinosaur.Description());
                    Console.WriteLine();
                    var answer = Console.ReadLine();
                }
            }
            if (choice == "Remove")
            {
                Console.Write("What is the dino's name? Answer: ");
                var dinoName = Console.ReadLine();
                var foundDino = dinosaurs.FirstOrDefault(Pet => Pet.Name == dinoName);
                if (foundDino != null)
                {
                    Console.WriteLine(foundDino.Description());
                    Console.WriteLine();
                    Console.WriteLine($"Are you sure you want to remove this Dinosaur from the datebase? y|n");
                    var response = Console.ReadLine();
                    if (response == "y")
                    {
                        dinosaurs.Remove(foundDino);
                        Console.WriteLine();
                        Console.WriteLine($"{foundDino.Name} has been successfully removed from the park's database");
                        Console.WriteLine();
                        Console.Write("Is there is anything else you need to do? press y for yes or type exit to exit: ");
                        var Choice = Console.ReadLine();
                        if (choice != "exit")
                        {
                            hasQuit = true;
                        }
                    }
                }

                //when user has quit 
                //Time to write the file
                //make filewriting stream