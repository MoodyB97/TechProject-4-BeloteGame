//: Tech Project Bela 
//: Programmer: Delta Team
//: Date: 10/13/2021
using System;

namespace TechProject_4_BeloteGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of hands to be played and the Dominant Suit for the Game like (1 S)");
            //This will prompt the user for number of hands and the dominant suit it will show to user the 
            string[] input = Console.ReadLine().ToUpper().Split(" ");
            //Saves the users input as a string and splitts the string into two parts using a space in the input array

            int numberofhands = int.Parse(input[0]);
            //Converts the String input a Intger value that uses the substring 0 and saves it 

            char dominantsuitforgame = input[1][0];
            //Saves the substring user input as the Char variable called dominatsuitforthegame

            int totalpointsforthegame = 0;
            //A variable that stores the total points scored in the game

            for (int i = 0; i < numberofhands * 4; i++)
            //This for loop counts the number of hands and iterates through the array named CARD below
            {
                char[] CARD = Console.ReadLine().ToUpper().ToCharArray();
                //An Array containing the user inputs that were entered above containing individual card values

                char CardsValue = CARD[0];
                //This saves the first index value from the CARD array as the char variable called CardsValue 

                char Cardssuit = CARD[1];
                //This saves the second index value from the CARD array as the char variable Cardssuit

                if (CardsValue == 'A')
                {
                    totalpointsforthegame += 11;
                }
                //This if block checks the value of an entered card and adds 11 to the total if the card is an "A"

                if (CardsValue == 'K')
                {
                    totalpointsforthegame += 4;
                }
                //This if block checks the value of an entered card and adds 4 to the total if the card is an "K"

                if (CardsValue == 'Q')
                {
                    totalpointsforthegame += 3;
                }
                //This if block checks the value of an entered card and adds 3 to the total if the card is an "Q"

                if (CardsValue == 'J')
                {
                    if (Cardssuit == dominantsuitforgame)
                    {
                        totalpointsforthegame += 20;
                    }
                    //This if block checks the value of an entered card and weather it is Dominant and adds 20 to the total if the card is an "J"

                    else
                    {
                        totalpointsforthegame += 2;
                    }
                    //This else checks the value of the card and if it is not dominant then it adds 2 to the total 
                }
                if (CardsValue == 'T')
                {
                    totalpointsforthegame += 10;
                }
                    //This if block checks the value of an entered card and adds 10 to the total if the card is an "T"
                if (CardsValue == '9')
                {
                    if (Cardssuit == dominantsuitforgame)
                        totalpointsforthegame += 14;
                   //This If block checks the value of the card and if it is dominant adds 14 to the totalpointsscoredforgame variable


                if (CardsValue == '8')
                    {
                        totalpointsforthegame += 0;
                    }
                    //This if block checks the value of the card and adds 0 to the total 

                if (CardsValue == '7')
                    {
                        totalpointsforthegame += 0;
                    }
                    //This if block checks the value of the card and adds 0 to the total 

                    if (CardsValue == '6')
                    {
                        totalpointsforthegame += 0;
                    }
                    //This if block checks the value of the card and adds 0 to the total 

                    if (CardsValue == '5')
                    {
                        totalpointsforthegame += 0;
                    }
                    //This if block checks the value of the card and adds 0 to the total 

                    if (CardsValue == '4')
                    {
                        totalpointsforthegame += 0;
                    }
                    //This if block checks the value of the card and adds 0 to the total 

                    if (CardsValue == '3')
                    {
                        totalpointsforthegame += 0;
                    }
                    //This if block checks the value of the card and adds 0 to the total 

                    if (CardsValue == '2')
                    {
                        totalpointsforthegame += 0;
                    }
                    //This if block checks the value of the card and adds 0 to the total 

                    else
                    {
                        continue;
                    }
                    //This else block continues the loop

                }
                else
                {
                   continue ;
                }
                //this else block continues the loop till completion

            }

            Console.WriteLine(totalpointsforthegame);
            //Displays the total points scored in the game to the console
        }
    }
}
    

