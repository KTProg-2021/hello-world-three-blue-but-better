using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace textBasedGame
{
    class Object
    {
        //Array of items will need to be added

        //Constructor
        private String _name;
        private Boolean _fixed;
        private ArrayList _items;
        public Object(String name, Boolean inFixed)
        {
            _name = name;
            _fixed = inFixed;
            _items = new ArrayList();
        }

        public void addItem(Item value)
        {
            _items.Add(value);
        }

        public ArrayList getItem()
        {
            return _items;
        }
        
        public void removeItem(Item value)
        {
            _items.Remove(value);
        }

        public Boolean Fixed
        {
            get
            {/**
                if (_fixed)
                {
                    Console.WriteLine("The " + _name + " is not broken.");
                }
                else
                {
                    Console.WriteLine("The " + _name + " is broken.");
                }**/

                return _fixed;
            }

        }


        public void Fix()
        {
            if (!_fixed)
            {
                Console.WriteLine("You have fixed the " + _name + ".");
            }
            else
            {
                Console.WriteLine("The " + _name + " does not need fixing.");
            }
            _fixed = true;
        }

        public void Punch()
        {
            if (_fixed)
            {
                Console.WriteLine("Great job.  You have broken the " + _name + ".");
            }
            else
            {
                Console.WriteLine("The " + _name + " is already broken. You break it some more.");
            }
            _fixed = false;
        }


        //Get/set methods
        //Name
        public String name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }




    }
    /**
    public string ItemCond(string NameOfItem, bool CondOfItem)
    {
        string rv = "";
        switch (NameOfItem)
        {
            case "Fridge":
                switch (CondOfItem)
                {
                    case true:
                        Console.WriteLine("Fridge is running");
                        break;
                    case false:
                        Console.WriteLine("Fridge is not Running");
                        break;
                    default:
                        Console.WriteLine("Null");
                        break;
                }
                break;
            case :
                Console.WriteLine("Case 2");
                break;
            default:
                Console.WriteLine("Default case");
                break;

                return rv;
        }
    }**/
}
