using System;
using Allergy.Score;

namespace Allergy
{
    public class Allergies
    {
        public static void Main()
        {
             
            // Allergy number will never be higher than 255
            // Each iteration is 1/2 the last
            // Start from highest number
            Scores myScore = new Scores();

            Console.WriteLine("Enter a number and we will tell you what allergies you have:");
            int response = Int32.Parse(Console.ReadLine());

            myScore.SetScore(response);

            if (myScore.GetScore() > 255)
            {
                Console.WriteLine("You have too many allergies...");
            }
            else if (myScore.GetScore() <= 255) {
                while(myScore.GetScore() > 0) {
                    if (myScore.GetScore() >= 128) {
                        myScore.SetArray(7, "cats");
                        int newScore = -128;
                        myScore.SetScore(newScore);
                        Console.WriteLine(myScore.GetScore());
                    }
                    else if (myScore.GetScore() >= 64) {
                        myScore.SetArray(6, "pollen");
                        int newScore = -64;
                        myScore.SetScore(newScore);
                        Console.WriteLine(myScore.GetScore());
                    }
                    else if (myScore.GetScore() >= 32) {
                        myScore.SetArray(5, "chocolate");
                        int newScore = -32;
                        myScore.SetScore(newScore);
                        Console.WriteLine(myScore.GetScore());
                    }
                    else if (myScore.GetScore() >= 16) {
                        myScore.SetArray(4, "tomatoes");
                        int newScore = -16;
                        myScore.SetScore(newScore);
                        Console.WriteLine(myScore.GetScore());
                    }
                    else if (myScore.GetScore() >= 8) {
                        myScore.SetArray(3, "strawberries");
                        int newScore = -8;
                        myScore.SetScore(newScore);
                        Console.WriteLine(myScore.GetScore());
                    }
                    else if (myScore.GetScore() >= 4) {
                        myScore.SetArray(2, "shellfish");
                        int newScore = -4;
                        myScore.SetScore(newScore);
                        Console.WriteLine(myScore.GetScore());
                    }
                    else if (myScore.GetScore() >= 2) {
                        myScore.SetArray(1, "peanuts");
                        int newScore = -2;
                        myScore.SetScore(newScore);
                        Console.WriteLine(myScore.GetScore());
                    }
                    else if (myScore.GetScore() >= 1) {
                        myScore.SetArray(0, "eggs");
                        int newScore = -1;
                        myScore.SetScore(newScore);
                        Console.WriteLine(myScore.GetScore());
                        break;
                    }
                }
            } else {
                Console.WriteLine("something's gone wrong...");
            }
            string output = myScore.GetAllergyArray();
            Console.WriteLine(output);
        }
    }
}