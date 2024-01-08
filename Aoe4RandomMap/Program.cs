using System;

class Program
{
    static void Main()
    {


        string[] maps = { "Gorge", "Cliffside", "Dry Arabia", "Himeyama", "Golden Pit", "Hidden Valley", "Rocky River", "Golden Heights", "Canal" };
        string[] biomes = { "Asian Subtropical", "Asian Temperate", "Chalk Downs", "European Temperate", "Gobi Desert", "Japansese Spring", "Mediterranean", "Sahara Desert", "Savanna", "Steppes", "Taiga Summer", "Taiga Winter", "Winter" };

        Random randomMap = new Random();
        Random randomBiome = new Random();


        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key for a new selection, or 'Q' to quit.");

            int randomMapIndex = randomMap.Next(maps.Length);
            int randomBiomeIndex = randomBiome.Next(biomes.Length);

            string selectedMap = maps[randomMapIndex];
            string selectedBiome = biomes[randomBiomeIndex];

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Map : " + selectedMap + "\nBiome : " + selectedBiome);

            ConsoleKeyInfo keyInfo = Console.ReadKey();


            if (keyInfo.Key == ConsoleKey.Q)
            {
                break;
            }

            Console.Clear();
        }
    }
}