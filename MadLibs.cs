using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program will run an MadLibs word game 
      Author: Michael Bayer
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Mad Libs is starting!");

      // Give the Mad Lib a title:
      string title = "The morning story";
      Console.WriteLine(title);

      // Asking the user for a name
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();
      
      // Asking the user for three adjectives
      Console.Write("Please enter the first adjective: ");
      string adjOne = Console.ReadLine();
      Console.Write("Please enter the second adjective: ");
      string adjTwo = Console.ReadLine();
      Console.Write("Please enter the third adjective: ");
      string adjThree = Console.ReadLine();

      // Asking the user for a verb
      Console.Write("Please enter a verb: ");
      string verb = Console.ReadLine();

      // Asking the user for two nouns
      Console.Write("Please enter the first noun: ");
      string nounOne = Console.ReadLine();
      Console.Write("Please enter the second noun: ");
      string nounTwo = Console.ReadLine();

      // Asking the user for inputs from different topics
      Console.Write("Please pick an animal: ");
      string animal = Console.ReadLine();

      Console.Write("Please pick a food: ");
      string food = Console.ReadLine();

      Console.Write("Please pick a fruit: ");
      string fruit = Console.ReadLine();

      Console.Write("Please pick a superhero: ");
      string superhero = Console.ReadLine();

      Console.Write("Please pick a country: ");
      string country = Console.ReadLine();

      Console.Write("Please pick a dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("Please pick a year: ");
      string year = Console.ReadLine();

      // The template for the story
      string story = $"This morning {name} woke up feeling {adjOne}. 'It is going to be a {adjTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


      // Print the story:
      Console.WriteLine("\n");
      Console.WriteLine(story);
    }
  }
}
