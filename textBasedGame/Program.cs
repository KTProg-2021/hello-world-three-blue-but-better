using System;
using System.Collections;

namespace textBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construct the 7 "Places"
            Place Kitchen = new Place("Kitchen");
            Kitchen.EnterText = "Description of place";
            Place DriveThru = new Place("Drive Thru");
            DriveThru.EnterText = "Description of place";
            Place CashRegister = new Place("Cash Register");
            CashRegister.EnterText = "Description of place";
            Place Hallway = new Place("Hallway");
            Hallway.EnterText = "Description of place";
            Place Bathroom = new Place("Bathroom");
            Bathroom.EnterText = "Description of place";
            Place Storage = new Place("Storage");
            Storage.EnterText = "Description of place";
            Place SittingArea = new Place("Sitting Area");
            SittingArea.EnterText = "Description of place";

            //Kitchen Objects
            Object Sink = new Object("Sink", true);
            Kitchen.setObject(Sink);
            Sink.ApproachText = "Description of thing";

            Object Fridge = new Object("Fridge", true);
            Kitchen.setObject(Fridge);
            Fridge.ApproachText = "Description of thing";

            Object Counter = new Object("Counter", true);
            Kitchen.setObject(Counter);
            Counter.ApproachText = "Description of thing";

            //Storage Objects
            Object CleaningCloset = new Object("Cleaning Closet", true);
            Storage.setObject(CleaningCloset);
            CleaningCloset.ApproachText = "Description of thing";

            Object FoodSupplies = new Object("Food Supplies", true);
            Storage.setObject(FoodSupplies);
            FoodSupplies.ApproachText = "Description of thing";

            //Bathroom 
            Object BSink = new Object("Sink", true);
            Bathroom.setObject(BSink);
            BSink.ApproachText = "Description of thing";

            Object Toilet = new Object("Toilet", true);
            Bathroom.setObject(Toilet);
            Toilet.ApproachText = "Description of thing";

            //Drive thru objects 
            Object DTRegister = new Object("Drive-Thru Cash Register", true);
            DriveThru.setObject(DTRegister);
            DTRegister.ApproachText = "Description of thing";

            Object DTCounter = new Object("Counter", true);
            DriveThru.setObject(DTCounter);
            DTCounter.ApproachText = "Description of thing";

            //sitting area
            Object SodaMachine = new Object("Soda Machine", true);
            SittingArea.setObject(SodaMachine);
            SodaMachine.ApproachText = "Description of thing";

            Object Tables = new Object("Tables", true);
            SittingArea.setObject(Tables);
            Tables.ApproachText = "Description of thing";

            //Regiser Object 
            Object PickUp = new Object("Pick up", true);
            CashRegister.setObject(PickUp);
            PickUp.ApproachText = "Description of thing";

            Object IceCreamMachine = new Object("Ice Cream Machine", true);
            CashRegister.setObject(IceCreamMachine);
            IceCreamMachine.ApproachText = "Description of thing";

            Object Register = new Object("Register", true);
            CashRegister.setObject(Register);
            Register.ApproachText = "Description of thing";

            //Hallway Objects
            Object CreepyMural = new Object("Creepy Mural", false);
            Hallway.setObject(CreepyMural);
            CreepyMural.ApproachText = "The mural is creepy, and you very much want to leave it.";

            //Item name = new Item("name", true);
            //parentObject.addItem(name);

            //Kitchen------ -
            Item Fridge_Potatoes = new Item("Potatoes", true);
            Fridge.addItem(Fridge_Potatoes);

            Item Fridge_Meat = new Item("Meat", true);
            Fridge.addItem(Fridge_Meat);

            Item Fridge_Soda = new Item("Soda", true);
            Fridge.addItem(Fridge_Soda);

            Item Counter_CuttingBoard = new Item("Cutting Board", true);
            Counter.addItem(Counter_CuttingBoard);

            Item Counter_Knife = new Item("Knife", true);
            Counter.addItem(Counter_Knife);

            Item Counter_Veggies = new Item("Veggies", true);
            Counter.addItem(Counter_Veggies);

            Item Counter_Bread = new Item("Bread", true);
            Counter.addItem(Counter_Bread);

            Item Sink_Dishes = new Item("Dishes", true);
            Sink.addItem(Sink_Dishes);

            Item Sink_Soap = new Item("Soap", true);
            Sink.addItem(Sink_Soap);

            Item Sink_Rag = new Item("Rag", true);
            Sink.addItem(Sink_Rag);

            //Cash Register---------- -
            Item Register_Pen = new Item("Pen", true);
            Register.addItem(Register_Pen);

            Item Register_Pencil = new Item("Pencil", true);
            Register.addItem(Register_Pencil);

            Item Register_Reciept = new Item("Reciept", true);
            Register.addItem(Register_Reciept);

            Item PickUp_Napkins = new Item("Napkins", true);
            PickUp.addItem(PickUp_Napkins);

            Item PickUp_Condiments = new Item("Condiments", true);
            PickUp.addItem(PickUp_Condiments);

            Item IceCreamMachine_Screwdriver = new Item("Screwdriver", true);
            IceCreamMachine.addItem(IceCreamMachine_Screwdriver);

            //Sitting area
            Item SodaMachine_Cups = new Item("Cups", true);
            SodaMachine.addItem(SodaMachine_Cups);

            Item SodaMachine_Straws = new Item("Straws", true);
            SodaMachine.addItem(SodaMachine_Straws);

            
            //Storage-------- -
            Item CleaningCloset_Mop = new Item("Mop", true);
            CleaningCloset.addItem(CleaningCloset_Mop);

            Item CleaningCloset_Rag = new Item("Rag", true); 
            CleaningCloset.addItem(CleaningCloset_Rag);

            Item CleaningCloset_ToiletPaper = new Item("Toilet Paper", true);
            CleaningCloset.addItem(CleaningCloset_ToiletPaper);

            Item CleaningCloset_Bucket = new Item("Bucket", true);
            CleaningCloset.addItem(CleaningCloset_Bucket);

            Item FoodSupplies_Napkins = new Item("Napkins", true);
            FoodSupplies.addItem(FoodSupplies_Napkins);

            Item FoodSupplies_Condiments = new Item("Condiments", true);
            FoodSupplies.addItem(FoodSupplies_Condiments);


            //Drive thru
            Item DTRegister_Earpiece = new Item("Earpiece", true);
            DTRegister.addItem(DTRegister_Earpiece);

            Item DTRegister_Tickets = new Item("Tickets", true);
            DTRegister.addItem(DTRegister_Tickets);

            Item DTCounter_Pen = new Item("Pen", true);
            DTCounter.addItem(DTCounter_Pen);

            Item DTCounter_Pencil = new Item("Pencil", true);
            DTCounter.addItem(DTCounter_Pencil);



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


            int wrenchVengance = 0;
            Item CleaningCloset_Wrench = new Item("Wrench", true);
            CleaningCloset.addItem(CleaningCloset_Wrench);
            CleaningCloset_Wrench.TakeText = "The mystical wrench can fix all things.";

            //Print out options
            Console.WriteLine("Options: " +
                "\nmove - north, south, east, west (ex. move south) \napproach - object name (ex. approach sink)" +
                "\ntake - item name (ex. take rag)\nplace - item name (ex. place rag)" +
                "\npunch - object/item name (ex. punch sink)\nfix - object/item name (ex. fix sink)" +
                "\nopen inventory\n");

            //current place
            Place curPlace = SittingArea;
            Console.WriteLine(enterPlace(curPlace));

            Object curObject = null;

            ArrayList inventory = new ArrayList();

            //while someone enters something
            String curStr;
            String[] input = new String[2];
            input[0] = "-";
            String output = "";

            while (!input[0].ToLower().Equals("stop"))
            {
                output = "";
                //Console.WriteLine();

                //Splits the input into two parts
                //input[0] is everything before the first space
                //input[1] is everything after the first space
                //for example "approach sitting area" would be split like
                //input[0] = approach
                //input[1] = sitting area
                curStr = Console.ReadLine();
                input = new String[2];
                if (curStr.Length > 0)
                {
                    input[0] = ""; input[1] = "";
                    Char cur = curStr[0];
                    int count = 0;

                    while(cur != ' ')
                    {
                        input[0] += cur;
                        if (count < curStr.Length - 2)
                        {
                            count++;
                            cur = curStr[count];
                        }
                        else
                        {
                            break;
                        }
                    }
                    input[1] = curStr.Substring(count + 1);
                }

                //Catch Error - nothing entered
                if(curStr.Length < 1)
                {
                    input[0] = "-";
                }

                //Console.WriteLine(input[0]);
                //Help case
                if (curStr.ToLower().Contains("help"))
                {
                    output += "Options: " +
                    "\nmove - north, south, east, west (ex. move south) \napproach - object name (ex. approach sink)" +
                    "\ntake - item name (ex. take rag)\nplace - item name (ex. place rag)" +
                    "\npunch - object/item name (ex. punch sink)\nfix - object/item name (ex. fix sink)" +
                    "\nopen inventory\n";
                }
                else if (curStr.ToLower().Contains("hint"))
                {
                    //TO DO - HINTS CODE
                }
                //If the string contains a space (Two or more words)
                else if(curStr.Contains(' '))
                {
                    switch(input[0].ToLower()){
                        case "leave":
                            //TO DO - LEAVE CODE
                            //Write code that will tell the user they have left the object
                            //and then set the "curObject" varible to nothing
                            break;

                        //if the first word is move
                        case "move":

                            //This piece of code just makes it so "spoon" isnt recognised as south
                            if (!(input[1].ToLower().Equals("north") || input[1].ToLower().Equals("south")
                                || input[1].ToLower().Equals("east") || input[1].ToLower().Equals("west")))
                            {
                                input[1] = "A";
                            }

                            //Checks if the next place is a place you can go
                            Place[] nextPlaces = curPlace.getPlace(input[1][0]);
                            if (nextPlaces != null && nextPlaces.Length > 0) {
                                Place nextPlace = null;

                                if (nextPlaces.Length == 1)
                                {
                                    nextPlace = nextPlaces[0];
                                }
                                else
                                {
                                    foreach (Place p in nextPlaces)
                                    {
                                        output += p.getName();
                                    }

                                    Console.WriteLine("Where would you like to go?");
                                    String inName = Console.ReadLine();

                                    foreach (Place p in nextPlaces)
                                    {
                                        if (inName.ToLower().Equals(p.getName().ToLower()))
                                        {
                                            nextPlace = p;
                                        }
                                    }
                                }

                                //If the next place is somewhere you can go
                                //Make the current place this place
                                if (nextPlace != null)
                                {
                                    curPlace = nextPlace;

                                    output += enterPlace(curPlace);

                                    curObject = null;
                                }
                            }

                            //If the input isnt good
                            if(output.Length < 1)
                            {
                                output += "You can't move there.\n";
                            }
                            break;
                       //approach code
                       case "approach":
                            //Checks if the object is in the current place
                            foreach (Object o in curPlace.getObject())
                            {
                                if (input[1].ToLower().Equals(o.name.ToLower())){
                                    curObject = o;
                                    //Prints out neccessary information
                                    output += "You are infront of the " + o.name + ".\n";
                                    output += curObject.ApproachText;

                                    if(o.Fixed)
                                    {
                                        output += "It is in good condition.\n";
                                    }
                                    else
                                    {
                                        output += "It is broken.\n";
                                    }
                                    
                                    //Prints out items
                                    if (curPlace.getObject().Count > 0)
                                    {
                                        output += "At the " + o.name + " there is ";
                                        String curOutput = "";
                                        foreach (Item i in curObject.getItem())
                                        {
                                            curOutput += i.name + ", ";
                                        }
                                        output += curOutput;
                                        if(curOutput.Length == 0)
                                        {
                                            output += "nothing you can take";
                                        }
                                        else
                                        {
                                            output += "that you can take";
                                        }

                                        output += ".\n";
                                    }
                                    break;
                                }
                            }
                            //If input isnt good
                            if (output.Length < 1)
                            {
                                output += "You can't approach that (your spelling must be correct).\n";
                            }
                            break;
                        //Take code
                        case "take":
                            //Checks if the item is at the object you are currently at
                            if(curObject != null)
                            {
                                foreach (Item i in curObject.getItem())
                                {
                                    if (input[1].ToLower().Equals(i.name.ToLower()))
                                    {
                                        //Adds it to inventory, removes it from the current object
                                        inventory.Add(i);
                                        curObject.removeItem(i);
                                        output += "You have taken the " + i.name + ".\n";
                                        output += i.TakeText;
                                        if (i.Fixed)
                                        {
                                            output += "It is in good condition.\n";
                                        }
                                        else
                                        {
                                            output += "It is broken.\n";
                                        }
                                        break;
                                    }
                                }
                            }
                            //If the input isnt good
                            if (output.Length < 1)
                            {
                                output += "That item is not here to take (your spelling must be correct).\n";
                            }
                            break;
                        //Place code - opposite of take
                        case "place":
                            if (curObject != null)
                            {
                                foreach (Item i in curObject.getItem())
                                {
                                    if (input[1].ToLower().Equals(i.name.ToLower()))
                                    {
                                        inventory.Add(i);
                                        curObject.addItem(i);
                                        output += "You have placed the " + i.name + " at the " 
                                            + curObject.name + ".\n";
                                        break;
                                    }
                                }
                            }
                            if (output.Length < 1)
                            {
                                output += "That item is not in your inventory (your spelling must be correct).\n";
                            }
                            break;
                        //Fix code
                        case "fix":

                            if (inventory.Contains(CleaningCloset_Wrench))
                            {
                                if (curObject != null)
                                {
                                    if (input[1].ToLower().Equals(curObject.name.ToLower()))
                                    {
                                        output += curObject.Fix() + "\n";
                                    }
                                }

                                foreach (Item i in inventory)
                                {
                                    if (input[1].ToLower().Equals(i.name.ToLower()))
                                    {
                                        output += i.Fix() + "\n";
                                    }
                                }
                            }
                            else
                            {
                                output += "You need a wrench for that (in the cleaning supplies in the storage closet).\n";
                            }

                            if (output.Length < 1)
                            {
                                output += "That item is not here to fix (your spelling must be correct).\n";
                            }

                            break;
                        //Punch code
                        case "punch":
                            if(curObject != null)
                            {
                                if (input[1].ToLower().Equals(curObject.name.ToLower()))
                                {
                                    output += curObject.Punch() + "\n";
                                }
                            }

                            foreach(Item i in inventory)
                            {
                                if (input[1].ToLower().Equals(i.name.ToLower()))
                                {
                                    if (input[1].ToLower().Equals("wrench"))
                                    {
                                        //please ignore this
                                        if (wrenchVengance == 3)
                                        {
                                            output += "You punch the wrench for a third time, and it begins to grow hot in your hand";
                                        }
                                        else if (wrenchVengance > 3)
                                        {
                                            output += "The wrench explodes, you die. This was the final boss all along. Great job dying to a wrench.";
                                            input[0] = "stop";
                                        }
                                        else
                                        {
                                            output += "You punch the wrench, but you cannot manage to break it.";
                                        }
                                        wrenchVengance++;
                                    }
                                    else 
                                    {
                                        output += i.Punch() + "\n"; 
                                    }
                                }
                            }

                            if (output.Length < 1)
                            {
                                output += "The thing you are trying to punch is not around you (your spelling must be correct).\n";
                            }

                            break;
                        //Open inventory - prints out inventory
                        case "open":
                            if (input[1].ToLower().Equals("inventory"))
                            {
                                foreach(Item i in inventory)
                                {
                                    output += i.name + ", ";
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    if (output.Length < 1)
                    {
                        Console.WriteLine("Your input is bad and we hate you.");
                    }
                    else
                    {
                        Console.WriteLine(output);
                    }

                }
                else
                {
                    Console.WriteLine("Your input is super bad and we are ok with your existance");
                }
            }

            Console.WriteLine("Thank you for playing!");

            /**
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
                    //find object were looking for
                    string curObject = curStr.Substring(1,curStr.Length);

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
    
            }**/

        }

        public static String enterPlace(Place curPlace)
        {
            String output = "You are in the " + curPlace.getName() + ".\n";
            output += curPlace.EnterText;
            if (curPlace.getObject().Count > 0)
            {
                output += "Here you see ";
                foreach (Object o in curPlace.getObject())
                {
                    output += o.name + ", ";
                }

                output += ".\n";
            }
            else
            {
                output += "There is nothing here to approach.\n";
            }

            output += "You can go: ";
            String curOutput = "";
            foreach (Place p in curPlace.getPlace('n'))
            {
                curOutput += p.getName() + ",";
            }
            if(curOutput.Length > 0)
            {
                output += "North: " + curOutput + " ";
            }

            curOutput = "";
            foreach (Place p in curPlace.getPlace('e'))
            {
                curOutput += p.getName() + ",";
            }
            if (curOutput.Length > 0)
            {
                output += "East: " + curOutput + " ";
            }

            curOutput = "";
            foreach (Place p in curPlace.getPlace('s'))
            {
                curOutput += p.getName() + ",";
            }
            if (curOutput.Length > 0)
            {
                output += "South: " + curOutput + " ";
            }

            curOutput = "";
            foreach (Place p in curPlace.getPlace('w'))
            {
                curOutput += p.getName() + ",";
            }
            if (curOutput.Length > 0)
            {
                output += "West: " + curOutput + " ";
            }

            return output + "\n";
        }
    }
}
