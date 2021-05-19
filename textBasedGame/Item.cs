using System;
using System.Collections.Generic;
using System.Text;

namespace textBasedGame
{
    class Item
    {
        //Constructor
        private String _name, _takeText;
        private Boolean _fixed;
        public Item(String name, Boolean inFixed)
        {
            _name = name;
            _fixed = inFixed;
            _takeText = "";
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

        public String TakeText
        {
            get
            {
                return _takeText;
            }
            set
            {
                _takeText = value + "\n";
            }
        }

        public Boolean Fixed
        {
            get
            {
                /**if (_fixed)
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


        public String Fix()
        {
            String output;
            if (!_fixed)
            {
                output = "You have fixed the " + _name + ".";
            }
            else
            {
                output = "The " + _name + " does not need fixing.";
            }
            _fixed = true;
            return output;
        }

        public String Punch()
        {
            String output;
            if (_fixed)
            {
                output = "Great job.  You have broken the " + _name + ".";
            }
            else
            {
                output = "The " + _name + " is already broken. You break it some more.";
            }
            _fixed = false;
            return output;
        }
    }
}
