using System;
using System.Collections.Generic;
using System.Text;

namespace textBasedGame
{
    class Object
    {
        //Array of items will need to be added

        //Constructor
        private String _name;
        private Boolean _conditions;
        public Object(String name)
        {
            _name = name;
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
    }
}
