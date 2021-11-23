using System;
using System.IO;

namespace Ylessane2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\test";
            string userStars = "stars";
            string userPlanets = "planets";
            string fullStarsPath = $@"{rootDirectory}\{userStars}.txt";
            string fullPlanetsPath = $@"{rootDirectory}\{userPlanets}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileStarsExists = File.Exists(fullStarsPath);
            bool filePlanetsExists = File.Exists(fullPlanetsPath);

            if (directoryExists && fileStarsExists && filePlanetsExists)
            {
                Console.WriteLine($"{userStars} and {userPlanets} already exists in {rootDirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(fullStarsPath);
                File.Create(fullPlanetsPath);
                Console.WriteLine($"{userStars}.txt and {userPlanets}.txt have been created in {rootDirectory}.");

            }
            else
            {
                File.Create(fullStarsPath);
                File.Create(fullPlanetsPath);
                Console.WriteLine($"{userStars}.txt and {userPlanets}.txt has been created in {rootDirectory}.");
            }
        }
    }
}
