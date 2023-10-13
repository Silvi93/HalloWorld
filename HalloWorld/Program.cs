// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

internal class Program
{
    public static string GetPlanet(string planetName)
    {

        string planet;

        switch (planetName)
        {
            case "mars":
                planet = "228 million km and color is reddish/orange";
                break;
            case "earth":
                planet = "93 million miles and color is blue";
                break;
            case "uranus":
                planet = "1.8 billion miles and color is blue-green";
                break;
            case "jupiter":
                planet = "484 million miles and color is beige with brilliant red-brown belts";
                break;
            case "mercury":
                planet = "36 million miles and color is dark gray";
                break;
            case "venus":
                planet = "67,237,910 miles and color is yellow-white";
                break;
            case "saturn":
                planet = "886 million miles and color is yellowish-brown";
                break;
            case "neptune":
                planet = "2.8 billion miles and color is blue";
                break;

            default:
                planet = "No Result found";
                break;

        }

        return planet;

    }

    static void Main(string[] args)
    {
        //Console.Write("Enter the planet: ");
        //string planet = Console.ReadLine().ToLower();


        //// Console.WriteLine("Average distance to the Sun: ");


        // if (planet == "mars")
        // {
        //     Console.WriteLine("228 million km and color is reddish/orange");
        // }
        // else if (planet == "neptune")
        // {
        //     Console.WriteLine("2.8 billion miles and color is blue");
        // }

        // else if (planet == "saturn")
        // {
        //     Console.WriteLine("886 million miles and color is yellowish-brown");


        // }

        // else if (planet == "venus")
        // {
        //     Console.WriteLine("67,237,910 miles and color is yellow-white");

        // }
        // else if (planet == "mercury")
        // {
        //     Console.WriteLine("36 million miles and color is dark gray");


        // }
        // else if (planet == "jupiter")
        // {
        //     Console.WriteLine("484 million miles and color is beige with brilliant red-brown belts");


        // }
        // else if (planet == "uranus")
        // {
        //     Console.WriteLine("1.8 billion miles and color is blue-green");


        // }
        // else if (planet == "earth")
        // {
        //     Console.WriteLine("93 million miles and color is blue");


        // }
        // else {
        //     Console.WriteLine("No Result found");
        // }
        // Console.ReadLine();

        Console.Write("Enter the planet: ");

        string planet = Console.ReadLine();

        if (planet != null) {
            Console.Write(GetPlanet(planet));
        }
    }

}





