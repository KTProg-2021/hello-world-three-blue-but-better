using System;
using System.Collections.Generic;
using System.Text;

namespace textBasedGame
{
    class Item
    {
        //Constructor
        private String _name;
        private Boolean _fixed;
        public Item(String name, Boolean inFixed)
        {
            _name = name;
            _fixed = inFixed;
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


        public Boolean Fixed
        {
            get
            {
                if (_fixed)
                {
                    Console.WriteLine("The " + _name + " is not broken.");
                }
                else
                {
                    Console.WriteLine("The " + _name + " is broken.");
                }

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
        }
    }
}
