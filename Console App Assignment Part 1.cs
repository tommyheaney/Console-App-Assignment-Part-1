using System;

class AdventureGame
{
    static void Main()
    {
        // Introduction to the game
        Console.WriteLine("Welcome to the Quest of Echoes!");
        Console.WriteLine("In this quest, you will choose an item that might help you in your adventures.");
        Console.WriteLine("Choose wisely, as it could determine the outcome of your journey.");

        // 1. A one-dimensional array of strings, containing scenarios.
        string[] scenarios =
        {
            "You come across a treacherous river. With your ",
            "A dragon blocks your path. In your satchel is your trusty ",
            "You find a locked chest in the forest. If only you had something like a "
        };

        // 2. Ask the user to input some text - the item they wish to take on the quest.
        Console.WriteLine("\nPlease enter the item you wish to take on your quest:");
        string userItem = Console.ReadLine();

        // 3. A loop that iterates through each scenario and adds the user's item to the end of each scenario.
        for (int i = 0; i < scenarios.Length; i++)
        {
            scenarios[i] += userItem + ", which you can use.";
        }

        // 4. A second loop that prints off each scenario with the chosen item, creating a story.
        Console.WriteLine("\nYour adventure begins...");
        foreach (string scenario in scenarios)
        {
            Console.WriteLine(scenario);
            Console.WriteLine("What will you do?");
            Console.ReadLine(); // Wait for the user to press enter before continuing.
        }

        // Conclusion of the game
        Console.WriteLine("\nAs the sun sets, you reflect on how your " + userItem + " has served you today.");
        Console.WriteLine("Will it be enough to see you through the Quest of Echoes? Only time will tell.");
        Console.WriteLine("Thank you for playing!");

        // 5. End of the program
        Console.WriteLine("\nPress Enter to end your adventure.");
        Console.ReadLine();
    }
}
