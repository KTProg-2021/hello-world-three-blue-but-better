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
            Place DriveThru = new Place("Drive Thru");
            Place CashRegister = new Place("Cash Register");
            Place Hallway = new Place("Hallway");
            Place Bathroom = new Place("Bathroom");
            Place Storage = new Place("Storage");
            Place SittingArea = new Place("Sitting Area");

            //kitchen Objects
            Object Sink = new Object("sink", true);
            Object Fridge = new Object("fridge", true);
            Object Counter = new Object("Counter", true);
            Kitchen.setObject(Sink);
            Kitchen.setObject(Fridge);
            Kitchen.setObject(Counter);

            //Storage Objects
            Object CleaningCloset = new Object("Cleaning Closet", true);
            Object FoodSupplies = new Object("Food Supplies", true);
            Storage.setObject(CleaningCloset);
            Storage.setObject(FoodSupplies);

            //Bathroom 
            Object BSink = new Object("Bathroom Sink", true);
            Object Toilet = new Object("toilet", true);
            Bathroom.setObject(Toilet);
            Bathroom.setObject(BSink);

            //Drive thru objects 
            Object DTRegister = new Object("Drive thru cash register", true);
            Object counter = new Object("counter", true);
            DriveThru.setObject(DTRegister);
            DriveThru.setObject(counter);

            //sitting area
            Object SodaMachine = new Object("Soda Machine", true);
            Object Tables = new Object("Tables", true);
            SittingArea.setObject(Tables);
            SittingArea.setObject(SodaMachine);

            //Regiser Object 
            Object PickUp = new Object("Pick up", true);
            Object IceCreamMachine = new Object("Ice Cream Machine", true);
            Object Register = new Object("register", true);
            CashRegister.setObject(Register);
            CashRegister.setObject(IceCreamMachine);
            CashRegister.setObject(PickUp);


            //Item name = new Item("name", true);
            //parentObject.addItem(name);

            //Kitchen------ -
            Item Potatoes = new Item("Potatoes", true);
            Fridge.addItem(Potatoes);

            Item Meat = new Item("Meat", true);
            Fridge.addItem(Meat);

            Item Soda = new Item("Soda", true);
            Fridge.addItem(Soda);

            Item CuttingBoard = new Item("Cutting Board", true);
            Counter.addItem(CuttingBoard);

            Item Knife = new Item("Knife", true);
            Counter.addItem(Knife);

            Item Veggies = new Item("Veggies", true);
            Counter.addItem(Veggies);


            Item Bread = new Item("Bread", true);
            Counter.addItem(Bread);

            Item Dishes = new Item("Dishes", true);
            Sink.addItem(Dishes);

            Item Soap = new Item("Soap", true);
            Sink.addItem(Soap);

            Item Rag = new Item("Rag", true);
            Sink.addItem(Rag);
            //------------

            //Cash Register---------- -

            Item Pen = new Item("pen", true);
            Register.addItem(Pen);

            Item Pencil = new Item("pencil", true);
            Register.addItem(Pencil);

            Item Reciept = new Item("reciept", true);
            Register.addItem(Reciept);

            Item Napkins = new Item("napkins", true);
            PickUp.addItem(Napkins);

            Item Condiments = new Item("Condiments", true);
            PickUp.addItem(Condiments);

            //sitting area
            Item Cups = new Item("Cups", true);

            SodaMachine.addItem(Cups);


            Item Straws = new Item("Straws", true);

            SodaMachine.addItem(Straws);

            Item PUPen = new Item("Pen", true);

            Register.addItem(Pen);


            Item PUPencil = new Item("Pencil", true);

            Register.addItem(Pencil);


            Item PUNapkins = new Item("Napkins", true);

            PickUp.addItem(Napkins);


            Item PUCondiments = new Item("Condiments", true);

            PickUp.addItem(Condiments);


            Item Screwdriver = new Item("Screwdriver", true);

            IceCreamMachine.addItem(Screwdriver);


            //Storage-------- -
            Item Mop = new Item("mop", true);
            CleaningCloset.addItem(Mop);

            Item FSRag = new Item("rag", true); 
            CleaningCloset.addItem(Rag);

            Item ToiletPaper = new Item("Toilet Paper", true);
            CleaningCloset.addItem(ToiletPaper);

            Item Bucket = new Item("Bucket", true);
            CleaningCloset.addItem(Bucket);

            Item FSNapkins = new Item("Napkins", true);
            FoodSupplies.addItem(Napkins);

            Item FSCondiments = new Item("Condiments", true);
            FoodSupplies.addItem(Condiments);


            //Drive thru

            Item Earpiece = new Item("Earpiece", true);
            Register.addItem(Earpiece);

            Item Tickets = new Item("Tickets", true);
            Register.addItem(Tickets);

            Item DTPen = new Item("Pen", true);
            Counter.addItem(Pen);

            Item DTPencil = new Item("Pencil", true);
            Counter.addItem(Pencil);



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



            Item wrench = new Item("Wrench", true);
            CleaningCloset.addItem(wrench);

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
            input[0] = "ha";
            String output = "";

            while (!input[0].ToLower().Equals("stop"))
            {
                output = "";
                //Console.WriteLine();
                curStr = Console.ReadLine();
                input = new String[2];
                if (curStr.Length > 0)
                {
                    //input[0] = ""; input[1] = "";
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
                //Console.WriteLine(input[0]);
                if (curStr.ToLower().Contains("help"))
                {
                    output += "Options: " +
                    "\nmove - north, south, east, west (ex. move south) \napproach - object name (ex. approach sink)" +
                    "\ntake - item name (ex. take rag)\nplace - item name (ex. place rag)" +
                    "\npunch - object/item name (ex. punch sink)\nfix - object/item name (ex. fix sink)" +
                    "\nopen inventory\n";
                }
                else if(curStr.Contains(' '))
                {
                    switch(input[0].ToLower()){

                        
                        case "move":

                            if (!(input[1].ToLower().Equals("north") || input[1].ToLower().Equals("south")
                                || input[1].ToLower().Equals("east") || input[1].ToLower().Equals("west")))
                            {
                                input[1] = "A";
                            }

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

                                if (nextPlace != null)
                                {
                                    curPlace = nextPlace;

                                    output += enterPlace(curPlace);

                                    curObject = null;
                                }
                            }

                            if(output.Length < 1)
                            {
                                output += "You can't move there.\n";
                            }
                            break;
                       case "approach":
                            foreach (Object o in curPlace.getObject())
                            {
                                if (input[1].ToLower().Equals(o.name.ToLower())){
                                    curObject = o;
                                    output += "You are infront of the " + o.name + ".\n";

                                    if(o.Fixed)
                                    {
                                        output += "It is in good condition.\n";
                                    }
                                    else
                                    {
                                        output += "It is broken.\n";
                                    }
                                    

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
                                            output += "nothing";
                                        }

                                        output += ".\n";
                                    }

                                    break;
                                }
                            }
                            break;
                        case "take":
                            if(curObject != null)
                            {
                                foreach (Item i in curObject.getItem())
                                {
                                    if (input[1].ToLower().Equals(i.name.ToLower()))
                                    {
                                        inventory.Add(i);
                                        curObject.removeItem(i);
                                        output += "You have taken the " + i.name + ".\n";
                                        break;
                                    }
                                }
                            }
                            break;
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
                            break;
                        case "fix":

                            if (inventory.Contains(wrench))
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
                                output += "You need a wrench for that.\n";
                            }

                            break;

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
                                    output += i.Punch() + "\n";
                                }
                            }

                            break;

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
