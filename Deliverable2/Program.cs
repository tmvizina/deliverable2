using System;


// Deliverable 2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
//The task for Deliverable 2 is to create a chat bot with preterdemined responses as well as to demonstrate how to force the case of input strings




namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;



            string PreviousChat = "Null";

            //initializing string for check for previous input reptition check

            while (i < 1)
            {

                Console.WriteLine("What would you like to say to the bot? \n");

                //This asks the user what they would like to say to the bot

                string Chat = Console.ReadLine();

                string LChat = Chat.ToLower();
                //These take the users input and then force the case to lower to match the if statements checks

                if (LChat == "hello")
                
                {

                   if(PreviousChat == LChat)
                    
                   {
                        
                        Console.WriteLine("I'm sorry but you have already said that \n");
                    
                   }

                   //This checks to see if a matching input matches the input given on previous iteration

                   else

                   { 
                        
                        Console.WriteLine("Hi good to see you \n");

                    
                    
                   }

    
                }

                if (LChat == "bye")

                {



                    Console.WriteLine("Good Bye! \n"); ;

                    i = i + 1;


                }

                //This is the stop for the while loop that continues iterations through

                if (LChat == "sup")

                {

                    if (PreviousChat == LChat)

                    {

                        Console.WriteLine("I'm sorry but you have already said that \n");

                    }

                    else

                    {

                        Console.WriteLine("I am good \n");

                        PreviousChat = LChat;

                    }


                }

                if (LChat == "hello there")

                {

                    if (PreviousChat == LChat)

                    {

                        Console.WriteLine("I'm sorry but you have already said that \n");

                    }

                    else

                    {

                        Console.WriteLine("General Kenobi \n");

                        PreviousChat = LChat;

                    }


                }


                

               


            }
        }

    }

