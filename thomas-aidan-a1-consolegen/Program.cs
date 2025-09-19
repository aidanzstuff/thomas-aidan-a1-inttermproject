//This program asks users both which generation of video game consoles they first played in, as well as their first ever video game console they played in that generation

using System;

class Program
{
    static void Main()
    {
        //Asking the user to input a number to indicate which generation they first grew up in.
        //I didn't include the first generation of video game consoles since there aren't a lot of people who started in that one
        Console.WriteLine("Which generation of console video games did you first play?");
        Console.WriteLine("0. 2nd Generation (Atari 2600, Colecovision, Intellevision)");
        Console.WriteLine("1. 3rd Generation (NES, Sega Master System, Atari 7800, Commodore 64)");
        Console.WriteLine("2. 4th Generation (SNES, Sega Genesis, Turbographx16, NeoGeo, Phillips CD-i)");
        Console.WriteLine("3. 5th Generation (PS1, N64, Sega Saturn)");
        Console.WriteLine("4. 6th Generation (PS2, Xbox, GameCube, Dreamcast)");
        Console.WriteLine("5. 7th Generation (PS3, Xbox 360, Wii)");
        Console.WriteLine("6. 8th Generation (PS4, Xbox One, Switch, Wii U)");
        Console.WriteLine("7. 9th Generation (PS5, Xbox Series X/S, Switch 2)");
        Console.WriteLine("Enter the number of your first generation: ");

        Console.ReadLine();
        //Converting input to an integer rather than leaving it as a string
        int genChoice = Convert.ToInt32(Console.ReadLine());
        //I couldn't figure out how to get if statements to work so I used a switch case satement instead
        switch (genChoice)
        {
            case 0:
                Console.WriteLine("Which console did you play?");
                Console.WriteLine("1. Atari 2600");
                Console.WriteLine("2. Intellevision");
                Console.WriteLine("3. ColecoVision");
                break;
            case 1:
                Console.WriteLine("Which console did you play?");
                Console.WriteLine("1. NES");
                Console.WriteLine("2. Sega Master System");
                Console.WriteLine("3. Atari 7800");
                Console.WriteLine("4. Commodore 64");
                break;
            case 2:
                Console.WriteLine("Which console did you play?");
                Console.WriteLine("1. SNES");
                Console.WriteLine("2. Sega Genesis");
                Console.WriteLine("3. Turbographx 16");
                Console.WriteLine("4. NeoGeo");
                Console.WriteLine("5. Phillips CD-i");
                break;
            case 3:
                Console.WriteLine("Which console did you play?");
                Console.WriteLine("1. PlayStation 1");
                Console.WriteLine("2. Nintendo 64");
                Console.WriteLine("3. Sega Saturn");
                break;
            case 4:
                Console.WriteLine("Which console did you play?");
                Console.WriteLine("1. PlayStation 2");
                Console.WriteLine("2. Xbox");
                Console.WriteLine("3. GameCube");
                Console.WriteLine("4. Dreamcast");
                break;
            case 5:
                Console.WriteLine("Which console did you play?");
                Console.WriteLine("1. PlayStation 3");
                Console.WriteLine("2. Xbox 360");
                Console.WriteLine("3. Wii");
                break;
            case 6:
                Console.WriteLine("Which console did you play?");
                Console.WriteLine("1. PlayStation 4");
                Console.WriteLine("2. Xbox One");
                Console.WriteLine("3. Nintendo Switch");
                Console.WriteLine("4. Wii U");
                break;
            case 7:
                Console.WriteLine("Which console did you play?");
                Console.WriteLine("1. PlayStation 5");
                Console.WriteLine("2. Xbox Series X/S");
                Console.WriteLine("3. Nintendo Switch 2");
                break;
            default:
                Console.WriteLine("Invalid generation choice.");
                return;
        }
        //Asking user which console they choose based off the number on the list
        Console.WriteLine("Choose which console from the list using an integer: ");
        Console.ReadLine();
        int consoleChoice = Convert.ToInt32(Console.ReadLine());
        //This is your eventual output
        Console.WriteLine($"Your first video game console generation was from Generation {genChoice}, and your first console was number {consoleChoice} from the list.");
    }
}
