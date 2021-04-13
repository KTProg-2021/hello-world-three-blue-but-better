﻿using System;

namespace textBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construct the 7 "Places"
            Place Kitchen = new Place("Kitchen");
            Place DriveThru = new Place("Drive Thru");
            Place CashRegister = new Place("Cash Register");
            Place Hallway = new Place("Hallway");
            Place Bathroom = new Place("Bathroom");
            Place Storage = new Place("Storage");
            Place SittingArea = new Place("Sitting Area");

            //Add the surrounding places to the place class
            Kitchen.setPlace(CashRegister, 'n');
            Kitchen.setPlace(DriveThru, 'e');
            Kitchen.setPlace(Storage, 'w');
            Kitchen.setPlace(Hallway, 'n');

            Storage.setPlace(Kitchen, 'e');

            DriveThru.setPlace(Kitchen, 'w');

            Hallway.setPlace(Kitchen, 's');
            Hallway.setPlace(Bathroom, 'e');
            Hallway.setPlace(SittingArea, 'n');

            Bathroom.setPlace(Hallway, 'w');

            SittingArea.setPlace(Hallway, 's');

            CashRegister.setPlace(Kitchen, 's');

            //Make the array of the places
            Place[] McMonalds = new Place[7];
            McMonalds[0] = Kitchen;
            McMonalds[1] = DriveThru;
            McMonalds[2] = CashRegister;
            McMonalds[3] = Hallway;
            McMonalds[4] = Bathroom;
            McMonalds[5] = Storage;
            McMonalds[6] = SittingArea;


            Console.WriteLine("enter \"n\", \"s\", \"e\", \"w\" characters to move through McMonalds " +
                "OR enter \"a object name\" to approach an object");

            //TO DO
            //Adapt this code to take 

            //current place
            Place current = SittingArea;

            //while someone enters something
            String curStr = Console.ReadLine();
            char curChar = curStr[0];
            while (curChar > -1)
            {
                //TO DO
                //If the input is "a name" then aproach the object
                if(curChar == 'a')
                {
                    
                }
                else {
                    //I currently have the input working on one character - this will 
                    //have to be changed

                    //If the array of places isnt empty
                    if (current.getPlace(curChar).Length > 0)
                    {
                        //If the array of places in the direction isn one item long
                        if (current.getPlace(curChar).Length == 1)
                        {
                            //Console.WriteLine("You are now in the " + current.getPlace(curChar)[0].getName());
                            current = current.getPlace(curChar)[0];
                        }
                        //If the array of places is longer than one item
                        else
                        {
                            //Ask where the user would like to go
                            Console.WriteLine("Where would you like to go?");
                            foreach (Place p in current.getPlace(curChar))
                            {
                                Console.Write(p.getName() + ", ");
                            }
                            String read = Console.ReadLine();

                            //Find the place the user would like to go 
                            //based on the input
                            foreach (Place p in current.getPlace(curChar))
                            {
                                if (read == p.getName())
                                {
                                    current = p;
                                    break;
                                }
                            }
                        }
                    }
                }
                //output the where the user currently is
                Console.WriteLine("You are in " + current.getName());
                curStr = Console.ReadLine();
                curChar = curStr[0];
            }

        }
    }
}