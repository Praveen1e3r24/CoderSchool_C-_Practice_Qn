//Comment out part 2 and part 3 before running part 1.
//Comment out part 1 and part 3 before running part 2.
//Comment out part 1 and part 2 before running part 3.




////////////////////Part 1////////////////////

//There are scope realted errors in the code. Fix the scope related errors in the code.


// Imagine you're in a fantasy adventure game
Console.WriteLine("You're on a quest to find a hidden treasure deep in the forest.");
Console.WriteLine("You stumble upon an ancient cave with mysterious inscriptions.");



// Enter the cave to explore
Console.WriteLine("\nYou enter the dark cave, your heart pounding with excitement.");

// Start a new block for inside the cave
{
    // Declare your character's health and energy levels
    int health = 100;
    int energy = 50;
    // Declare a variable for finding a treasure chest
    int treasureChestGold = 1000;
    // Explore the cave and find the treasure chest
    Console.WriteLine("\nYou stumble upon an old treasure chest, hidden beneath rubble!");
    Console.WriteLine("Your eyes widen as you uncover the gleaming gold coins inside.");
    Console.WriteLine("You found " + treasureChestGold + " gold coins!");
}

// Attempt to access the treasure chest gold outside the cave
// This will result in a compilation error because treasureChestGold is out of scope here
// Console.WriteLine("You count your gold coins outside the cave: " + treasureChestGold);

// Continue your adventure
Console.WriteLine("\nWith your newfound wealth, you continue your journey deeper into the forest.");
Console.WriteLine("Your health: " + health);
Console.WriteLine("Your energy: " + energy);
Console.WriteLine(treasureChestGold); // This will result in a compilation error because treasureChestGold is out of scope here













//////////////////Part 2////////////////////


// There are scope-related errors in the code. Fix the scope-related errors in the code.

// Imagine you're a detective investigating a mysterious crime scene
Console.WriteLine("You arrive at the crime scene, a dimly lit alleyway shrouded in mystery.");
Console.WriteLine("Your keen eyes scan the surroundings for any clues.");

// Declare variables for evidence found at the crime scene
string evidence1;
string evidence2;

// Begin your investigation
Console.WriteLine("\nYou start gathering evidence, carefully collecting any clues left behind.");

// Start a new block for searching the crime scene
{
    // Declare a variable for a key piece of evidence
    string fingerprint = "Unknown";
    // Investigate further and find a torn piece of cloth
    Console.WriteLine("\nYou discover a torn piece of cloth with a mysterious symbol.");
    Console.WriteLine("Your heart races as you realize its significance: " + fingerprint);
    // Store the discovered evidence
    evidence1 = "Torn cloth with mysterious symbol";
    evidence2 = "Unknown";
}

// Attempt to access the fingerprint variable outside the crime scene
// This will result in a compilation error because fingerprint is out of scope here
Console.WriteLine("You carefully analyze the fingerprint: " + fingerprint);

// Continue your investigation
Console.WriteLine("\nWith the evidence collected, you piece together the puzzle of the crime.");













/////////////////Part 3////////////////////

// There are scope-related errors in the code. Fix the scope-related errors in the code.

// Imagine you're a scientist conducting experiments in a laboratory
Console.WriteLine("You step into the laboratory, surrounded by rows of sophisticated equipment and bubbling beakers.");
Console.WriteLine("Your mission is to uncover the secrets of a mysterious substance.");

// Declare variables for lab experiment results
double result1;
double result2;

// Begin your experiment
Console.WriteLine("\nYou set up your equipment and prepare to conduct the experiment.");

// Start a new block for conducting the experiment
{
    // Declare a variable for the concentration of the substance
    double concentration = 0.5;
    // Perform the experiment and observe the first result
    Console.WriteLine("\nYou conduct the first experiment and observe the results.");
    result1 = concentration * 10;
    // Store the first experiment result
    result2 = result1 / 2;
    Console.WriteLine("Result 1: " + result1);
}

// Attempt to access the concentration variable outside the experiment block
// This will result in a compilation error because concentration is out of scope here
Console.WriteLine("You analyze the concentration of the substance: " + concentration);

// Continue your experiments
Console.WriteLine("\nWith the first results obtained, you continue your experiments to unravel the mystery.");



